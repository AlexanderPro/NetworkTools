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

namespace UdpClientServer
{
    public partial class MainForm : Form
    {
        private Int64 _sentBytes;
        private Int64 _receivedBytes;
        private Int64 _receivedTotalBytes;
        private SocketDatagramClient _socketClient;
        private SocketDatagramServer _socketServer;

        public MainForm()
        {
            InitializeComponent();
            _sentBytes = 0;
            _receivedBytes = 0;
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
                _socketServer.Stop();
                _socketServer.Dispose();
            }
            catch
            {
            }
        }       

        private void ButtonSendClick(object sender, EventArgs e)
        {
            try
            {
                _socketClient = new SocketDatagramClient();
                _socketClient.Context = WindowsFormsSynchronizationContext.Current;
                _socketClient.Connected += SocketClientConnected;
                _socketClient.SentData += SocketClientSentData;
                _socketClient.SocketError += SocketClientSocketError;
                _socketClient.Error += SocketClientError;

                Int32 remotePort;
                if (!Int32.TryParse(txtRemotePort.Text, out remotePort)) throw new Exception("Remote port number is wrong.");
                var remoteAddress = txtRemoteAddress.Text;
                _socketClient.ConnectAsync(remoteAddress, remotePort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            try
            {
                Int32 localPort;
                if (!Int32.TryParse(txtRemotePort.Text, out localPort)) throw new Exception("Local port number is wrong.");

                _socketServer = new SocketDatagramServer(localPort);
                _socketServer.Context = WindowsFormsSynchronizationContext.Current;
                _socketServer.ReceivedData += SocketServerReceivedData;
                _socketServer.SocketError += SocketServerSocketError;
                _socketServer.Error += SocketServerError;
                _socketServer.Start();

                _sentBytes = 0;
                _receivedBytes = 0;
                _receivedTotalBytes = 0;
                RefreshStatusStrip();
                EnableDisableButtonControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ButtonClearTextBoxClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var controls = Controls.Find((String)button.Tag, true);
            var textBox = (TextBox)controls[0];
            textBox.Clear();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            txtSendDataEncoding.ReadOnly = !radioSendDataText.Checked;
            txtReceivedDataEncoding.ReadOnly = !radioReceivedDataText.Checked;
        }

        private void SocketClientConnected(object sender, SocketEventArgs e)
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

        private void SocketClientSentData(object sender, SocketSendEventArgs e)
        {
            _sentBytes = e.SendedData.Length;
            RefreshStatusStrip();

            var message = String.Format("The client sent {0} bytes", _sentBytes);
            WriteToTextBox(txtStatusLog, message);           
        }

        private void SocketClientSocketError(object sender, SocketErrorEventArgs e)
        {
            var message = String.Format("Socket client error, Message: {0}", e.SocketException.Message);
            WriteToTextBox(txtStatusLog, message);
        }

        private void SocketClientError(object sender, Utilities.Net.Sockets.ErrorEventArgs e)
        {
            var message = String.Format("Client Error, Message: {0}", e.Exception.Message);
            WriteToTextBox(txtStatusLog, message);
        }

        private void SocketServerReceivedData(object sender, SocketReceiveEventArgs e)
        {
            try
            {
                _receivedBytes = e.ReceivedData.Length;
                _receivedTotalBytes += _receivedBytes;
                RefreshStatusStrip();

                var dataMessage = radioReceivedDataHex.Checked ? e.ReceivedData.ToByteString() : Encoding.GetEncoding(txtReceivedDataEncoding.Text).GetString(e.ReceivedData);
                var logMessage = String.Format("The server received {0} bytes", _receivedBytes);
                WriteToTextBox(txtReceivedData, dataMessage);
                WriteToTextBox(txtStatusLog, logMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SocketServerSocketError(object sender, SocketErrorEventArgs e)
        {
            var message = String.Format("Socket server error, Message: {0}", e.SocketException.Message);
            WriteToTextBox(txtStatusLog, message);
        }

        private void SocketServerError(object sender, Utilities.Net.Sockets.ErrorEventArgs e)
        {
            var message = String.Format("Socket Error, Message: {0}", e.Exception.Message);
            WriteToTextBox(txtStatusLog, message);
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
        }

        private void RefreshStatusStrip()
        {
            lblSentBytes.Text = "Sent Bytes: " + _sentBytes;
            lblReceivedBytes.Text = "Received Bytes: " + _receivedBytes;
            lblReceivedTotalBytes.Text = "Received Total Bytes: " + _receivedTotalBytes;
        }
    }
}