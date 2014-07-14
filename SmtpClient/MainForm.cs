using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities.Net.Email.SMTP;

namespace SmtpClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSendMailClick(object sender, EventArgs e)
        {
            var serverName = txtServerName.Text;
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var useSSL = chbUseSsl.Checked;
            var to = txtTo.Text;
            var cc = txtCc.Text;
            var bcc = txtBcc.Text;
            var from = txtFrom.Text;
            var senderName = txtSenderName.Text;
            var subject = txtSubject.Text;
            var body = txtBody.Text;
            var isBodyHtml = chbHtml.Checked;

            Int32 serverPort;
            if (!Int32.TryParse(txtServerPort.Text, out serverPort))
            {
                MessageBox.Show("Field \"Server Port\" must have an integer number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Encoding subjectEncoding;
            try
            {
                subjectEncoding = Encoding.GetEncoding(txtSubjectEncoding.Text);
            }
            catch
            {
                MessageBox.Show("Field \"Subject Encoding\" has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Encoding bodyEncoding;
            try
            {
                bodyEncoding = Encoding.GetEncoding(txtBodyEncoding.Text);
            }
            catch
            {
                MessageBox.Show("Field \"Body Encoding\" has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emailSender = new EmailSender()
            {
                Server = serverName,
                Port = serverPort,
                UserName = userName,
                Password = password,
                UseSSL = useSSL,
                StringTo = to,
                StringCC = cc,
                StringBcc = bcc,
                From = from,
                SenderName = senderName,
                Subject = subject,
                Body = body,
                SubjectEncoding = subjectEncoding,
                BodyEncoding = bodyEncoding,
                IsBodyHtml = isBodyHtml
            };

            try
            {
                emailSender.SendMail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
