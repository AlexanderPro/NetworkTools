﻿namespace HttpClient
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.gridHeaders = new System.Windows.Forms.DataGridView();
            this.clmnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnHeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeaders = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.lblResponseContent = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.pnlGridBorder = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInterval = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearRequestContent = new System.Windows.Forms.Button();
            this.btnClearResponseContent = new System.Windows.Forms.Button();
            this.cmbUseProxy = new System.Windows.Forms.ComboBox();
            this.lblUseProxy = new System.Windows.Forms.Label();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnClientCertificate = new System.Windows.Forms.Button();
            this.lblUseClientCertificate = new System.Windows.Forms.Label();
            this.cmbUseClientCertificate = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClearStatus = new System.Windows.Forms.Button();
            this.lblRequestInLoop = new System.Windows.Forms.Label();
            this.cmbRequestInLoop = new System.Windows.Forms.ComboBox();
            this.txtRequestInterval = new System.Windows.Forms.TextBox();
            this.lblRequestInterval = new System.Windows.Forms.Label();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).BeginInit();
            this.pnlGridBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 30);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(420, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 14);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(12, 74);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method:";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(12, 90);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(130, 20);
            this.txtMethod.TabIndex = 3;
            this.txtMethod.Text = "GET";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(302, 74);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(70, 13);
            this.lblTimeout.TabIndex = 6;
            this.lblTimeout.Text = "Timeout (ms):";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(302, 90);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(130, 20);
            this.txtTimeout.TabIndex = 7;
            this.txtTimeout.Text = "60000";
            // 
            // gridHeaders
            // 
            this.gridHeaders.AllowUserToAddRows = false;
            this.gridHeaders.AllowUserToResizeColumns = false;
            this.gridHeaders.AllowUserToResizeRows = false;
            this.gridHeaders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridHeaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnButton,
            this.clmnHeaderName,
            this.clmnHeaderValue});
            this.gridHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHeaders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridHeaders.GridColor = System.Drawing.SystemColors.Control;
            this.gridHeaders.Location = new System.Drawing.Point(1, 1);
            this.gridHeaders.MultiSelect = false;
            this.gridHeaders.Name = "gridHeaders";
            this.gridHeaders.RowHeadersVisible = false;
            this.gridHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHeaders.Size = new System.Drawing.Size(418, 113);
            this.gridHeaders.TabIndex = 0;
            this.gridHeaders.TabStop = false;
            this.gridHeaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCellClick);
            this.gridHeaders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCellDoubleClick);
            // 
            // clmnButton
            // 
            this.clmnButton.HeaderText = "";
            this.clmnButton.MinimumWidth = 30;
            this.clmnButton.Name = "clmnButton";
            this.clmnButton.Text = "-";
            this.clmnButton.UseColumnTextForButtonValue = true;
            this.clmnButton.Width = 30;
            // 
            // clmnHeaderName
            // 
            this.clmnHeaderName.HeaderText = "Header Name";
            this.clmnHeaderName.MinimumWidth = 200;
            this.clmnHeaderName.Name = "clmnHeaderName";
            this.clmnHeaderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnHeaderName.Width = 200;
            // 
            // clmnHeaderValue
            // 
            this.clmnHeaderValue.HeaderText = "Header Value";
            this.clmnHeaderValue.MinimumWidth = 200;
            this.clmnHeaderValue.Name = "clmnHeaderValue";
            this.clmnHeaderValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnHeaderValue.Width = 200;
            // 
            // lblHeaders
            // 
            this.lblHeaders.AutoSize = true;
            this.lblHeaders.Location = new System.Drawing.Point(12, 134);
            this.lblHeaders.Name = "lblHeaders";
            this.lblHeaders.Size = new System.Drawing.Size(93, 13);
            this.lblHeaders.TabIndex = 8;
            this.lblHeaders.Text = "Request Headers:";
            // 
            // txtRequest
            // 
            this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRequest.Location = new System.Drawing.Point(12, 450);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequest.Size = new System.Drawing.Size(420, 100);
            this.txtRequest.TabIndex = 21;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(12, 434);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(89, 13);
            this.lblRequest.TabIndex = 20;
            this.lblRequest.Text = "Request content:";
            // 
            // lblResponseContent
            // 
            this.lblResponseContent.AutoSize = true;
            this.lblResponseContent.Location = new System.Drawing.Point(447, 134);
            this.lblResponseContent.Name = "lblResponseContent";
            this.lblResponseContent.Size = new System.Drawing.Size(97, 13);
            this.lblResponseContent.TabIndex = 26;
            this.lblResponseContent.Text = "Response content:";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(450, 150);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(420, 400);
            this.txtResponse.TabIndex = 27;
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Location = new System.Drawing.Point(397, 267);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(35, 23);
            this.btnAddHeader.TabIndex = 9;
            this.btnAddHeader.Text = "+";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.ButtonHeaderClick);
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(158, 74);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblEncoding.TabIndex = 4;
            this.lblEncoding.Text = "Encoding:";
            // 
            // txtEncoding
            // 
            this.txtEncoding.Location = new System.Drawing.Point(158, 90);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.Size = new System.Drawing.Size(130, 20);
            this.txtEncoding.TabIndex = 5;
            this.txtEncoding.Text = "UTF-8";
            // 
            // pnlGridBorder
            // 
            this.pnlGridBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlGridBorder.Controls.Add(this.gridHeaders);
            this.pnlGridBorder.Location = new System.Drawing.Point(12, 150);
            this.pnlGridBorder.Name = "pnlGridBorder";
            this.pnlGridBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridBorder.Size = new System.Drawing.Size(420, 115);
            this.pnlGridBorder.TabIndex = 16;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 33;
            // 
            // lblInterval
            // 
            this.lblInterval.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblInterval.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(119, 19);
            this.lblInterval.Text = "Interval: 00:00:00.000";
            // 
            // btnClearRequestContent
            // 
            this.btnClearRequestContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRequestContent.Location = new System.Drawing.Point(391, 553);
            this.btnClearRequestContent.Name = "btnClearRequestContent";
            this.btnClearRequestContent.Size = new System.Drawing.Size(41, 23);
            this.btnClearRequestContent.TabIndex = 22;
            this.btnClearRequestContent.Tag = "txtRequest";
            this.btnClearRequestContent.Text = "Clear";
            this.btnClearRequestContent.UseVisualStyleBackColor = true;
            this.btnClearRequestContent.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // btnClearResponseContent
            // 
            this.btnClearResponseContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResponseContent.Location = new System.Drawing.Point(829, 553);
            this.btnClearResponseContent.Name = "btnClearResponseContent";
            this.btnClearResponseContent.Size = new System.Drawing.Size(41, 23);
            this.btnClearResponseContent.TabIndex = 28;
            this.btnClearResponseContent.Tag = "txtResponse";
            this.btnClearResponseContent.Text = "Clear";
            this.btnClearResponseContent.UseVisualStyleBackColor = true;
            this.btnClearResponseContent.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // cmbUseProxy
            // 
            this.cmbUseProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUseProxy.FormattingEnabled = true;
            this.cmbUseProxy.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbUseProxy.Location = new System.Drawing.Point(12, 316);
            this.cmbUseProxy.Name = "cmbUseProxy";
            this.cmbUseProxy.Size = new System.Drawing.Size(107, 21);
            this.cmbUseProxy.TabIndex = 11;
            this.cmbUseProxy.Tag = "btnProxy";
            this.cmbUseProxy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChanged);
            // 
            // lblUseProxy
            // 
            this.lblUseProxy.AutoSize = true;
            this.lblUseProxy.Location = new System.Drawing.Point(12, 300);
            this.lblUseProxy.Name = "lblUseProxy";
            this.lblUseProxy.Size = new System.Drawing.Size(58, 13);
            this.lblUseProxy.TabIndex = 10;
            this.lblUseProxy.Text = "Use Proxy:";
            // 
            // btnProxy
            // 
            this.btnProxy.Enabled = false;
            this.btnProxy.Location = new System.Drawing.Point(122, 315);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(74, 23);
            this.btnProxy.TabIndex = 12;
            this.btnProxy.Text = "Proxy";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.ButtonProxyClick);
            // 
            // btnClientCertificate
            // 
            this.btnClientCertificate.Enabled = false;
            this.btnClientCertificate.Location = new System.Drawing.Point(357, 315);
            this.btnClientCertificate.Name = "btnClientCertificate";
            this.btnClientCertificate.Size = new System.Drawing.Size(74, 23);
            this.btnClientCertificate.TabIndex = 15;
            this.btnClientCertificate.Text = "Certificate";
            this.btnClientCertificate.UseVisualStyleBackColor = true;
            this.btnClientCertificate.Click += new System.EventHandler(this.ButtonCertificateClick);
            // 
            // lblUseClientCertificate
            // 
            this.lblUseClientCertificate.AutoSize = true;
            this.lblUseClientCertificate.Location = new System.Drawing.Point(245, 299);
            this.lblUseClientCertificate.Name = "lblUseClientCertificate";
            this.lblUseClientCertificate.Size = new System.Drawing.Size(108, 13);
            this.lblUseClientCertificate.TabIndex = 13;
            this.lblUseClientCertificate.Text = "Use Client Certificate:";
            // 
            // cmbUseClientCertificate
            // 
            this.cmbUseClientCertificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUseClientCertificate.FormattingEnabled = true;
            this.cmbUseClientCertificate.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbUseClientCertificate.Location = new System.Drawing.Point(245, 316);
            this.cmbUseClientCertificate.Name = "cmbUseClientCertificate";
            this.cmbUseClientCertificate.Size = new System.Drawing.Size(108, 21);
            this.cmbUseClientCertificate.TabIndex = 14;
            this.cmbUseClientCertificate.Tag = "btnClientCertificate";
            this.cmbUseClientCertificate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(450, 30);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(420, 80);
            this.txtStatus.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(447, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status:";
            // 
            // btnClearStatus
            // 
            this.btnClearStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStatus.Location = new System.Drawing.Point(829, 111);
            this.btnClearStatus.Name = "btnClearStatus";
            this.btnClearStatus.Size = new System.Drawing.Size(41, 23);
            this.btnClearStatus.TabIndex = 25;
            this.btnClearStatus.Tag = "txtStatus";
            this.btnClearStatus.Text = "Clear";
            this.btnClearStatus.UseVisualStyleBackColor = true;
            this.btnClearStatus.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // lblRequestInLoop
            // 
            this.lblRequestInLoop.AutoSize = true;
            this.lblRequestInLoop.Location = new System.Drawing.Point(12, 364);
            this.lblRequestInLoop.Name = "lblRequestInLoop";
            this.lblRequestInLoop.Size = new System.Drawing.Size(107, 13);
            this.lblRequestInLoop.TabIndex = 16;
            this.lblRequestInLoop.Text = "Send request in loop:";
            // 
            // cmbRequestInLoop
            // 
            this.cmbRequestInLoop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestInLoop.FormattingEnabled = true;
            this.cmbRequestInLoop.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbRequestInLoop.Location = new System.Drawing.Point(12, 380);
            this.cmbRequestInLoop.Name = "cmbRequestInLoop";
            this.cmbRequestInLoop.Size = new System.Drawing.Size(107, 21);
            this.cmbRequestInLoop.TabIndex = 17;
            this.cmbRequestInLoop.Tag = "txtRequestInterval";
            this.cmbRequestInLoop.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChanged);
            // 
            // txtRequestInterval
            // 
            this.txtRequestInterval.Enabled = false;
            this.txtRequestInterval.Location = new System.Drawing.Point(125, 381);
            this.txtRequestInterval.Name = "txtRequestInterval";
            this.txtRequestInterval.Size = new System.Drawing.Size(71, 20);
            this.txtRequestInterval.TabIndex = 19;
            this.txtRequestInterval.Text = "5";
            // 
            // lblRequestInterval
            // 
            this.lblRequestInterval.AutoSize = true;
            this.lblRequestInterval.Location = new System.Drawing.Point(125, 365);
            this.lblRequestInterval.Name = "lblRequestInterval";
            this.lblRequestInterval.Size = new System.Drawing.Size(58, 13);
            this.lblRequestInterval.TabIndex = 18;
            this.lblRequestInterval.Text = "(Seconds):";
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadSettings.Image = global::HttpClient.Properties.Resources.Open;
            this.btnLoadSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSettings.Location = new System.Drawing.Point(134, 593);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(114, 30);
            this.btnLoadSettings.TabIndex = 30;
            this.btnLoadSettings.Text = "Load settings ...";
            this.btnLoadSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.ButtonLoadSettingsClick);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettings.Image = global::HttpClient.Properties.Resources.Save;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 593);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(116, 30);
            this.btnSaveSettings.TabIndex = 29;
            this.btnSaveSettings.Text = "Save settings ...";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettingsClick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::HttpClient.Properties.Resources.Stop;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(784, 593);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 30);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Image = global::HttpClient.Properties.Resources.Send;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(692, 593);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 30);
            this.btnSend.TabIndex = 31;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSendClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblRequestInterval);
            this.Controls.Add(this.txtRequestInterval);
            this.Controls.Add(this.lblRequestInLoop);
            this.Controls.Add(this.cmbRequestInLoop);
            this.Controls.Add(this.btnClearStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnClientCertificate);
            this.Controls.Add(this.lblUseClientCertificate);
            this.Controls.Add(this.cmbUseClientCertificate);
            this.Controls.Add(this.btnProxy);
            this.Controls.Add(this.lblUseProxy);
            this.Controls.Add(this.cmbUseProxy);
            this.Controls.Add(this.btnClearResponseContent);
            this.Controls.Add(this.btnClearRequestContent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlGridBorder);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.txtEncoding);
            this.Controls.Add(this.btnAddHeader);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblResponseContent);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.lblHeaders);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTP Client";
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).EndInit();
            this.pnlGridBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.DataGridView gridHeaders;
        private System.Windows.Forms.Label lblHeaders;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label lblResponseContent;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddHeader;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.TextBox txtEncoding;
        private System.Windows.Forms.Panel pnlGridBorder;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblInterval;
        private System.Windows.Forms.Button btnClearRequestContent;
        private System.Windows.Forms.Button btnClearResponseContent;
        private System.Windows.Forms.DataGridViewButtonColumn clmnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderValue;
        private System.Windows.Forms.ComboBox cmbUseProxy;
        private System.Windows.Forms.Label lblUseProxy;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnClientCertificate;
        private System.Windows.Forms.Label lblUseClientCertificate;
        private System.Windows.Forms.ComboBox cmbUseClientCertificate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClearStatus;
        private System.Windows.Forms.Label lblRequestInLoop;
        private System.Windows.Forms.ComboBox cmbRequestInLoop;
        private System.Windows.Forms.TextBox txtRequestInterval;
        private System.Windows.Forms.Label lblRequestInterval;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}

