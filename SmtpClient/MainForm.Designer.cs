namespace SmtpClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.gbSmtpServer = new System.Windows.Forms.GroupBox();
            this.lblUseSsl = new System.Windows.Forms.Label();
            this.chbUseSsl = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtBcc = new System.Windows.Forms.TextBox();
            this.lblBcc = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.lblCc = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chbHtml = new System.Windows.Forms.CheckBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBodyEncoding = new System.Windows.Forms.TextBox();
            this.lblBodyEncoding = new System.Windows.Forms.Label();
            this.txtSubjectEncoding = new System.Windows.Forms.TextBox();
            this.lblSubjectEncoding = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.gbSmtpServer.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(31, 33);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.Location = new System.Drawing.Point(114, 30);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(214, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // gbSmtpServer
            // 
            this.gbSmtpServer.Controls.Add(this.lblUseSsl);
            this.gbSmtpServer.Controls.Add(this.chbUseSsl);
            this.gbSmtpServer.Controls.Add(this.txtPassword);
            this.gbSmtpServer.Controls.Add(this.lblPassword);
            this.gbSmtpServer.Controls.Add(this.txtUserName);
            this.gbSmtpServer.Controls.Add(this.lblUserName);
            this.gbSmtpServer.Controls.Add(this.txtServerPort);
            this.gbSmtpServer.Controls.Add(this.lblServerPort);
            this.gbSmtpServer.Controls.Add(this.txtServerName);
            this.gbSmtpServer.Controls.Add(this.lblServerName);
            this.gbSmtpServer.Location = new System.Drawing.Point(12, 6);
            this.gbSmtpServer.Name = "gbSmtpServer";
            this.gbSmtpServer.Size = new System.Drawing.Size(351, 190);
            this.gbSmtpServer.TabIndex = 0;
            this.gbSmtpServer.TabStop = false;
            this.gbSmtpServer.Text = "SMTP Server";
            // 
            // lblUseSsl
            // 
            this.lblUseSsl.AutoSize = true;
            this.lblUseSsl.Location = new System.Drawing.Point(51, 150);
            this.lblUseSsl.Name = "lblUseSsl";
            this.lblUseSsl.Size = new System.Drawing.Size(52, 13);
            this.lblUseSsl.TabIndex = 8;
            this.lblUseSsl.Text = "Use SSL:";
            // 
            // chbUseSsl
            // 
            this.chbUseSsl.AutoSize = true;
            this.chbUseSsl.Location = new System.Drawing.Point(114, 150);
            this.chbUseSsl.Name = "chbUseSsl";
            this.chbUseSsl.Size = new System.Drawing.Size(15, 14);
            this.chbUseSsl.TabIndex = 9;
            this.chbUseSsl.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(114, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(47, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(114, 90);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(40, 93);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name:";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerPort.Location = new System.Drawing.Point(114, 60);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(214, 20);
            this.txtServerPort.TabIndex = 3;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(40, 63);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 13);
            this.lblServerPort.TabIndex = 2;
            this.lblServerPort.Text = "Server Port:";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.txtBcc);
            this.gbAddress.Controls.Add(this.lblBcc);
            this.gbAddress.Controls.Add(this.txtCc);
            this.gbAddress.Controls.Add(this.lblCc);
            this.gbAddress.Controls.Add(this.txtTo);
            this.gbAddress.Controls.Add(this.lblTo);
            this.gbAddress.Controls.Add(this.txtFrom);
            this.gbAddress.Controls.Add(this.lblFrom);
            this.gbAddress.Controls.Add(this.txtSenderName);
            this.gbAddress.Controls.Add(this.lblSenderName);
            this.gbAddress.Location = new System.Drawing.Point(375, 6);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(351, 190);
            this.gbAddress.TabIndex = 1;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // txtBcc
            // 
            this.txtBcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBcc.Location = new System.Drawing.Point(114, 150);
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.Size = new System.Drawing.Size(214, 20);
            this.txtBcc.TabIndex = 9;
            // 
            // lblBcc
            // 
            this.lblBcc.AutoSize = true;
            this.lblBcc.Location = new System.Drawing.Point(75, 153);
            this.lblBcc.Name = "lblBcc";
            this.lblBcc.Size = new System.Drawing.Size(31, 13);
            this.lblBcc.TabIndex = 8;
            this.lblBcc.Text = "BCC:";
            // 
            // txtCc
            // 
            this.txtCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCc.Location = new System.Drawing.Point(114, 120);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(214, 20);
            this.txtCc.TabIndex = 7;
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.Location = new System.Drawing.Point(80, 123);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(24, 13);
            this.lblCc.TabIndex = 6;
            this.lblCc.Text = "CC:";
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(114, 90);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(214, 20);
            this.txtTo.TabIndex = 5;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(83, 93);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(114, 60);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(214, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(71, 63);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenderName.Location = new System.Drawing.Point(114, 30);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(214, 20);
            this.txtSenderName.TabIndex = 1;
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Location = new System.Drawing.Point(31, 33);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(75, 13);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "Sender Name:";
            // 
            // gbMail
            // 
            this.gbMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMail.Controls.Add(this.btnSend);
            this.gbMail.Controls.Add(this.chbHtml);
            this.gbMail.Controls.Add(this.txtBody);
            this.gbMail.Controls.Add(this.lblBody);
            this.gbMail.Controls.Add(this.txtBodyEncoding);
            this.gbMail.Controls.Add(this.lblBodyEncoding);
            this.gbMail.Controls.Add(this.txtSubjectEncoding);
            this.gbMail.Controls.Add(this.lblSubjectEncoding);
            this.gbMail.Controls.Add(this.txtSubject);
            this.gbMail.Controls.Add(this.lblSubject);
            this.gbMail.Location = new System.Drawing.Point(12, 202);
            this.gbMail.Name = "gbMail";
            this.gbMail.Size = new System.Drawing.Size(714, 329);
            this.gbMail.TabIndex = 2;
            this.gbMail.TabStop = false;
            this.gbMail.Text = "Mail";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(580, 287);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 31);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSendMailClick);
            // 
            // chbHtml
            // 
            this.chbHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbHtml.AutoSize = true;
            this.chbHtml.Location = new System.Drawing.Point(642, 125);
            this.chbHtml.Name = "chbHtml";
            this.chbHtml.Size = new System.Drawing.Size(56, 17);
            this.chbHtml.TabIndex = 7;
            this.chbHtml.Text = "HTML";
            this.chbHtml.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(17, 142);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(674, 135);
            this.txtBody.TabIndex = 8;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(15, 126);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 13);
            this.lblBody.TabIndex = 6;
            this.lblBody.Text = "Body:";
            // 
            // txtBodyEncoding
            // 
            this.txtBodyEncoding.Location = new System.Drawing.Point(114, 90);
            this.txtBodyEncoding.Name = "txtBodyEncoding";
            this.txtBodyEncoding.Size = new System.Drawing.Size(214, 20);
            this.txtBodyEncoding.TabIndex = 5;
            this.txtBodyEncoding.Text = "UTF-8";
            // 
            // lblBodyEncoding
            // 
            this.lblBodyEncoding.AutoSize = true;
            this.lblBodyEncoding.Location = new System.Drawing.Point(24, 93);
            this.lblBodyEncoding.Name = "lblBodyEncoding";
            this.lblBodyEncoding.Size = new System.Drawing.Size(82, 13);
            this.lblBodyEncoding.TabIndex = 4;
            this.lblBodyEncoding.Text = "Body Encoding:";
            // 
            // txtSubjectEncoding
            // 
            this.txtSubjectEncoding.Location = new System.Drawing.Point(114, 60);
            this.txtSubjectEncoding.Name = "txtSubjectEncoding";
            this.txtSubjectEncoding.Size = new System.Drawing.Size(214, 20);
            this.txtSubjectEncoding.TabIndex = 3;
            this.txtSubjectEncoding.Text = "UTF-8";
            // 
            // lblSubjectEncoding
            // 
            this.lblSubjectEncoding.AutoSize = true;
            this.lblSubjectEncoding.Location = new System.Drawing.Point(12, 63);
            this.lblSubjectEncoding.Name = "lblSubjectEncoding";
            this.lblSubjectEncoding.Size = new System.Drawing.Size(94, 13);
            this.lblSubjectEncoding.TabIndex = 2;
            this.lblSubjectEncoding.Text = "Subject Encoding:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(114, 30);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(214, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(60, 33);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 544);
            this.Controls.Add(this.gbMail);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbSmtpServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Client";
            this.gbSmtpServer.ResumeLayout(false);
            this.gbSmtpServer.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbMail.ResumeLayout(false);
            this.gbMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.GroupBox gbSmtpServer;
        private System.Windows.Forms.CheckBox chbUseSsl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblUseSsl;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtBcc;
        private System.Windows.Forms.Label lblBcc;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.CheckBox chbHtml;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBodyEncoding;
        private System.Windows.Forms.Label lblBodyEncoding;
        private System.Windows.Forms.TextBox txtSubjectEncoding;
        private System.Windows.Forms.Label lblSubjectEncoding;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSend;
    }
}

