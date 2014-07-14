namespace TcpClient
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
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.txtRemoteAddress = new System.Windows.Forms.TextBox();
            this.lblRemoteAddress = new System.Windows.Forms.Label();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpSendData = new System.Windows.Forms.GroupBox();
            this.btnClearSendData = new System.Windows.Forms.Button();
            this.txtSendDataEncoding = new System.Windows.Forms.TextBox();
            this.lblSendDataEncoding = new System.Windows.Forms.Label();
            this.radioSendDataText = new System.Windows.Forms.RadioButton();
            this.radioSendDataHex = new System.Windows.Forms.RadioButton();
            this.grpStatusLog = new System.Windows.Forms.GroupBox();
            this.btnClearStatusLog = new System.Windows.Forms.Button();
            this.txtStatusLog = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblUseSSL = new System.Windows.Forms.Label();
            this.lblTargetHostName = new System.Windows.Forms.Label();
            this.txtTargetHostName = new System.Windows.Forms.TextBox();
            this.lblSSLProtocol = new System.Windows.Forms.Label();
            this.cmbSSLProtocol = new System.Windows.Forms.ComboBox();
            this.lblCertificateRevocation = new System.Windows.Forms.Label();
            this.lblUseCertificate = new System.Windows.Forms.Label();
            this.lblReceivedDataEncoding = new System.Windows.Forms.Label();
            this.radioReceivedDataText = new System.Windows.Forms.RadioButton();
            this.grpReceivedData = new System.Windows.Forms.GroupBox();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.txtReceivedDataEncoding = new System.Windows.Forms.TextBox();
            this.radioReceivedDataHex = new System.Windows.Forms.RadioButton();
            this.txtReceivedData = new System.Windows.Forms.TextBox();
            this.grpSSL = new System.Windows.Forms.GroupBox();
            this.btnBrowseCertificateFile = new System.Windows.Forms.Button();
            this.cmbUseCertificate = new System.Windows.Forms.ComboBox();
            this.cmbCertificateRevocation = new System.Windows.Forms.ComboBox();
            this.cmbUseSSL = new System.Windows.Forms.ComboBox();
            this.txtCertificatePassword = new System.Windows.Forms.TextBox();
            this.lblCertificatePassword = new System.Windows.Forms.Label();
            this.txtCertificateFile = new System.Windows.Forms.TextBox();
            this.lblCertificateFile = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblSentBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSentTotalBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReceivedBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReceivedTotalBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSendData.SuspendLayout();
            this.grpStatusLog.SuspendLayout();
            this.grpReceivedData.SuspendLayout();
            this.grpSSL.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(13, 50);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendData.Size = new System.Drawing.Size(506, 109);
            this.txtSendData.TabIndex = 5;
            // 
            // txtRemoteAddress
            // 
            this.txtRemoteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemoteAddress.Location = new System.Drawing.Point(135, 580);
            this.txtRemoteAddress.Name = "txtRemoteAddress";
            this.txtRemoteAddress.Size = new System.Drawing.Size(110, 20);
            this.txtRemoteAddress.TabIndex = 5;
            // 
            // lblRemoteAddress
            // 
            this.lblRemoteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemoteAddress.AutoSize = true;
            this.lblRemoteAddress.Location = new System.Drawing.Point(16, 584);
            this.lblRemoteAddress.Name = "lblRemoteAddress";
            this.lblRemoteAddress.Size = new System.Drawing.Size(118, 13);
            this.lblRemoteAddress.TabIndex = 4;
            this.lblRemoteAddress.Text = "Remote Host Name\\IP:";
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(270, 583);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(69, 13);
            this.lblRemotePort.TabIndex = 6;
            this.lblRemotePort.Text = "Remote Port:";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemotePort.Location = new System.Drawing.Point(341, 580);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(110, 20);
            this.txtRemotePort.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(560, 580);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(667, 580);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(97, 23);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.ButtonDisconnectClick);
            // 
            // grpSendData
            // 
            this.grpSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSendData.Controls.Add(this.btnClearSendData);
            this.grpSendData.Controls.Add(this.txtSendDataEncoding);
            this.grpSendData.Controls.Add(this.lblSendDataEncoding);
            this.grpSendData.Controls.Add(this.radioSendDataText);
            this.grpSendData.Controls.Add(this.radioSendDataHex);
            this.grpSendData.Controls.Add(this.txtSendData);
            this.grpSendData.Location = new System.Drawing.Point(6, 12);
            this.grpSendData.Name = "grpSendData";
            this.grpSendData.Size = new System.Drawing.Size(538, 178);
            this.grpSendData.TabIndex = 0;
            this.grpSendData.TabStop = false;
            this.grpSendData.Text = "Send Data";
            // 
            // btnClearSendData
            // 
            this.btnClearSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSendData.Location = new System.Drawing.Point(466, 24);
            this.btnClearSendData.Name = "btnClearSendData";
            this.btnClearSendData.Size = new System.Drawing.Size(53, 23);
            this.btnClearSendData.TabIndex = 4;
            this.btnClearSendData.Tag = "txtSendData";
            this.btnClearSendData.Text = "Clear";
            this.btnClearSendData.UseVisualStyleBackColor = true;
            this.btnClearSendData.Click += new System.EventHandler(this.ButtonClearTextBoxClick);
            // 
            // txtSendDataEncoding
            // 
            this.txtSendDataEncoding.Location = new System.Drawing.Point(229, 26);
            this.txtSendDataEncoding.Name = "txtSendDataEncoding";
            this.txtSendDataEncoding.ReadOnly = true;
            this.txtSendDataEncoding.Size = new System.Drawing.Size(100, 20);
            this.txtSendDataEncoding.TabIndex = 3;
            this.txtSendDataEncoding.Text = "UTF-8";
            // 
            // lblSendDataEncoding
            // 
            this.lblSendDataEncoding.AutoSize = true;
            this.lblSendDataEncoding.Location = new System.Drawing.Point(172, 29);
            this.lblSendDataEncoding.Name = "lblSendDataEncoding";
            this.lblSendDataEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblSendDataEncoding.TabIndex = 2;
            this.lblSendDataEncoding.Text = "Encoding:";
            // 
            // radioSendDataText
            // 
            this.radioSendDataText.AutoSize = true;
            this.radioSendDataText.Checked = true;
            this.radioSendDataText.Location = new System.Drawing.Point(66, 27);
            this.radioSendDataText.Name = "radioSendDataText";
            this.radioSendDataText.Size = new System.Drawing.Size(46, 17);
            this.radioSendDataText.TabIndex = 0;
            this.radioSendDataText.TabStop = true;
            this.radioSendDataText.Text = "Text";
            this.radioSendDataText.UseVisualStyleBackColor = true;
            this.radioSendDataText.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // radioSendDataHex
            // 
            this.radioSendDataHex.AutoSize = true;
            this.radioSendDataHex.Location = new System.Drawing.Point(13, 27);
            this.radioSendDataHex.Name = "radioSendDataHex";
            this.radioSendDataHex.Size = new System.Drawing.Size(47, 17);
            this.radioSendDataHex.TabIndex = 1;
            this.radioSendDataHex.Text = "HEX";
            this.radioSendDataHex.UseVisualStyleBackColor = true;
            this.radioSendDataHex.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // grpStatusLog
            // 
            this.grpStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStatusLog.Controls.Add(this.btnClearStatusLog);
            this.grpStatusLog.Controls.Add(this.txtStatusLog);
            this.grpStatusLog.Location = new System.Drawing.Point(6, 380);
            this.grpStatusLog.Name = "grpStatusLog";
            this.grpStatusLog.Size = new System.Drawing.Size(538, 185);
            this.grpStatusLog.TabIndex = 2;
            this.grpStatusLog.TabStop = false;
            this.grpStatusLog.Text = "Status Log";
            // 
            // btnClearStatusLog
            // 
            this.btnClearStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStatusLog.Location = new System.Drawing.Point(466, 15);
            this.btnClearStatusLog.Name = "btnClearStatusLog";
            this.btnClearStatusLog.Size = new System.Drawing.Size(53, 23);
            this.btnClearStatusLog.TabIndex = 0;
            this.btnClearStatusLog.Tag = "txtStatusLog";
            this.btnClearStatusLog.Text = "Clear";
            this.btnClearStatusLog.UseVisualStyleBackColor = true;
            this.btnClearStatusLog.Click += new System.EventHandler(this.ButtonClearTextBoxClick);
            // 
            // txtStatusLog
            // 
            this.txtStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusLog.Location = new System.Drawing.Point(11, 41);
            this.txtStatusLog.Multiline = true;
            this.txtStatusLog.Name = "txtStatusLog";
            this.txtStatusLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusLog.Size = new System.Drawing.Size(508, 129);
            this.txtStatusLog.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(774, 580);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSendClick);
            // 
            // lblUseSSL
            // 
            this.lblUseSSL.AutoSize = true;
            this.lblUseSSL.Location = new System.Drawing.Point(6, 29);
            this.lblUseSSL.Name = "lblUseSSL";
            this.lblUseSSL.Size = new System.Drawing.Size(52, 13);
            this.lblUseSSL.TabIndex = 0;
            this.lblUseSSL.Text = "Use SSL:";
            // 
            // lblTargetHostName
            // 
            this.lblTargetHostName.AutoSize = true;
            this.lblTargetHostName.Enabled = false;
            this.lblTargetHostName.Location = new System.Drawing.Point(6, 98);
            this.lblTargetHostName.Name = "lblTargetHostName";
            this.lblTargetHostName.Size = new System.Drawing.Size(97, 13);
            this.lblTargetHostName.TabIndex = 4;
            this.lblTargetHostName.Text = "Target Host Name:";
            // 
            // txtTargetHostName
            // 
            this.txtTargetHostName.Enabled = false;
            this.txtTargetHostName.Location = new System.Drawing.Point(128, 95);
            this.txtTargetHostName.Name = "txtTargetHostName";
            this.txtTargetHostName.Size = new System.Drawing.Size(154, 20);
            this.txtTargetHostName.TabIndex = 5;
            // 
            // lblSSLProtocol
            // 
            this.lblSSLProtocol.AutoSize = true;
            this.lblSSLProtocol.Enabled = false;
            this.lblSSLProtocol.Location = new System.Drawing.Point(6, 63);
            this.lblSSLProtocol.Name = "lblSSLProtocol";
            this.lblSSLProtocol.Size = new System.Drawing.Size(72, 13);
            this.lblSSLProtocol.TabIndex = 2;
            this.lblSSLProtocol.Text = "SSL Protocol:";
            // 
            // cmbSSLProtocol
            // 
            this.cmbSSLProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSSLProtocol.Enabled = false;
            this.cmbSSLProtocol.FormattingEnabled = true;
            this.cmbSSLProtocol.Location = new System.Drawing.Point(128, 60);
            this.cmbSSLProtocol.Name = "cmbSSLProtocol";
            this.cmbSSLProtocol.Size = new System.Drawing.Size(154, 21);
            this.cmbSSLProtocol.TabIndex = 3;
            // 
            // lblCertificateRevocation
            // 
            this.lblCertificateRevocation.AutoSize = true;
            this.lblCertificateRevocation.Enabled = false;
            this.lblCertificateRevocation.Location = new System.Drawing.Point(7, 133);
            this.lblCertificateRevocation.Name = "lblCertificateRevocation";
            this.lblCertificateRevocation.Size = new System.Drawing.Size(115, 13);
            this.lblCertificateRevocation.TabIndex = 6;
            this.lblCertificateRevocation.Text = "Certificate Revocation:";
            // 
            // lblUseCertificate
            // 
            this.lblUseCertificate.AutoSize = true;
            this.lblUseCertificate.Enabled = false;
            this.lblUseCertificate.Location = new System.Drawing.Point(7, 168);
            this.lblUseCertificate.Name = "lblUseCertificate";
            this.lblUseCertificate.Size = new System.Drawing.Size(79, 13);
            this.lblUseCertificate.TabIndex = 8;
            this.lblUseCertificate.Text = "Use Certificate:";
            // 
            // lblReceivedDataEncoding
            // 
            this.lblReceivedDataEncoding.AutoSize = true;
            this.lblReceivedDataEncoding.Location = new System.Drawing.Point(172, 29);
            this.lblReceivedDataEncoding.Name = "lblReceivedDataEncoding";
            this.lblReceivedDataEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblReceivedDataEncoding.TabIndex = 2;
            this.lblReceivedDataEncoding.Text = "Encoding:";
            // 
            // radioReceivedDataText
            // 
            this.radioReceivedDataText.AutoSize = true;
            this.radioReceivedDataText.Checked = true;
            this.radioReceivedDataText.Location = new System.Drawing.Point(66, 27);
            this.radioReceivedDataText.Name = "radioReceivedDataText";
            this.radioReceivedDataText.Size = new System.Drawing.Size(46, 17);
            this.radioReceivedDataText.TabIndex = 1;
            this.radioReceivedDataText.TabStop = true;
            this.radioReceivedDataText.Text = "Text";
            this.radioReceivedDataText.UseVisualStyleBackColor = true;
            this.radioReceivedDataText.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // grpReceivedData
            // 
            this.grpReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReceivedData.Controls.Add(this.btnClearReceivedData);
            this.grpReceivedData.Controls.Add(this.txtReceivedDataEncoding);
            this.grpReceivedData.Controls.Add(this.lblReceivedDataEncoding);
            this.grpReceivedData.Controls.Add(this.radioReceivedDataText);
            this.grpReceivedData.Controls.Add(this.radioReceivedDataHex);
            this.grpReceivedData.Controls.Add(this.txtReceivedData);
            this.grpReceivedData.Location = new System.Drawing.Point(6, 196);
            this.grpReceivedData.Name = "grpReceivedData";
            this.grpReceivedData.Size = new System.Drawing.Size(538, 178);
            this.grpReceivedData.TabIndex = 1;
            this.grpReceivedData.TabStop = false;
            this.grpReceivedData.Text = "Received Data";
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearReceivedData.Location = new System.Drawing.Point(466, 24);
            this.btnClearReceivedData.Name = "btnClearReceivedData";
            this.btnClearReceivedData.Size = new System.Drawing.Size(53, 23);
            this.btnClearReceivedData.TabIndex = 4;
            this.btnClearReceivedData.Tag = "txtReceivedData";
            this.btnClearReceivedData.Text = "Clear";
            this.btnClearReceivedData.UseVisualStyleBackColor = true;
            this.btnClearReceivedData.Click += new System.EventHandler(this.ButtonClearTextBoxClick);
            // 
            // txtReceivedDataEncoding
            // 
            this.txtReceivedDataEncoding.Location = new System.Drawing.Point(229, 26);
            this.txtReceivedDataEncoding.Name = "txtReceivedDataEncoding";
            this.txtReceivedDataEncoding.ReadOnly = true;
            this.txtReceivedDataEncoding.Size = new System.Drawing.Size(100, 20);
            this.txtReceivedDataEncoding.TabIndex = 3;
            this.txtReceivedDataEncoding.Text = "UTF-8";
            // 
            // radioReceivedDataHex
            // 
            this.radioReceivedDataHex.AutoSize = true;
            this.radioReceivedDataHex.Location = new System.Drawing.Point(13, 27);
            this.radioReceivedDataHex.Name = "radioReceivedDataHex";
            this.radioReceivedDataHex.Size = new System.Drawing.Size(47, 17);
            this.radioReceivedDataHex.TabIndex = 0;
            this.radioReceivedDataHex.Text = "HEX";
            this.radioReceivedDataHex.UseVisualStyleBackColor = true;
            this.radioReceivedDataHex.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // txtReceivedData
            // 
            this.txtReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceivedData.Location = new System.Drawing.Point(13, 50);
            this.txtReceivedData.Multiline = true;
            this.txtReceivedData.Name = "txtReceivedData";
            this.txtReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedData.Size = new System.Drawing.Size(506, 109);
            this.txtReceivedData.TabIndex = 5;
            // 
            // grpSSL
            // 
            this.grpSSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSSL.Controls.Add(this.btnBrowseCertificateFile);
            this.grpSSL.Controls.Add(this.cmbUseCertificate);
            this.grpSSL.Controls.Add(this.cmbCertificateRevocation);
            this.grpSSL.Controls.Add(this.cmbUseSSL);
            this.grpSSL.Controls.Add(this.txtCertificatePassword);
            this.grpSSL.Controls.Add(this.lblCertificatePassword);
            this.grpSSL.Controls.Add(this.txtCertificateFile);
            this.grpSSL.Controls.Add(this.lblCertificateFile);
            this.grpSSL.Controls.Add(this.txtTargetHostName);
            this.grpSSL.Controls.Add(this.lblTargetHostName);
            this.grpSSL.Controls.Add(this.lblUseSSL);
            this.grpSSL.Controls.Add(this.lblUseCertificate);
            this.grpSSL.Controls.Add(this.lblSSLProtocol);
            this.grpSSL.Controls.Add(this.cmbSSLProtocol);
            this.grpSSL.Controls.Add(this.lblCertificateRevocation);
            this.grpSSL.Location = new System.Drawing.Point(560, 12);
            this.grpSSL.Name = "grpSSL";
            this.grpSSL.Size = new System.Drawing.Size(311, 553);
            this.grpSSL.TabIndex = 3;
            this.grpSSL.TabStop = false;
            this.grpSSL.Text = "SSL";
            // 
            // btnBrowseCertificateFile
            // 
            this.btnBrowseCertificateFile.Enabled = false;
            this.btnBrowseCertificateFile.Location = new System.Drawing.Point(283, 198);
            this.btnBrowseCertificateFile.Name = "btnBrowseCertificateFile";
            this.btnBrowseCertificateFile.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseCertificateFile.TabIndex = 12;
            this.btnBrowseCertificateFile.Text = "...";
            this.btnBrowseCertificateFile.UseVisualStyleBackColor = true;
            this.btnBrowseCertificateFile.Click += new System.EventHandler(this.ButtonBrowseCertificateFileClick);
            // 
            // cmbUseCertificate
            // 
            this.cmbUseCertificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUseCertificate.Enabled = false;
            this.cmbUseCertificate.FormattingEnabled = true;
            this.cmbUseCertificate.Location = new System.Drawing.Point(128, 165);
            this.cmbUseCertificate.Name = "cmbUseCertificate";
            this.cmbUseCertificate.Size = new System.Drawing.Size(154, 21);
            this.cmbUseCertificate.TabIndex = 9;
            // 
            // cmbCertificateRevocation
            // 
            this.cmbCertificateRevocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCertificateRevocation.Enabled = false;
            this.cmbCertificateRevocation.FormattingEnabled = true;
            this.cmbCertificateRevocation.Location = new System.Drawing.Point(128, 130);
            this.cmbCertificateRevocation.Name = "cmbCertificateRevocation";
            this.cmbCertificateRevocation.Size = new System.Drawing.Size(154, 21);
            this.cmbCertificateRevocation.TabIndex = 7;
            // 
            // cmbUseSSL
            // 
            this.cmbUseSSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUseSSL.FormattingEnabled = true;
            this.cmbUseSSL.Location = new System.Drawing.Point(128, 25);
            this.cmbUseSSL.Name = "cmbUseSSL";
            this.cmbUseSSL.Size = new System.Drawing.Size(154, 21);
            this.cmbUseSSL.TabIndex = 1;
            // 
            // txtCertificatePassword
            // 
            this.txtCertificatePassword.Enabled = false;
            this.txtCertificatePassword.Location = new System.Drawing.Point(127, 235);
            this.txtCertificatePassword.Name = "txtCertificatePassword";
            this.txtCertificatePassword.PasswordChar = '*';
            this.txtCertificatePassword.Size = new System.Drawing.Size(154, 20);
            this.txtCertificatePassword.TabIndex = 14;
            // 
            // lblCertificatePassword
            // 
            this.lblCertificatePassword.AutoSize = true;
            this.lblCertificatePassword.Enabled = false;
            this.lblCertificatePassword.Location = new System.Drawing.Point(6, 238);
            this.lblCertificatePassword.Name = "lblCertificatePassword";
            this.lblCertificatePassword.Size = new System.Drawing.Size(106, 13);
            this.lblCertificatePassword.TabIndex = 13;
            this.lblCertificatePassword.Text = "Certificate Password:";
            // 
            // txtCertificateFile
            // 
            this.txtCertificateFile.Enabled = false;
            this.txtCertificateFile.Location = new System.Drawing.Point(127, 200);
            this.txtCertificateFile.Name = "txtCertificateFile";
            this.txtCertificateFile.Size = new System.Drawing.Size(154, 20);
            this.txtCertificateFile.TabIndex = 11;
            // 
            // lblCertificateFile
            // 
            this.lblCertificateFile.AutoSize = true;
            this.lblCertificateFile.Enabled = false;
            this.lblCertificateFile.Location = new System.Drawing.Point(6, 203);
            this.lblCertificateFile.Name = "lblCertificateFile";
            this.lblCertificateFile.Size = new System.Drawing.Size(76, 13);
            this.lblCertificateFile.TabIndex = 10;
            this.lblCertificateFile.Text = "Certificate File:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSentBytes,
            this.lblSentTotalBytes,
            this.lblReceivedBytes,
            this.lblReceivedTotalBytes});
            this.statusStrip.Location = new System.Drawing.Point(0, 614);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(885, 22);
            this.statusStrip.TabIndex = 11;
            // 
            // lblSentBytes
            // 
            this.lblSentBytes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSentBytes.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblSentBytes.Name = "lblSentBytes";
            this.lblSentBytes.Size = new System.Drawing.Size(4, 17);
            // 
            // lblSentTotalBytes
            // 
            this.lblSentTotalBytes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSentTotalBytes.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblSentTotalBytes.Name = "lblSentTotalBytes";
            this.lblSentTotalBytes.Size = new System.Drawing.Size(4, 17);
            // 
            // lblReceivedBytes
            // 
            this.lblReceivedBytes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblReceivedBytes.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblReceivedBytes.Name = "lblReceivedBytes";
            this.lblReceivedBytes.Size = new System.Drawing.Size(4, 17);
            // 
            // lblReceivedTotalBytes
            // 
            this.lblReceivedTotalBytes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblReceivedTotalBytes.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblReceivedTotalBytes.Name = "lblReceivedTotalBytes";
            this.lblReceivedTotalBytes.Size = new System.Drawing.Size(4, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 636);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtRemotePort);
            this.Controls.Add(this.txtRemoteAddress);
            this.Controls.Add(this.lblRemoteAddress);
            this.Controls.Add(this.grpSSL);
            this.Controls.Add(this.lblRemotePort);
            this.Controls.Add(this.grpReceivedData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpStatusLog);
            this.Controls.Add(this.grpSendData);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client";
            this.grpSendData.ResumeLayout(false);
            this.grpSendData.PerformLayout();
            this.grpStatusLog.ResumeLayout(false);
            this.grpStatusLog.PerformLayout();
            this.grpReceivedData.ResumeLayout(false);
            this.grpReceivedData.PerformLayout();
            this.grpSSL.ResumeLayout(false);
            this.grpSSL.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.TextBox txtRemoteAddress;
        private System.Windows.Forms.Label lblRemoteAddress;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpSendData;
        private System.Windows.Forms.GroupBox grpStatusLog;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblUseSSL;
        private System.Windows.Forms.Label lblTargetHostName;
        private System.Windows.Forms.TextBox txtTargetHostName;
        private System.Windows.Forms.Label lblSSLProtocol;
        private System.Windows.Forms.ComboBox cmbSSLProtocol;
        private System.Windows.Forms.Label lblCertificateRevocation;
        private System.Windows.Forms.Label lblUseCertificate;
        private System.Windows.Forms.TextBox txtSendDataEncoding;
        private System.Windows.Forms.Label lblSendDataEncoding;
        private System.Windows.Forms.RadioButton radioSendDataText;
        private System.Windows.Forms.RadioButton radioSendDataHex;
        private System.Windows.Forms.Label lblReceivedDataEncoding;
        private System.Windows.Forms.RadioButton radioReceivedDataText;
        private System.Windows.Forms.GroupBox grpReceivedData;
        private System.Windows.Forms.TextBox txtReceivedDataEncoding;
        private System.Windows.Forms.RadioButton radioReceivedDataHex;
        private System.Windows.Forms.TextBox txtReceivedData;
        private System.Windows.Forms.GroupBox grpSSL;
        private System.Windows.Forms.Label lblCertificateFile;
        private System.Windows.Forms.TextBox txtCertificateFile;
        private System.Windows.Forms.ComboBox cmbUseCertificate;
        private System.Windows.Forms.ComboBox cmbCertificateRevocation;
        private System.Windows.Forms.ComboBox cmbUseSSL;
        private System.Windows.Forms.TextBox txtCertificatePassword;
        private System.Windows.Forms.Label lblCertificatePassword;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblSentBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblReceivedBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblSentTotalBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblReceivedTotalBytes;
        private System.Windows.Forms.Button btnBrowseCertificateFile;
        private System.Windows.Forms.Button btnClearSendData;
        private System.Windows.Forms.Button btnClearReceivedData;
        private System.Windows.Forms.Button btnClearStatusLog;
    }
}

