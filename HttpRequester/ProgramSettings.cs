using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace HttpRequester
{
    static class ProgramSettings
    {
        public static void Save(String fileName, HttpRequestData data)
        {
            var document = new XDocument(new XDeclaration("1.0", "utf-8", null),
                    new XElement("Settings",
                        new XElement("Url", data.Url),
                        new XElement("Method", data.Method),
                        new XElement("Encoding", data.Encoding.WebName),
                        new XElement("Timeout", data.Timeout),
                        new XElement("Headers", data.Headers.Select(x => new XElement("add", new XAttribute("name", x.Key), new XAttribute("value", x.Value)))),
                        new XElement("Proxy",
                            new XAttribute("enabled", data.UseProxy),
                            new XAttribute("address", data.ProxyAddress),
                            new XAttribute("login", data.ProxyLogin),
                            new XAttribute("password", data.ProxyPassword),
                            new XAttribute("domain", data.ProxyDomain),
                            new XAttribute("useDefaults", data.UseProxyDefaults)),
                        new XElement("Certificate", 
                            new XAttribute("enabled", data.UseClientCertificate),
                            new XAttribute("fileName", data.CertificateFileName),
                            new XAttribute("password", data.CertificatePassword)),
                        new XElement("Loop",
                            new XAttribute("enabled", data.SendRequestInLoop),
                            new XAttribute("interval", data.SendRequestInterval)),
                        new XElement("Request", data.RequestContent)));
            
            Save(document, fileName);
        }

        public static HttpRequestData Load(String fileName)
        {
            var result = new HttpRequestData();
            var document = XDocument.Load(fileName);
            var rootElement = document.Root;
            result.Url = rootElement.Element("Url").Value;
            result.Method = rootElement.Element("Method").Value;
            result.Encoding = Encoding.GetEncoding(rootElement.Element("Encoding").Value);
            result.Timeout = Int32.Parse(rootElement.Element("Timeout").Value);
            result.Headers = rootElement.Element("Headers").Elements("add").Select(x => new { Key = x.Attribute("name").Value, Value = x.Attribute("value").Value }).ToDictionary(x => x.Key, y => y.Value);
            result.UseProxy = Boolean.Parse(rootElement.Element("Proxy").Attribute("enabled").Value);
            result.ProxyAddress = rootElement.Element("Proxy").Attribute("address").Value;
            result.ProxyLogin = rootElement.Element("Proxy").Attribute("login").Value;
            result.ProxyPassword = rootElement.Element("Proxy").Attribute("password").Value;
            result.ProxyDomain = rootElement.Element("Proxy").Attribute("domain").Value;
            result.UseProxyDefaults = Boolean.Parse(rootElement.Element("Proxy").Attribute("useDefaults").Value);
            result.UseClientCertificate = Boolean.Parse(rootElement.Element("Certificate").Attribute("enabled").Value);
            result.CertificateFileName = rootElement.Element("Certificate").Attribute("fileName").Value;
            result.CertificatePassword = rootElement.Element("Certificate").Attribute("password").Value;
            result.SendRequestInLoop = Boolean.Parse(rootElement.Element("Loop").Attribute("enabled").Value);
            result.SendRequestInterval = Int32.Parse(rootElement.Element("Loop").Attribute("interval").Value);
            result.RequestContent = rootElement.Element("Request").Value;
            return result;
        }

        private static void Save(XDocument document, String fileName)
        {
            using (TextWriter writer = new Utf8StringWriter())
            {
                document.Save(writer, SaveOptions.None);
                File.WriteAllText(fileName, writer.ToString());
            }
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }
    }
}
