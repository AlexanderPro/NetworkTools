namespace HttpRequester
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.pnlGridBorder = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInterval = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkSendRequestContent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).BeginInit();
            this.pnlGridBorder.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(90, 21);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(461, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(9, 24);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(9, 58);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method:";
            // 
            // txtMethod
            // 
            this.txtMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMethod.Location = new System.Drawing.Point(90, 55);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(461, 20);
            this.txtMethod.TabIndex = 3;
            this.txtMethod.Text = "GET";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(9, 128);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(70, 13);
            this.lblTimeout.TabIndex = 6;
            this.lblTimeout.Text = "Timeout (ms):";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeout.Location = new System.Drawing.Point(90, 125);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(461, 20);
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
            this.gridHeaders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridHeaders.GridColor = System.Drawing.SystemColors.Control;
            this.gridHeaders.Location = new System.Drawing.Point(1, 1);
            this.gridHeaders.MultiSelect = false;
            this.gridHeaders.Name = "gridHeaders";
            this.gridHeaders.RowHeadersVisible = false;
            this.gridHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridHeaders.Size = new System.Drawing.Size(537, 113);
            this.gridHeaders.TabIndex = 0;
            this.gridHeaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCellClick);
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
            this.clmnHeaderName.MinimumWidth = 255;
            this.clmnHeaderName.Name = "clmnHeaderName";
            this.clmnHeaderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnHeaderName.Width = 255;
            // 
            // clmnHeaderValue
            // 
            this.clmnHeaderValue.HeaderText = "Header Value";
            this.clmnHeaderValue.MinimumWidth = 260;
            this.clmnHeaderValue.Name = "clmnHeaderValue";
            this.clmnHeaderValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnHeaderValue.Width = 260;
            // 
            // lblHeaders
            // 
            this.lblHeaders.AutoSize = true;
            this.lblHeaders.Location = new System.Drawing.Point(9, 164);
            this.lblHeaders.Name = "lblHeaders";
            this.lblHeaders.Size = new System.Drawing.Size(50, 13);
            this.lblHeaders.TabIndex = 8;
            this.lblHeaders.Text = "Headers:";
            // 
            // txtRequest
            // 
            this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequest.Location = new System.Drawing.Point(12, 336);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequest.Size = new System.Drawing.Size(539, 86);
            this.txtRequest.TabIndex = 11;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(12, 320);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(89, 13);
            this.lblRequest.TabIndex = 10;
            this.lblRequest.Text = "Request content:";
            // 
            // lblResponseContent
            // 
            this.lblResponseContent.AutoSize = true;
            this.lblResponseContent.Location = new System.Drawing.Point(12, 460);
            this.lblResponseContent.Name = "lblResponseContent";
            this.lblResponseContent.Size = new System.Drawing.Size(97, 13);
            this.lblResponseContent.TabIndex = 13;
            this.lblResponseContent.Text = "Response content:";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(12, 476);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(539, 82);
            this.txtResponse.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(428, 573);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(123, 30);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSendClick);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHeader.Location = new System.Drawing.Point(516, 298);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(35, 23);
            this.btnAddHeader.TabIndex = 9;
            this.btnAddHeader.Text = "+";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.ButtonAddHeaderClick);
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(9, 93);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblEncoding.TabIndex = 4;
            this.lblEncoding.Text = "Encoding:";
            // 
            // txtEncoding
            // 
            this.txtEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncoding.Location = new System.Drawing.Point(90, 90);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.Size = new System.Drawing.Size(461, 20);
            this.txtEncoding.TabIndex = 5;
            this.txtEncoding.Text = "UTF-8";
            // 
            // pnlGridBorder
            // 
            this.pnlGridBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlGridBorder.Controls.Add(this.gridHeaders);
            this.pnlGridBorder.Location = new System.Drawing.Point(12, 180);
            this.pnlGridBorder.Name = "pnlGridBorder";
            this.pnlGridBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridBorder.Size = new System.Drawing.Size(539, 115);
            this.pnlGridBorder.TabIndex = 16;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInterval});
            this.statusStrip.Location = new System.Drawing.Point(0, 623);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(565, 24);
            this.statusStrip.TabIndex = 16;
            // 
            // lblInterval
            // 
            this.lblInterval.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblInterval.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(119, 19);
            this.lblInterval.Text = "Interval: 00:00:00.000";
            // 
            // chkSendRequestContent
            // 
            this.chkSendRequestContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSendRequestContent.AutoSize = true;
            this.chkSendRequestContent.Location = new System.Drawing.Point(423, 424);
            this.chkSendRequestContent.Name = "chkSendRequestContent";
            this.chkSendRequestContent.Size = new System.Drawing.Size(134, 17);
            this.chkSendRequestContent.TabIndex = 12;
            this.chkSendRequestContent.Text = "Send Request Content";
            this.chkSendRequestContent.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 647);
            this.Controls.Add(this.chkSendRequestContent);
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
            this.Text = "Http Requester";
            ((System.ComponentModel.ISupportInitialize)(this.gridHeaders)).EndInit();
            this.pnlGridBorder.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.DataGridViewButtonColumn clmnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderValue;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblInterval;
        private System.Windows.Forms.CheckBox chkSendRequestContent;
    }
}

