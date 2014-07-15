using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace HttpRequester
{
    public partial class MainForm : Form
    {
        private class HttpRequestData
        {
            public String Url { get; set; }
            public String Method { get; set; }
            public Encoding Encoding { get; set; }
            public Int32 Timeout { get; set; }
            public IDictionary<String, String> Headers { get; set; }
            public String RequestContent { get; set; }
            public String ResponseContent { get; set; }
            public Boolean UseProxy { get; set; }
            public String ProxyAddress { get; set; }
            public String ProxyLogin { get; set; }
            public String ProxyPassword { get; set; }
            public String ProxyDomain { get; set; }
            public Boolean UseProxyDefaults { get; set; }
            public Boolean UseClientCertificate { get; set; }
            public String CertificateFileName { get; set; }
            public String CertificatePassword { get; set; }
            public X509Certificate2 Certificate { get; set; }
            public Boolean SendRequestInLoop { get; set; }
            public Int32 SendRequestInterval { get; set; }

            public HttpRequestData()
            {
                Url = String.Empty;
                Method = String.Empty;
                Encoding = Encoding.UTF8;
                Timeout = -1;
                Headers = new Dictionary<String, String>();
                RequestContent = String.Empty;
                ResponseContent = String.Empty;
                UseProxy = false;
                ProxyAddress = String.Empty;
                ProxyLogin = String.Empty;
                ProxyPassword = String.Empty;
                ProxyDomain = String.Empty;
                UseProxyDefaults = false;
                UseClientCertificate = false;
                CertificateFileName = String.Empty;
                CertificatePassword = String.Empty;
                Certificate = null;
                SendRequestInLoop = false;
                SendRequestInterval = -1;
            }
        }

        private System.Timers.Timer _requestTimer;
        private HttpRequestData _requestData;
        private Stopwatch _requestTimespanMeter;
        private Boolean _isRequestLoopRunning;
        private delegate void SendHttpRequestDelegate();

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            _requestTimespanMeter = new Stopwatch();
            _requestData = new HttpRequestData();
            _isRequestLoopRunning = false;
            _requestTimer = new System.Timers.Timer();
            _requestTimer.SynchronizingObject = this;
            cmbUseProxy.SelectedIndex = 1;
            cmbUseClientCertificate.SelectedIndex = 1;
            cmbRequestInLoop.SelectedIndex = 1;
        }

        private void ButtonAddHeaderClick(object sender, EventArgs e)
        {
            var form = new HttpHeaderForm();
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;
            var index = gridHeaders.Rows.Add();
            var row = gridHeaders.Rows[index];
            row.Cells[1].Value = form.HeaderName;
            row.Cells[2].Value = form.HeaderValue;
        }

        private void ButtonSendClick(object sender, EventArgs e)
        {
            Uri address;
            Encoding encoding;
            Int32 timeout, interval = -1;

            if (!Uri.TryCreate(txtUrl.Text, UriKind.Absolute, out address))
            {
                MessageBox.Show("Field \"URL\" has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMethod.Text))
            {
                MessageBox.Show("Field \"Method\" must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                encoding = Encoding.GetEncoding(txtEncoding.Text);
            }
            catch
            {
                MessageBox.Show("Field \"Encoding\" has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int32.TryParse(txtTimeout.Text, out timeout))
            {
                MessageBox.Show("Field \"Timeout\" must have an integer number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRequestInLoop.SelectedIndex == 0 && !Int32.TryParse(txtRequestInterval.Text, out interval))
            {
                MessageBox.Show("Field \"Loop interval\" must have an integer number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUseClientCertificate.SelectedIndex == 0 && _requestData.Certificate == null)
            {
                MessageBox.Show("Client certificate does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUseProxy.SelectedIndex == 0 && !_requestData.UseProxyDefaults && !Uri.TryCreate(_requestData.ProxyAddress, UriKind.Absolute, out address))
            {
                MessageBox.Show("Proxy address has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _requestData.Url = txtUrl.Text;
            _requestData.Method = txtMethod.Text;
            _requestData.RequestContent = txtRequest.Text;
            _requestData.Encoding = encoding;
            _requestData.Timeout = timeout;
            _requestData.SendRequestInterval = interval;
            _requestData.UseProxy = cmbUseProxy.SelectedIndex == 0;
            _requestData.UseClientCertificate = cmbUseClientCertificate.SelectedIndex == 0;
            _requestData.SendRequestInLoop = cmbRequestInLoop.SelectedIndex == 0;
            _requestData.ResponseContent = String.Empty;
            _requestData.Headers.Clear();

            foreach (DataGridViewRow row in gridHeaders.Rows)
            {
                var headerName = (String)row.Cells[1].Value ?? "";
                var headerValue = (String)row.Cells[2].Value ?? "";
                _requestData.Headers.Add(headerName, headerValue);
                if (String.IsNullOrWhiteSpace(headerName))
                {
                    MessageBox.Show("Header name must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var action = new Action(() =>
            {
                _requestTimer.Stop();
                txtResponse.Text = "";
                var sendHttpRequestMethod = new SendHttpRequestDelegate(SendHttpRequest);
                _requestTimespanMeter.Restart();
                sendHttpRequestMethod.BeginInvoke(SendHttpRequestCallback, sendHttpRequestMethod);
                btnSend.Enabled = false;
            });

            if (_requestData.SendRequestInLoop)
            {
                _requestTimer = new System.Timers.Timer();
                _requestTimer.SynchronizingObject = this;
                _requestTimer.Interval = _requestData.SendRequestInterval * 1000;
                _requestTimer.Elapsed += (s, ev) => { action(); };
            }

            _isRequestLoopRunning = _requestData.SendRequestInLoop;
            btnStop.Enabled = _requestData.SendRequestInLoop;
            action();
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            _isRequestLoopRunning = false;
            _requestTimer.Stop();
            btnSend.Enabled = true;
            btnStop.Enabled = false;
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var textBoxId = (String)button.Tag;
            var controls = Controls.Find(textBoxId, true);
            var textBox = (TextBox)controls[0];
            textBox.Clear();
        }

        private void ButtonProxyClick(object sender, EventArgs e)
        {
            var form = new WebProxyForm(_requestData.ProxyAddress, _requestData.ProxyLogin, _requestData.ProxyPassword, _requestData.ProxyDomain, _requestData.UseProxyDefaults);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _requestData.ProxyAddress = form.Address;
                _requestData.ProxyLogin = form.Login;
                _requestData.ProxyPassword = form.Password;
                _requestData.ProxyDomain = form.Domain;
                _requestData.UseProxyDefaults = form.UseDefaults;
            }
        }

        private void ButtonCertificateClick(object sender, EventArgs e)
        {
            var form = new ClientCertificateForm(_requestData.CertificateFileName, _requestData.CertificatePassword);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _requestData.CertificateFileName = form.FileName;
                _requestData.CertificatePassword = form.Password;
                _requestData.Certificate = form.Certificate;
            }
        }

        private void GridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
            }
        }

        private void GridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.SelectedRows.Count > 0)
            {
                var row = grid.SelectedRows[0];
                var form = new HttpHeaderForm((String)row.Cells[1].Value, (String)row.Cells[2].Value);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    row.Cells[1].Value = form.HeaderName;
                    row.Cells[2].Value = form.HeaderValue;
                }
            }
            else
            {
                MessageBox.Show("You should select an item in the http headers list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var controlId = (String)comboBox.Tag;
            var controls = Controls.Find(controlId, true);
            var control = (Control)controls[0];
            control.Enabled = comboBox.SelectedIndex == 0;
        }

        private void WriteToTextBox(TextBox textBox, String text)
        {
            textBox.Text += text;
            textBox.Select(textBox.Text.Length - 2, 1);
            textBox.ScrollToCaret();
        }

        private void SendHttpRequest()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(_requestData.Url);
            webRequest.Method = _requestData.Method;
            webRequest.Timeout = _requestData.Timeout;
            var data = _requestData.Encoding.GetBytes(_requestData.RequestContent);
            webRequest.ContentLength = data.Length;

            foreach (var pair in _requestData.Headers)
            {
                var headerName = pair.Key;
                var headerValue = pair.Value;
                switch (headerName.ToUpper())
                {
                    case "ACCEPT":
                        {
                            webRequest.Accept = headerValue;
                        } break;

                    case "CONTENT-TYPE":
                        {
                            webRequest.ContentType = headerValue;
                        } break;

                    default:
                        {
                            webRequest.Headers[headerName] = headerValue;
                        } break;
                }
            }

            if (_requestData.UseProxy)
            {
                if (_requestData.UseProxyDefaults)
                {
                    webRequest.Proxy = WebRequest.GetSystemWebProxy();
                    webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
                }
                else
                {
                    webRequest.Proxy = new WebProxy(_requestData.ProxyAddress);
                    webRequest.Proxy.Credentials = new NetworkCredential(_requestData.ProxyLogin, _requestData.ProxyPassword, _requestData.ProxyDomain);
                }
            }

            if (_requestData.UseClientCertificate)
            {
                webRequest.ClientCertificates.Add(_requestData.Certificate);
            }

            if (!String.IsNullOrEmpty(_requestData.RequestContent))
            {
                using (var requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                }
            }

            using (var webResponse = webRequest.GetResponse())
            using (var responseStream = webResponse.GetResponseStream())
            using (var responseReader = new StreamReader(responseStream, _requestData.Encoding))
            {
                _requestData.ResponseContent = String.Concat(webResponse.Headers.AllKeys.Select(x => x + ": " + webResponse.Headers[x] + Environment.NewLine));
                _requestData.ResponseContent += Environment.NewLine + responseReader.ReadToEnd();
            }
        }

        private void SendHttpRequestCallback(IAsyncResult ar)
        {
            var action = new Action(() =>
            {
                try
                {
                    _requestTimespanMeter.Stop();
                    var timeSpan = _requestTimespanMeter.Elapsed;
                    var sendHttpRequestMethod = (SendHttpRequestDelegate)ar.AsyncState;
                    sendHttpRequestMethod.EndInvoke(ar);
                    lblInterval.Text = String.Format("Interval: {0:D2}:{1:D2}:{2:D2}.{3:D3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
                    var message = String.Format("{0:HH:mm:ss.fff}  -  Received {1} chars. {2}{3}", DateTime.Now, _requestData.ResponseContent.Length, lblInterval.Text, Environment.NewLine);
                    WriteToTextBox(txtResponse, _requestData.ResponseContent);
                    WriteToTextBox(txtStatus, message);
                }
                catch (Exception ex)
                {
                    var message = String.Format("{0:HH:mm:ss.fff}  -  {1}{2}", DateTime.Now, ex.Message, Environment.NewLine);
                    WriteToTextBox(txtStatus, message);
                }

                if (_requestData.SendRequestInLoop && _isRequestLoopRunning)
                {
                    _requestTimer.Start();
                }
                else
                {
                    btnSend.Enabled = true;
                    btnStop.Enabled = false;
                }
            });

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}