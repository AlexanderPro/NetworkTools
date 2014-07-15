using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace HttpRequester
{
    public partial class WebProxyForm : Form
    {
        public String Address
        {
            get
            {
                return txtAddress.Text;
            }
        }

        public String Login 
        {
            get
            {
                return txtLogin.Text;
            }
        }

        public String Password 
        {
            get
            {
                return txtPassword.Text;
            }
        }

        public String Domain 
        {
            get
            {
                return txtDomain.Text;
            }
        }

        public Boolean UseDefaults 
        {
            get
            {
                return chbUseDefaults.Checked;
            }
        }

        public WebProxyForm(String address, String login, String password, String domain, Boolean useDefaults)
        {
            InitializeComponent();
            txtAddress.Text = address;
            txtLogin.Text = login;
            txtPassword.Text = password;
            txtDomain.Text = domain;
            chbUseDefaults.Checked = useDefaults;
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (!chbUseDefaults.Checked)
            {
                Uri address;
                if (!Uri.TryCreate(txtAddress.Text, UriKind.Absolute, out address))
                {
                    MessageBox.Show("Field \"Address\" has a wrong format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

        private void CheckBoxDefaultsChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                EnableTextBoxes(false);
            }
            else
            {
                EnableTextBoxes(true);
                txtAddress.Select();
                txtAddress.Focus();
            }
        }

        private void EnableTextBoxes(Boolean enable)
        {
            txtAddress.Enabled = enable;
            txtLogin.Enabled = enable;
            txtPassword.Enabled = enable;
            txtDomain.Enabled = enable;
        }
    }
}