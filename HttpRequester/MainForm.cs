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
            }
        }

        private HttpRequestData _requestData;
        private Stopwatch _requestTimespanMeter;
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

            cmbUseProxy.Items.Clear();
            cmbUseProxy.DisplayMember = "Key";
            cmbUseProxy.ValueMember = "Value";
            cmbUseProxy.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbUseProxy.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbUseProxy.SelectedIndex = 1;

            cmbUseClientCertificate.Items.Clear();
            cmbUseClientCertificate.DisplayMember = "Key";
            cmbUseClientCertificate.ValueMember = "Value";
            cmbUseClientCertificate.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbUseClientCertificate.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbUseClientCertificate.SelectedIndex = 1;
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
            Uri urlAddress;
            Encoding encoding;
            Int32 timeout;

            if (String.IsNullOrWhiteSpace(txtUrl.Text) || !Uri.TryCreate(txtUrl.Text, UriKind.RelativeOrAbsolute, out urlAddress))
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

            _requestData.Url = txtUrl.Text;
            _requestData.Method = txtMethod.Text;
            _requestData.RequestContent = txtRequest.Text;
            _requestData.Encoding = encoding;
            _requestData.Timeout = timeout;
            _requestData.UseProxy = cmbUseProxy.SelectedIndex == 0;
            _requestData.UseClientCertificate = cmbUseClientCertificate.SelectedIndex == 0;
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

            txtResponse.Text = "";
            var sendHttpRequestMethod = new SendHttpRequestDelegate(SendHttpRequest);
            _requestTimespanMeter.Restart();
            sendHttpRequestMethod.BeginInvoke(SendHttpRequestCallback, sendHttpRequestMethod);
            btnSend.Enabled = false;
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

        private void ButtonClientCertificateClick(object sender, EventArgs e)
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
            var buttonId = (String)comboBox.Tag;
            var controls = Controls.Find(buttonId, true);
            var button = (Button)controls[0];
            button.Enabled = comboBox.SelectedIndex == 0;
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
                _requestData.ResponseContent = responseReader.ReadToEnd();
            }
        }

        private void SendHttpRequestCallback(IAsyncResult ar)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    btnSend.Enabled = true;
                    _requestTimespanMeter.Stop();
                    var timeSpan = _requestTimespanMeter.Elapsed;
                    var sendHttpRequestMethod = (SendHttpRequestDelegate)ar.AsyncState;
                    sendHttpRequestMethod.EndInvoke(ar);
                    lblInterval.Text = String.Format("Interval: {0:D2}:{1:D2}:{2:D2}.{3:D3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
                    WriteToTextBox(txtResponse, _requestData.ResponseContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }
    }
}