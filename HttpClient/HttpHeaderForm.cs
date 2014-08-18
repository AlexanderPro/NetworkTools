using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HttpClient
{
    public partial class HttpHeaderForm : Form
    {
        public String HeaderName 
        {
            get
            {
                return txtHeaderName.Text;
            }
        }

        public String HeaderValue 
        {
            get
            {
                return txtHeaderValue.Text;
            }
        }

        public HttpHeaderForm()
        {
            InitializeComponent();
        }

        public HttpHeaderForm(String headerName, String headerValue)
        {
            InitializeComponent();
            txtHeaderName.Text = headerName;
            txtHeaderValue.Text = headerValue;
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtHeaderName.SelectAll();
            txtHeaderName.Focus();
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtHeaderName.Text))
            {
                MessageBox.Show("Header name must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
