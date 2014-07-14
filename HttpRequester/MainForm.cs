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

namespace HttpRequester
{
    public partial class MainForm : Form
    {
        private Stopwatch _requestTimespanMeter;
        private String _proxyAddress;
        private String _proxyLogin;
        private String _proxyPassword;
        private String _proxyDomain;
        private Boolean _useProxyDefaults;
        private delegate void SendHttpRequestDelegate(String url, String method, Encoding encoding, Int32 timeout, IDictionary<String, String> headers, Boolean sendRequestContent, String requestContent, Boolean useProxy, out String responseContent);

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            _requestTimespanMeter = new Stopwatch();
            _proxyAddress = String.Empty;
            _proxyLogin = String.Empty;
            _proxyPassword = String.Empty;
            _proxyDomain = String.Empty;
            _useProxyDefaults = false;

            cmbUseProxy.Items.Clear();
            cmbUseProxy.DisplayMember = "Key";
            cmbUseProxy.ValueMember = "Value";
            cmbUseProxy.Items.Add(new KeyValuePair<String, Boolean>("Yes", true));
            cmbUseProxy.Items.Add(new KeyValuePair<String, Boolean>("No", false));
            cmbUseProxy.SelectedIndex = 1;
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
            String url, method;
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

            url = txtUrl.Text;
            method = txtMethod.Text;
            var requestContent = txtRequest.Text;
            var sendRequestContent = !String.IsNullOrEmpty(requestContent);
            var useProxy = cmbUseProxy.SelectedIndex == 0;
            var headers = new Dictionary<String, String>();
            foreach (DataGridViewRow row in gridHeaders.Rows)
            {
                var headerName = (String)row.Cells[1].Value ?? "";
                var headerValue = (String)row.Cells[2].Value ?? "";
                headers.Add(headerName, headerValue);
                if (String.IsNullOrWhiteSpace(headerName))
                {
                    MessageBox.Show("Header name must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            txtResponse.Text = "";
            String responseContent;
            var sendHttpRequestMethod = new SendHttpRequestDelegate(SendHttpRequest);
            _requestTimespanMeter.Restart();
            sendHttpRequestMethod.BeginInvoke(url, method, encoding, timeout, headers, sendRequestContent, requestContent, useProxy, out responseContent, SendHttpRequestCallback, sendHttpRequestMethod);
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
            var form = new WebProxyForm(_proxyAddress, _proxyLogin, _proxyPassword, _proxyDomain, _useProxyDefaults);
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;
            _proxyAddress = form.Address;
            _proxyLogin = form.Login;
            _proxyPassword = form.Password;
            _proxyDomain = form.Domain;
            _useProxyDefaults = form.UseDefaults;
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
                if (result != DialogResult.OK) return;
                row.Cells[1].Value = form.HeaderName;
                row.Cells[2].Value = form.HeaderValue;
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

        private void SendHttpRequest(String url, String method, Encoding encoding, Int32 timeout, IDictionary<String, String> headers, Boolean sendRequestContent, String requestContent, Boolean useProxy, out String responseContent)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = method;
            webRequest.Timeout = timeout;
            var data = encoding.GetBytes(requestContent);
            webRequest.ContentLength = data.Length;

            foreach (var pair in headers)
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

            if (useProxy)
            {
                if (_useProxyDefaults)
                {
                    webRequest.Proxy = WebRequest.GetSystemWebProxy();
                    webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
                }
                else
                {
                    webRequest.Proxy = new WebProxy(_proxyAddress);
                    webRequest.Proxy.Credentials = new NetworkCredential(_proxyLogin, _proxyPassword, _proxyDomain);
                }
            }

            if (sendRequestContent)
            {
                using (var requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                }
            }

            using (var webResponse = webRequest.GetResponse())
            using (var responseStream = webResponse.GetResponseStream())
            using (var responseReader = new StreamReader(responseStream, encoding))
            {
                responseContent = responseReader.ReadToEnd();
            }
        }

        private void SendHttpRequestCallback(IAsyncResult ar)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    String responseContent;
                    btnSend.Enabled = true;
                    _requestTimespanMeter.Stop();
                    var timeSpan = _requestTimespanMeter.Elapsed;
                    var sendHttpRequestMethod = (SendHttpRequestDelegate)ar.AsyncState;
                    sendHttpRequestMethod.EndInvoke(out responseContent, ar);
                    lblInterval.Text = String.Format("Interval: {0:D2}:{1:D2}:{2:D2}.{3:D3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
                    txtResponse.Text = responseContent;
                    txtResponse.Select(txtResponse.Text.Length - 2, 1);
                    txtResponse.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }
    }
} 