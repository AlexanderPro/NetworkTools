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

namespace TcpClient
{
    public partial class MainForm : Form
    {
        private Int64 _sentBytes;
        private Int64 _receivedBytes;
        private Int64 _sentTotalBytes;
        private Int64 _receivedTotalBytes;
        private SocketClientBase _socketClient;

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            _sentBytes = 0;
            _receivedBytes = 0;
            _sentTotalBytes = 0;
            _receivedTotalBytes = 0;
            RadioButtonCheckedChanged(this, EventArgs.Empty);
            RefreshStatusStrip();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            try
            {
                _socketClient.Dispose();
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

        private void ButtonConnectClick(object sender, EventArgs e)
        {
            try
            {
                _socketClient = cmbUseSSL.SelectedIndex == 0 ? (SocketClientBase)new SocketClientSsl() : (SocketClientBase)new SocketClient();
                _socketClient.Context = WindowsFormsSynchronizationContext.Current;
                _socketClient.Connected += SocketClientConnected;
                _socketClient.SentData += SocketClientSentData;
                _socketClient.ReceivedData += SocketClientReceivedData;
                _socketClient.Disconnected += SocketClientDisconnected;
                _socketClient.SocketError += SocketClientSocketError;
                _socketClient.Error += SocketClientError;
                _socketClient.SocketSecurity += SocketSecurityEventRaised;
                Int32 port;
                if (!Int32.TryParse(txtRemotePort.Text, out port)) throw new Exception("Remote port number is wrong.");
                var address = txtRemoteAddress.Text;
                if (cmbUseSSL.SelectedIndex == 0)
                {
                    ((SocketClientSsl)_socketClient).RemoteHostName = txtTargetHostName.Text;
                    ((SocketClientSsl)_socketClient).SslProtocol = (SslProtocols)Enum.Parse(typeof(SslProtocols), cmbSSLProtocol.Text);
                    ((SocketClientSsl)_socketClient).CheckCertificateRevocation = cmbCertificateRevocation.SelectedIndex == 0;
                    ((SocketClientSsl)_socketClient).CertificateValidationCallback = CertificateErrorsCallback;
                    if (cmbUseCertificate.SelectedIndex == 0)
                    {
                        var certificate = String.IsNullOrEmpty(txtCertificatePassword.Text) ? new X509Certificate2(txtCertificateFile.Text) : new X509Certificate2(txtCertificateFile.Text, txtCertificatePassword.Text);
                        ((SocketClientSsl)_socketClient).ClientCertificates.Add(certificate);
                    }
                }
                _socketClient.ConnectAsync(address, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableButtonControls(true);
            }
        }

        private void ButtonDisconnectClick(object sender, EventArgs e)
        {
            if (_socketClient != null)
            {
                _socketClient.Disconnect();
                _socketClient.Dispose();
                EnableDisableButtonControls(true);
            }
        }

        private void ButtonSendClick(object sender, EventArgs e)
        {
            try
            {
                Byte[] data = radioSendDataHex.Checked ? txtSendData.Text.ToByteArray() : Encoding.GetEncoding(txtSendDataEncoding.Text).GetBytes(txtSendData.Text);
                _socketClient.SendData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SocketClientConnected(object sender, SocketEventArgs e)
        {
            var message = String.Format("The client has connected to {0}:{1}", e.RemotePoint.Address, e.RemotePoint.Port);
            WriteToTextBox(txtStatusLog, message);
            EnableDisableButtonControls(false);

            _sentBytes = 0;
            _sentTotalBytes = 0;
            _receivedBytes = 0;
            _receivedTotalBytes = 0;
            RefreshStatusStrip();
        }

        private void SocketClientDisconnected(object sender, SocketEventArgs e)
        {
            var message = "The client has disconnected from the server";
            WriteToTextBox(txtStatusLog, message);
            EnableDisableButtonControls(true);
        }

        private void SocketClientSentData(object sender, SocketSendEventArgs e)
        {
            _sentBytes = e.SendedData.Length;
            _sentTotalBytes += _sentBytes;
            RefreshStatusStrip();

            var message = String.Format("Sent {0} bytes", _sentBytes);
            WriteToTextBox(txtStatusLog, message);           
        }

        private void SocketClientReceivedData(object sender, SocketReceiveEventArgs e)
        {
            try
            {
                _receivedBytes = e.ReceivedData.Length;
                _receivedTotalBytes += _receivedBytes;
                RefreshStatusStrip();

                var dataMessage = radioReceivedDataHex.Checked ? e.ReceivedData.ToByteString() : Encoding.GetEncoding(txtReceivedDataEncoding.Text).GetString(e.ReceivedData);
                var logMessage = String.Format("Received {0} bytes", _receivedBytes);
                WriteToTextBox(txtReceivedData, dataMessage);
                WriteToTextBox(txtStatusLog, logMessage);                              
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
            cmbUseCertificate.Items.Clear();
            cmbUseCertificate.DisplayMember = "Key";
            cmbUseCertificate.ValueMember = "Value";
            cmbUseCertificate.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbUseCertificate.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbUseCertificate.SelectedIndexChanged += (s, e) => { EnableDisableCertificateControls(cmbUseCertificate.SelectedIndex == 0); };
            cmbUseCertificate.SelectedIndex = 1;
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
            btnConnect.Enabled = enable;
            btnSend.Enabled = !enable;
            btnDisconnect.Enabled = !enable;
        }

        private void EnableDisableSslControls(Boolean enable)
        {
            lblTargetHostName.Enabled = enable;
            txtTargetHostName.Enabled = enable;
            lblSSLProtocol.Enabled = enable;
            cmbSSLProtocol.Enabled = enable;
            lblCertificateRevocation.Enabled = enable;
            cmbCertificateRevocation.Enabled = enable;
            lblUseCertificate.Enabled = enable;
            cmbUseCertificate.Enabled = enable;
            if (!enable)
            {
                EnableDisableCertificateControls(enable);
            }
            else
            {
                EnableDisableCertificateControls(cmbUseCertificate.SelectedIndex == 0);
            }
        }

        private void EnableDisableCertificateControls(Boolean enable)
        {
            btnBrowseCertificateFile.Enabled = enable;
            lblCertificateFile.Enabled = enable;
            txtCertificateFile.Enabled = enable;
            lblCertificatePassword.Enabled = enable;
            txtCertificatePassword.Enabled = enable;
        }

        private void RefreshStatusStrip()
        {
            lblSentBytes.Text = "Sent Bytes: " + _sentBytes;
            lblReceivedBytes.Text = "Received Bytes: " + _receivedBytes;
            lblSentTotalBytes.Text = "Sent Total Bytes: " + _sentTotalBytes;
            lblReceivedTotalBytes.Text = "Received Total Bytes: " + _receivedTotalBytes;
        }
    }
}