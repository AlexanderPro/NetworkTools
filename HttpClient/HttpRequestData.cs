using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace HttpClient
{
    class HttpRequestData
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
}
