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

        private void SendMailClick(object sender, EventArgs e)
        {
            try
            {
                var emailSender = new EmailSender()
                {
                    Server = txtServerName.Text,
                    Port = Int32.Parse(txtServerPort.Text),
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    UseSSL = chbUseSsl.Checked,
                    StringTo = txtTo.Text,
                    StringCC = txtCc.Text,
                    StringBcc = txtBcc.Text,
                    From = txtFrom.Text,
                    SenderName = txtSenderName.Text,
                    Subject = txtSubject.Text,
                    Body = txtBody.Text,
                    SubjectEncoding = String.IsNullOrEmpty(txtSubjectEncoding.Text) ? Encoding.GetEncoding("utf-8") : Encoding.GetEncoding(txtSubjectEncoding.Text),
                    BodyEncoding = String.IsNullOrEmpty(txtBodyEncoding.Text) ? Encoding.GetEncoding("utf-8") : Encoding.GetEncoding(txtBodyEncoding.Text),
                    IsBodyHtml = chbHtml.Checked
                };
                emailSender.SendMail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
