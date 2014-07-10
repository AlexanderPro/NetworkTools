namespace TcpServer
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
            this.txtLocalAddress = new System.Windows.Forms.TextBox();
            this.lblLocalAddress = new System.Windows.Forms.Label();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.grpSendData = new System.Windows.Forms.GroupBox();
            this.btnClearSendData = new System.Windows.Forms.Button();
            this.txtSendDataEncoding = new System.Windows.Forms.TextBox();
            this.lblSendDataEncoding = new System.Windows.Forms.Label();
            this.radioSendDataText = new System.Windows.Forms.RadioButton();
            this.radioSendDataHex = new System.Windows.Forms.RadioButton();
            this.grpStatusLog = new System.Windows.Forms.GroupBox();
            this.btnClearStatusLog = new System.Windows.Forms.Button();
            this.txtStatusLog = new System.Windows.Forms.TextBox();
            this.lblUseSSL = new System.Windows.Forms.Label();
            this.lblSSLProtocol = new System.Windows.Forms.Label();
            this.cmbSSLProtocol = new System.Windows.Forms.ComboBox();
            this.lblCertificateRevocation = new System.Windows.Forms.Label();
            this.lblReceivedDataEncoding = new System.Windows.Forms.Label();
            this.radioReceivedDataText = new System.Windows.Forms.RadioButton();
            this.grpReceivedData = new System.Windows.Forms.GroupBox();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.txtReceivedDataEncoding = new System.Windows.Forms.TextBox();
            this.radioReceivedDataHex = new System.Windows.Forms.RadioButton();
            this.txtReceivedData = new System.Windows.Forms.TextBox();
            this.grpSSL = new System.Windows.Forms.GroupBox();
            this.btnBrowseCertificateFile = new System.Windows.Forms.Button();
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
            this.grpConnectedClients = new System.Windows.Forms.GroupBox();
            this.pnlGridBorder = new System.Windows.Forms.Panel();
            this.gridConnectedClients = new System.Windows.Forms.DataGridView();
            this.clnmIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendToAllClients = new System.Windows.Forms.Button();
            this.btnSendToClient = new System.Windows.Forms.Button();
            this.btnDisconnectClient = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDisconnectAllClients = new System.Windows.Forms.Button();
            this.chkAllNetwork = new System.Windows.Forms.CheckBox();
            this.grpSendData.SuspendLayout();
            this.grpStatusLog.SuspendLayout();
            this.grpReceivedData.SuspendLayout();
            this.grpSSL.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpConnectedClients.SuspendLayout();
            this.pnlGridBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConnectedClients)).BeginInit();
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
            this.txtSendData.Size = new System.Drawing.Size(483, 109);
            this.txtSendData.TabIndex = 5;
            // 
            // txtLocalAddress
            // 
            this.txtLocalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLocalAddress.Location = new System.Drawing.Point(123, 564);
            this.txtLocalAddress.Name = "txtLocalAddress";
            this.txtLocalAddress.Size = new System.Drawing.Size(110, 20);
            this.txtLocalAddress.TabIndex = 6;
            // 
            // lblLocalAddress
            // 
            this.lblLocalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalAddress.AutoSize = true;
            this.lblLocalAddress.Location = new System.Drawing.Point(18, 568);
            this.lblLocalAddress.Name = "lblLocalAddress";
            this.lblLocalAddress.Size = new System.Drawing.Size(107, 13);
            this.lblLocalAddress.TabIndex = 5;
            this.lblLocalAddress.Text = "Local Host Name\\IP:";
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Location = new System.Drawing.Point(250, 567);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(58, 13);
            this.lblLocalPort.TabIndex = 7;
            this.lblLocalPort.Text = "Local Port:";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLocalPort.Location = new System.Drawing.Point(310, 564);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(110, 20);
            this.txtLocalPort.TabIndex = 8;
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
            this.grpSendData.Size = new System.Drawing.Size(515, 178);
            this.grpSendData.TabIndex = 0;
            this.grpSendData.TabStop = false;
            this.grpSendData.Text = "Send Data";
            // 
            // btnClearSendData
            // 
            this.btnClearSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSendData.Location = new System.Drawing.Point(443, 24);
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
            this.grpStatusLog.Size = new System.Drawing.Size(515, 164);
            this.grpStatusLog.TabIndex = 2;
            this.grpStatusLog.TabStop = false;
            this.grpStatusLog.Text = "Status Log";
            // 
            // btnClearStatusLog
            // 
            this.btnClearStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStatusLog.Location = new System.Drawing.Point(443, 16);
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
            this.txtStatusLog.Location = new System.Drawing.Point(11, 42);
            this.txtStatusLog.Multiline = true;
            this.txtStatusLog.Name = "txtStatusLog";
            this.txtStatusLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusLog.Size = new System.Drawing.Size(485, 107);
            this.txtStatusLog.TabIndex = 1;
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
            this.lblCertificateRevocation.Location = new System.Drawing.Point(7, 98);
            this.lblCertificateRevocation.Name = "lblCertificateRevocation";
            this.lblCertificateRevocation.Size = new System.Drawing.Size(115, 13);
            this.lblCertificateRevocation.TabIndex = 4;
            this.lblCertificateRevocation.Text = "Certificate Revocation:";
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
            this.grpReceivedData.Size = new System.Drawing.Size(515, 178);
            this.grpReceivedData.TabIndex = 1;
            this.grpReceivedData.TabStop = false;
            this.grpReceivedData.Text = "Received Data";
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearReceivedData.Location = new System.Drawing.Point(443, 24);
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
            this.txtReceivedData.Size = new System.Drawing.Size(483, 109);
            this.txtReceivedData.TabIndex = 5;
            // 
            // grpSSL
            // 
            this.grpSSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSSL.Controls.Add(this.btnBrowseCertificateFile);
            this.grpSSL.Controls.Add(this.cmbCertificateRevocation);
            this.grpSSL.Controls.Add(this.cmbUseSSL);
            this.grpSSL.Controls.Add(this.txtCertificatePassword);
            this.grpSSL.Controls.Add(this.lblCertificatePassword);
            this.grpSSL.Controls.Add(this.txtCertificateFile);
            this.grpSSL.Controls.Add(this.lblCertificateFile);
            this.grpSSL.Controls.Add(this.lblUseSSL);
            this.grpSSL.Controls.Add(this.lblSSLProtocol);
            this.grpSSL.Controls.Add(this.cmbSSLProtocol);
            this.grpSSL.Controls.Add(this.lblCertificateRevocation);
            this.grpSSL.Location = new System.Drawing.Point(537, 12);
            this.grpSSL.Name = "grpSSL";
            this.grpSSL.Size = new System.Drawing.Size(311, 532);
            this.grpSSL.TabIndex = 3;
            this.grpSSL.TabStop = false;
            this.grpSSL.Text = "SSL";
            // 
            // btnBrowseCertificateFile
            // 
            this.btnBrowseCertificateFile.Enabled = false;
            this.btnBrowseCertificateFile.Location = new System.Drawing.Point(284, 129);
            this.btnBrowseCertificateFile.Name = "btnBrowseCertificateFile";
            this.btnBrowseCertificateFile.Size = new System.Drawing.Size(24, 21);
            this.btnBrowseCertificateFile.TabIndex = 8;
            this.btnBrowseCertificateFile.Text = "...";
            this.btnBrowseCertificateFile.UseVisualStyleBackColor = true;
            this.btnBrowseCertificateFile.Click += new System.EventHandler(this.ButtonBrowseCertificateFileClick);
            // 
            // cmbCertificateRevocation
            // 
            this.cmbCertificateRevocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCertificateRevocation.Enabled = false;
            this.cmbCertificateRevocation.FormattingEnabled = true;
            this.cmbCertificateRevocation.Location = new System.Drawing.Point(128, 95);
            this.cmbCertificateRevocation.Name = "cmbCertificateRevocation";
            this.cmbCertificateRevocation.Size = new System.Drawing.Size(154, 21);
            this.cmbCertificateRevocation.TabIndex = 5;
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
            this.txtCertificatePassword.Location = new System.Drawing.Point(128, 165);
            this.txtCertificatePassword.Name = "txtCertificatePassword";
            this.txtCertificatePassword.PasswordChar = '*';
            this.txtCertificatePassword.Size = new System.Drawing.Size(154, 20);
            this.txtCertificatePassword.TabIndex = 10;
            // 
            // lblCertificatePassword
            // 
            this.lblCertificatePassword.AutoSize = true;
            this.lblCertificatePassword.Enabled = false;
            this.lblCertificatePassword.Location = new System.Drawing.Point(7, 168);
            this.lblCertificatePassword.Name = "lblCertificatePassword";
            this.lblCertificatePassword.Size = new System.Drawing.Size(106, 13);
            this.lblCertificatePassword.TabIndex = 9;
            this.lblCertificatePassword.Text = "Certificate Password:";
            // 
            // txtCertificateFile
            // 
            this.txtCertificateFile.Enabled = false;
            this.txtCertificateFile.Location = new System.Drawing.Point(128, 130);
            this.txtCertificateFile.Name = "txtCertificateFile";
            this.txtCertificateFile.Size = new System.Drawing.Size(154, 20);
            this.txtCertificateFile.TabIndex = 7;
            // 
            // lblCertificateFile
            // 
            this.lblCertificateFile.AutoSize = true;
            this.lblCertificateFile.Enabled = false;
            this.lblCertificateFile.Location = new System.Drawing.Point(7, 133);
            this.lblCertificateFile.Name = "lblCertificateFile";
            this.lblCertificateFile.Size = new System.Drawing.Size(76, 13);
            this.lblCertificateFile.TabIndex = 6;
            this.lblCertificateFile.Text = "Certificate File:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSentBytes,
            this.lblSentTotalBytes,
            this.lblReceivedBytes,
            this.lblReceivedTotalBytes});
            this.statusStrip.Location = new System.Drawing.Point(0, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1135, 22);
            this.statusStrip.TabIndex = 16;
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
            // grpConnectedClients
            // 
            this.grpConnectedClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnectedClients.Controls.Add(this.pnlGridBorder);
            this.grpConnectedClients.Location = new System.Drawing.Point(864, 12);
            this.grpConnectedClients.Name = "grpConnectedClients";
            this.grpConnectedClients.Size = new System.Drawing.Size(259, 532);
            this.grpConnectedClients.TabIndex = 4;
            this.grpConnectedClients.TabStop = false;
            this.grpConnectedClients.Text = "Connected Clients";
            // 
            // pnlGridBorder
            // 
            this.pnlGridBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlGridBorder.Controls.Add(this.gridConnectedClients);
            this.pnlGridBorder.Location = new System.Drawing.Point(15, 25);
            this.pnlGridBorder.Name = "pnlGridBorder";
            this.pnlGridBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridBorder.Size = new System.Drawing.Size(229, 488);
            this.pnlGridBorder.TabIndex = 0;
            // 
            // gridConnectedClients
            // 
            this.gridConnectedClients.AllowUserToAddRows = false;
            this.gridConnectedClients.AllowUserToResizeColumns = false;
            this.gridConnectedClients.AllowUserToResizeRows = false;
            this.gridConnectedClients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridConnectedClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridConnectedClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConnectedClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnmIP,
            this.clmnPort});
            this.gridConnectedClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConnectedClients.GridColor = System.Drawing.SystemColors.Control;
            this.gridConnectedClients.Location = new System.Drawing.Point(1, 1);
            this.gridConnectedClients.MultiSelect = false;
            this.gridConnectedClients.Name = "gridConnectedClients";
            this.gridConnectedClients.RowHeadersVisible = false;
            this.gridConnectedClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridConnectedClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConnectedClients.Size = new System.Drawing.Size(227, 486);
            this.gridConnectedClients.TabIndex = 0;
            this.gridConnectedClients.SelectionChanged += new System.EventHandler(this.GridSelectionChanged);
            // 
            // clnmIP
            // 
            this.clnmIP.HeaderText = "Remote IP";
            this.clnmIP.MinimumWidth = 140;
            this.clnmIP.Name = "clnmIP";
            this.clnmIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnmIP.Width = 140;
            // 
            // clmnPort
            // 
            this.clmnPort.HeaderText = "Remote Port";
            this.clmnPort.MinimumWidth = 90;
            this.clmnPort.Name = "clmnPort";
            this.clmnPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnPort.Width = 90;
            // 
            // btnSendToAllClients
            // 
            this.btnSendToAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToAllClients.Enabled = false;
            this.btnSendToAllClients.Location = new System.Drawing.Point(997, 634);
            this.btnSendToAllClients.Name = "btnSendToAllClients";
            this.btnSendToAllClients.Size = new System.Drawing.Size(126, 23);
            this.btnSendToAllClients.TabIndex = 15;
            this.btnSendToAllClients.Text = "Send To All Clients";
            this.btnSendToAllClients.UseVisualStyleBackColor = true;
            this.btnSendToAllClients.Click += new System.EventHandler(this.ButtonSendToAllClientsClick);
            // 
            // btnSendToClient
            // 
            this.btnSendToClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToClient.Enabled = false;
            this.btnSendToClient.Location = new System.Drawing.Point(865, 634);
            this.btnSendToClient.Name = "btnSendToClient";
            this.btnSendToClient.Size = new System.Drawing.Size(126, 23);
            this.btnSendToClient.TabIndex = 14;
            this.btnSendToClient.Text = "Send To Client";
            this.btnSendToClient.UseVisualStyleBackColor = true;
            this.btnSendToClient.Click += new System.EventHandler(this.ButtonSendToClientClick);
            // 
            // btnDisconnectClient
            // 
            this.btnDisconnectClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectClient.Enabled = false;
            this.btnDisconnectClient.Location = new System.Drawing.Point(865, 599);
            this.btnDisconnectClient.Name = "btnDisconnectClient";
            this.btnDisconnectClient.Size = new System.Drawing.Size(126, 23);
            this.btnDisconnectClient.TabIndex = 12;
            this.btnDisconnectClient.Text = "Disconnect Client";
            this.btnDisconnectClient.UseVisualStyleBackColor = true;
            this.btnDisconnectClient.Click += new System.EventHandler(this.ButtonDisconnectClientClick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(997, 564);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(865, 564);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // btnDisconnectAllClients
            // 
            this.btnDisconnectAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectAllClients.Enabled = false;
            this.btnDisconnectAllClients.Location = new System.Drawing.Point(997, 599);
            this.btnDisconnectAllClients.Name = "btnDisconnectAllClients";
            this.btnDisconnectAllClients.Size = new System.Drawing.Size(126, 23);
            this.btnDisconnectAllClients.TabIndex = 13;
            this.btnDisconnectAllClients.Text = "Disconnect All Clients";
            this.btnDisconnectAllClients.UseVisualStyleBackColor = true;
            this.btnDisconnectAllClients.Click += new System.EventHandler(this.ButtonDisconnectAllClientsClick);
            // 
            // chkAllNetwork
            // 
            this.chkAllNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAllNetwork.AutoSize = true;
            this.chkAllNetwork.Location = new System.Drawing.Point(441, 567);
            this.chkAllNetwork.Name = "chkAllNetwork";
            this.chkAllNetwork.Size = new System.Drawing.Size(80, 17);
            this.chkAllNetwork.TabIndex = 9;
            this.chkAllNetwork.Text = "All Network";
            this.chkAllNetwork.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 695);
            this.Controls.Add(this.chkAllNetwork);
            this.Controls.Add(this.btnDisconnectAllClients);
            this.Controls.Add(this.btnSendToAllClients);
            this.Controls.Add(this.btnSendToClient);
            this.Controls.Add(this.btnDisconnectClient);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpConnectedClients);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.txtLocalAddress);
            this.Controls.Add(this.lblLocalAddress);
            this.Controls.Add(this.grpSSL);
            this.Controls.Add(this.lblLocalPort);
            this.Controls.Add(this.grpReceivedData);
            this.Controls.Add(this.grpStatusLog);
            this.Controls.Add(this.grpSendData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Server";
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
            this.grpConnectedClients.ResumeLayout(false);
            this.pnlGridBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConnectedClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.TextBox txtLocalAddress;
        private System.Windows.Forms.Label lblLocalAddress;
        private System.Windows.Forms.Label lblLocalPort;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.GroupBox grpSendData;
        private System.Windows.Forms.GroupBox grpStatusLog;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.Label lblUseSSL;
        private System.Windows.Forms.Label lblSSLProtocol;
        private System.Windows.Forms.ComboBox cmbSSLProtocol;
        private System.Windows.Forms.Label lblCertificateRevocation;
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
        private System.Windows.Forms.GroupBox grpConnectedClients;
        private System.Windows.Forms.Panel pnlGridBorder;
        private System.Windows.Forms.DataGridView gridConnectedClients;
        private System.Windows.Forms.Button btnSendToAllClients;
        private System.Windows.Forms.Button btnSendToClient;
        private System.Windows.Forms.Button btnDisconnectClient;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDisconnectAllClients;
        private System.Windows.Forms.CheckBox chkAllNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPort;
        private System.Windows.Forms.Button btnClearSendData;
        private System.Windows.Forms.Button btnClearStatusLog;
        private System.Windows.Forms.Button btnClearReceivedData;
    }
}

