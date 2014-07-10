using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Utilities.Net.Sockets;
using Utilities.Common.ExtensionMethods;

namespace TcpServer
{
    public partial class MainForm : Form
    {
        private class TransmissionStatistic
        {
            public Int64 SentBytes { get; set; }

            public Int64 ReceivedBytes { get; set; }

            public Int64 SentTotalBytes { get; set; }

            public Int64 ReceivedTotalBytes { get; set; }
        }

        private IDictionary<SocketClientBase, TransmissionStatistic> _connectedClients;
        private SocketServerBase _socketServer;

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            _connectedClients = new Dictionary<SocketClientBase, TransmissionStatistic>();
            RadioButtonCheckedChanged(this, EventArgs.Empty);
            RefreshStatusStrip();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            try
            {
                _socketServer.Stop();
                _socketServer.Dispose();
            }
            catch
            {
            }
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            txtSendDataEncoding.ReadOnly = !radioSendDataText.Checked;
            txtReceivedDataEncoding.ReadOnly = !radioReceivedDataText.Checked;
        }

        private void CheckboxAllNetworkClick(object sender, EventArgs e)
        {
            txtLocalAddress.Enabled = !chkAllNetwork.Checked;
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            RefreshStatusStrip();
        }

        private void ButtonBrowseCertificateFileClick(object sender, EventArgs e)
        {
            var directoryName = "";
            try
            {
                directoryName = Path.GetDirectoryName(txtCertificateFile.Text);
            }
            catch
            {
            }

            var dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (Directory.Exists(directoryName))
            {
                dialog.InitialDirectory = directoryName;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtCertificateFile.Text = dialog.FileName;
            }
        }

        private void ButtonClearTextBoxClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var controls = Controls.Find((String)button.Tag, true);
            var textBox = (TextBox)controls[0];
            textBox.Clear();
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            try
            {

                Int32 localPort;
                if (!Int32.TryParse(txtLocalPort.Text, out localPort)) throw new Exception("Local port number is wrong.");
                _socketServer = cmbUseSSL.SelectedIndex == 0 ? (SocketServerBase)(chkAllNetwork.Checked ? new SocketServerSslAsync(IPAddress.Any, localPort) : new SocketServerSslAsync(txtLocalAddress.Text, localPort)) :
                                                               (SocketServerBase)(chkAllNetwork.Checked ? new SocketServerAsync(IPAddress.Any, localPort) : new SocketServerAsync(txtLocalAddress.Text, localPort));
                _socketServer.Context = WindowsFormsSynchronizationContext.Current;
                _socketServer.Connected += SocketClientConnected;
                _socketServer.Disconnected += SocketClientDisconnected;
                _socketServer.SentData += SocketClientSentData;
                _socketServer.ReceivedData += SocketClientReceivedData;
                _socketServer.SocketError += SocketClientSocketError;
                _socketServer.Error += SocketClientError;
                _socketServer.SocketSecurity += SocketSecurityEventRaised;

                if (cmbUseSSL.SelectedIndex == 0)
                {
                    ((SocketServerSslAsync)_socketServer).SslProtocol = (SslProtocols)Enum.Parse(typeof(SslProtocols), cmbSSLProtocol.Text);
                    ((SocketServerSslAsync)_socketServer).CheckCertificateRevocation = cmbCertificateRevocation.SelectedIndex == 0;
                    ((SocketServerSslAsync)_socketServer).CertificateValidationCallback = CertificateErrorsCallback;
                    ((SocketServerSslAsync)_socketServer).ServerCertificate = String.IsNullOrEmpty(txtCertificatePassword.Text) ? new X509Certificate2(txtCertificateFile.Text) : new X509Certificate2(txtCertificateFile.Text, txtCertificatePassword.Text);
                }

                _socketServer.Start();
                EnableDisableButtonControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableButtonControls(true);
            }
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            if (_socketServer != null)
            {
                _socketServer.Stop();
                _socketServer.Dispose();
                EnableDisableButtonControls(true);
            }
        }

        private void ButtonSendToClientClick(object sender, EventArgs e)
        {
            var socketClient = GetSelectedClient();
            if (socketClient == null)
            {
                MessageBox.Show("You should select a client from the list.");
                return;
            }

            try
            {
                Byte[] data = radioSendDataHex.Checked ? txtSendData.Text.ToByteArray() : Encoding.GetEncoding(txtSendDataEncoding.Text).GetBytes(txtSendData.Text);
                socketClient.SendData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSendToAllClientsClick(object sender, EventArgs e)
        {
            try
            {
                Byte[] data = radioSendDataHex.Checked ? txtSendData.Text.ToByteArray() : Encoding.UTF8.GetBytes(txtSendData.Text);
                _socketServer.SendAllClients(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDisconnectClientClick(object sender, EventArgs e)
        {
            var socketClient = GetSelectedClient();
            if (socketClient == null)
            {
                MessageBox.Show("You should select a client from the list.");
                return;
            }
            socketClient.Disconnect();
        }

        private void ButtonDisconnectAllClientsClick(object sender, EventArgs e)
        {
            foreach (var socketClient in _socketServer.SocketClients)
            {
                socketClient.Disconnect();
            }
        }

        private void SocketClientConnected(object sender, SocketEventArgs e)
        {
            var message = String.Format("A client {0}:{1} has connected to the server", e.RemotePoint.Address, e.RemotePoint.Port);
            WriteToTextBox(txtStatusLog, message);
            EnableDisableButtonControls(false);
            BindGridView(gridConnectedClients, _socketServer.SocketClients);

            var socketClient = _socketServer.FindClient(e.RemotePoint);
            if (socketClient != null && !_connectedClients.ContainsKey(socketClient))
            {
                var statistic = new TransmissionStatistic();
                _connectedClients.Add(socketClient, statistic);
                RefreshStatusStrip();
            }
        }

        private void SocketClientDisconnected(object sender, SocketEventArgs e)
        {
            var message = String.Format("A client {0}:{1} has disconnected from the server", e.RemotePoint.Address, e.RemotePoint.Port);
            WriteToTextBox(txtStatusLog, message);
            BindGridView(gridConnectedClients, _socketServer.SocketClients);

            var socketClient = _connectedClients.Keys.FirstOrDefault(x => !x.Client.Connected);
            if (socketClient != null)
            {
                _connectedClients.Remove(socketClient);
                RefreshStatusStrip();
            }
        }

        private void SocketClientSentData(object sender, SocketSendEventArgs e)
        {
            var sentBytes = e.SendedData.Length;
            var socketClient = _socketServer.FindClient(e.RemotePoint);
            if (_connectedClients.ContainsKey(socketClient))
            {
                _connectedClients[socketClient].SentBytes = sentBytes;
                _connectedClients[socketClient].SentTotalBytes += sentBytes;
            }

            var message = String.Format("The server sent data to the client {0}:{1}, Length: {2} bytes", e.RemotePoint.Address, e.RemotePoint.Port, sentBytes);
            WriteToTextBox(txtStatusLog, message);
            RefreshStatusStrip();
        }

        private void SocketClientReceivedData(object sender, SocketReceiveEventArgs e)
        {
            try
            {
                var receivedBytes = e.ReceivedData.Length;
                var socketClient = _socketServer.FindClient(e.RemotePoint);
                if (_connectedClients.ContainsKey(socketClient))
                {
                    _connectedClients[socketClient].ReceivedBytes = receivedBytes;
                    _connectedClients[socketClient].ReceivedTotalBytes += receivedBytes;
                }

                var dataMessage = radioReceivedDataHex.Checked ? e.ReceivedData.ToByteString() : Encoding.GetEncoding(txtReceivedDataEncoding.Text).GetString(e.ReceivedData);
                var logMessage = String.Format("The server received data from the client {0}:{1}, Length: {2} bytes", e.RemotePoint.Address, e.RemotePoint.Port, receivedBytes);
                WriteToTextBox(txtReceivedData, dataMessage);
                WriteToTextBox(txtStatusLog, logMessage);
                RefreshStatusStrip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SocketSecurityEventRaised(object sender, SocketSecurityEventArgs e)
        {
            var message = String.Format("Socket Security Event:  SSL Protocol: {0}, Is Server: {1}, Is Authenticated: {2}, Is Encrypted: {3}", e.Stream.SslProtocol, e.Stream.IsServer, e.Stream.IsAuthenticated, e.Stream.IsEncrypted);
            WriteToTextBox(txtStatusLog, message);
        }

        private void SocketClientSocketError(object sender, SocketErrorEventArgs e)
        {
            var message = String.Format("Socket error, Message: {0}", e.SocketException.Message);
            WriteToTextBox(txtStatusLog, message);
        }

        private void SocketClientError(object sender, Utilities.Net.Sockets.ErrorEventArgs e)
        {
            var message = String.Format("Error, Message: {0}", e.Exception.Message);
            WriteToTextBox(txtStatusLog, message);
        }

        private Boolean CertificateErrorsCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors != SslPolicyErrors.None)
            {
                var message = new StringBuilder();
                message.AppendFormat("IgnoreCertificateErrorsCallback: {0}", sslPolicyErrors);
                if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) != 0)
                {
                    foreach (X509ChainStatus chainStatus in chain.ChainStatus)
                    {
                        message.AppendFormat("{0}{1}", chainStatus.Status, Environment.NewLine);
                    }
                }
                Invoke(new Action(() => { WriteToTextBox(txtStatusLog, message.ToString()); }));
            }
            return true;
        }

        private void InitializeControls()
        {
            cmbUseSSL.Items.Clear();
            cmbUseSSL.DisplayMember = "Key";
            cmbUseSSL.ValueMember = "Value";
            cmbUseSSL.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbUseSSL.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbUseSSL.SelectedIndexChanged += (s, e) => { EnableDisableSslControls(cmbUseSSL.SelectedIndex == 0); };
            cmbUseSSL.SelectedIndex = 1;
            cmbCertificateRevocation.Items.Clear();
            cmbCertificateRevocation.DisplayMember = "Key";
            cmbCertificateRevocation.ValueMember = "Value";
            cmbCertificateRevocation.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbCertificateRevocation.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbCertificateRevocation.SelectedIndex = 1;
            cmbSSLProtocol.Items.AddRange(Enum.GetNames(typeof(SslProtocols)));
            cmbSSLProtocol.Text = "Default";
        }

        private void WriteToTextBox(TextBox textBox, String text)
        {
            var message = String.Format("{0:HH:mm:ss.fff}  -  {1}{2}", DateTime.Now, text, Environment.NewLine);
            textBox.Text += message;
            textBox.Select(textBox.Text.Length - 2, 1);
            textBox.ScrollToCaret();
        }

        private void EnableDisableButtonControls(Boolean enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
            btnDisconnectClient.Enabled = !enable;
            btnDisconnectAllClients.Enabled = !enable;
            btnSendToClient.Enabled = !enable;
            btnSendToAllClients.Enabled = !enable;
        }

        private void EnableDisableSslControls(Boolean enable)
        {
            lblSSLProtocol.Enabled = enable;
            cmbSSLProtocol.Enabled = enable;
            lblCertificateRevocation.Enabled = enable;
            cmbCertificateRevocation.Enabled = enable;
            btnBrowseCertificateFile.Enabled = enable;
            lblCertificateFile.Enabled = enable;
            txtCertificateFile.Enabled = enable;
            lblCertificatePassword.Enabled = enable;
            txtCertificatePassword.Enabled = enable;
        }

        private void RefreshStatusStrip()
        {
            Int64 sentBytes = 0;
            Int64 receivedBytes = 0;
            Int64 sentTotalBytes = 0;
            Int64 receivedTotalBytes = 0;
            var socketClient = GetSelectedClient();
            if (socketClient != null && _connectedClients.ContainsKey(socketClient))
            {
                var statistic = _connectedClients[socketClient];
                sentBytes = statistic.SentBytes;
                receivedBytes = statistic.ReceivedBytes;
                sentTotalBytes = statistic.SentTotalBytes;
                receivedTotalBytes = statistic.ReceivedTotalBytes;
            }
            lblSentBytes.Text = "Sent Bytes: " + sentBytes;
            lblReceivedBytes.Text = "Received Bytes: " + receivedBytes;
            lblSentTotalBytes.Text = "Sent Total Bytes: " + sentTotalBytes;
            lblReceivedTotalBytes.Text = "Received Total Bytes: " + receivedTotalBytes;
        }

        private void BindGridView(DataGridView gridView, IList<SocketClientBase> socketClients)
        {
            gridView.Rows.Clear();
            foreach (SocketClientBase socketClient in socketClients)
            {
                var i = gridView.Rows.Add();
                var remoteEndPoint = (IPEndPoint)socketClient.Client.RemoteEndPoint;
                gridView.Rows[i].Cells[0].Value = remoteEndPoint.Address;
                gridView.Rows[i].Cells[1].Value = remoteEndPoint.Port;
            }
        }

        private SocketClientBase GetSelectedClient()
        {
            SocketClientBase socketClient = null;
            var selectedRows = gridConnectedClients.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var selectedRow = selectedRows[0];
                if (selectedRow.Cells.Count == 2 && selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    var address = (IPAddress)selectedRow.Cells[0].Value;
                    var port = (Int32)selectedRow.Cells[1].Value;
                    var endPoint = new IPEndPoint(address, port);
                    socketClient = (SocketClientBase)_socketServer.FindClient(endPoint);
                }
            }
            return socketClient;
        }
    }
}