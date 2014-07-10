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
        private delegate void SendHttpRequestDelegate(String url, 
                                                      String method, 
                                                      Encoding encoding, 
                                                      Int32 timeout, 
                                                      IDictionary<String, String> headers, 
                                                      Boolean sendRequestContent,
                                                      String requestContent, 
                                                      out String responseContent);

        public MainForm()
        {
            InitializeComponent();
            _requestTimespanMeter = new Stopwatch();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            clmnHeaderName.Width = (gridHeaders.ClientSize.Width - clmnButton.Width) / 2;
            clmnHeaderValue.Width = (gridHeaders.ClientSize.Width - clmnButton.Width) / 2;
        }

        private void ButtonAddHeaderClick(object sender, EventArgs e)
        {
            gridHeaders.Rows.Add();
        }

        private void GridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
            }
        }

        private void ButtonSendClick(object sender, EventArgs e)
        {
            try
            {
                var url = txtUrl.Text;
                var method = txtMethod.Text;
                var encoding = Encoding.GetEncoding(txtEncoding.Text);
                var timeout = Int32.Parse(txtTimeout.Text);
                var requestContent = txtRequest.Text;
                var sendRequestContent = chkSendRequestContent.Checked;
                var headers = new Dictionary<String, String>();
                foreach (DataGridViewRow row in gridHeaders.Rows)
                {
                    var headerName = (String)row.Cells[1].Value ?? "";
                    var headerValue = (String)row.Cells[2].Value ?? "";
                    headers.Add(headerName, headerValue);
                }
                txtResponse.Text = "";
                String responseContent;
                var sendHttpRequestMethod = new SendHttpRequestDelegate(SendHttpRequest);
                _requestTimespanMeter.Restart();
                sendHttpRequestMethod.BeginInvoke(url, method, encoding, timeout, headers, sendRequestContent, requestContent, out responseContent, SendHttpRequestCallback, sendHttpRequestMethod);
                btnSend.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendHttpRequest(String url, String method, Encoding encoding, Int32 timeout, IDictionary<String, String> headers, Boolean sendRequestContent, String requestContent, out String responseContent)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }
    }
}