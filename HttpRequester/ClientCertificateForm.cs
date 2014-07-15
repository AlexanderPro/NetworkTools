using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace HttpRequester
{
    public partial class ClientCertificateForm : Form
    {
        public X509Certificate2 Certificate { get; private set; }

        public String FileName 
        {
            get
            {
                return txtFileName.Text;
            }
        }

        public String Password 
        {
            get
            {
                return txtPassword.Text;
            }
        }

        public ClientCertificateForm(String fileName, String password)
        {
            InitializeComponent();
            txtFileName.Text = fileName;
            txtPassword.Text = password;
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtFileName.SelectAll();
            txtFileName.Focus();
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (!File.Exists(txtFileName.Text))
            {
                var message = String.Format("File \"{0}\" does not exist.", txtFileName.Text);
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Certificate = String.IsNullOrEmpty(txtPassword.Text) ? new X509Certificate2(txtFileName.Text) : new X509Certificate2(txtFileName.Text, txtPassword.Text);
            }
            catch
            {
                MessageBox.Show("Failed to read certificate file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonBrowseFileClick(object sender, EventArgs e)
        {
            var directoryName = "";
            try
            {
                directoryName = Path.GetDirectoryName(txtFileName.Text);
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
                txtFileName.Text = dialog.FileName;
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    {
                        ButtonOkClick(sender, e);
                    } break;

                case 27:
                    {
                        ButtonCancelClick(sender, e);
                    } break;
            }
        }
    }
}
