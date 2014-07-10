namespace UdpClientServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
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
            this.lblReceivedDataEncoding = new System.Windows.Forms.Label();
            this.radioReceivedDataText = new System.Windows.Forms.RadioButton();
            this.grpReceivedData = new System.Windows.Forms.GroupBox();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.txtReceivedDataEncoding = new System.Windows.Forms.TextBox();
            this.radioReceivedDataHex = new System.Windows.Forms.RadioButton();
            this.txtReceivedData = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblSentBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReceivedBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReceivedTotalBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.grpSendData.SuspendLayout();
            this.grpStatusLog.SuspendLayout();
            this.grpReceivedData.SuspendLayout();
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
            this.txtSendData.Size = new System.Drawing.Size(922, 109);
            this.txtSendData.TabIndex = 5;
            // 
            // txtRemoteAddress
            // 
            this.txtRemoteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemoteAddress.Location = new System.Drawing.Point(134, 581);
            this.txtRemoteAddress.Name = "txtRemoteAddress";
            this.txtRemoteAddress.Size = new System.Drawing.Size(99, 20);
            this.txtRemoteAddress.TabIndex = 4;
            // 
            // lblRemoteAddress
            // 
            this.lblRemoteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemoteAddress.AutoSize = true;
            this.lblRemoteAddress.Location = new System.Drawing.Point(14, 584);
            this.lblRemoteAddress.Name = "lblRemoteAddress";
            this.lblRemoteAddress.Size = new System.Drawing.Size(118, 13);
            this.lblRemoteAddress.TabIndex = 3;
            this.lblRemoteAddress.Text = "Remote Host Name\\IP:";
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(258, 584);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(69, 13);
            this.lblRemotePort.TabIndex = 5;
            this.lblRemotePort.Text = "Remote Port:";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemotePort.Location = new System.Drawing.Point(329, 581);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(67, 20);
            this.txtRemotePort.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(649, 578);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(756, 578);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.ButtonStopClick);
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
            this.grpSendData.Size = new System.Drawing.Size(954, 178);
            this.grpSendData.TabIndex = 0;
            this.grpSendData.TabStop = false;
            this.grpSendData.Text = "Send Data";
            // 
            // btnClearSendData
            // 
            this.btnClearSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSendData.Location = new System.Drawing.Point(882, 24);
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
            this.grpStatusLog.Size = new System.Drawing.Size(954, 185);
            this.grpStatusLog.TabIndex = 2;
            this.grpStatusLog.TabStop = false;
            this.grpStatusLog.Text = "Status Log";
            // 
            // btnClearStatusLog
            // 
            this.btnClearStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStatusLog.Location = new System.Drawing.Point(882, 15);
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
            this.txtStatusLog.Size = new System.Drawing.Size(924, 129);
            this.txtStatusLog.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(863, 578);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSendClick);
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
            this.grpReceivedData.Size = new System.Drawing.Size(954, 178);
            this.grpReceivedData.TabIndex = 1;
            this.grpReceivedData.TabStop = false;
            this.grpReceivedData.Text = "Received Data";
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearReceivedData.Location = new System.Drawing.Point(882, 24);
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
            this.txtReceivedData.Size = new System.Drawing.Size(922, 109);
            this.txtReceivedData.TabIndex = 5;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSentBytes,
            this.lblReceivedBytes,
            this.lblReceivedTotalBytes});
            this.statusStrip.Location = new System.Drawing.Point(0, 614);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(972, 22);
            this.statusStrip.TabIndex = 12;
            // 
            // lblSentBytes
            // 
            this.lblSentBytes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSentBytes.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblSentBytes.Name = "lblSentBytes";
            this.lblSentBytes.Size = new System.Drawing.Size(4, 17);
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
            // txtLocalPort
            // 
            this.txtLocalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLocalPort.Location = new System.Drawing.Point(476, 581);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(67, 20);
            this.txtLocalPort.TabIndex = 8;
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Location = new System.Drawing.Point(417, 584);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(58, 13);
            this.lblLocalPort.TabIndex = 7;
            this.lblLocalPort.Text = "Local Port:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 636);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.lblLocalPort);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtRemotePort);
            this.Controls.Add(this.txtRemoteAddress);
            this.Controls.Add(this.lblRemoteAddress);
            this.Controls.Add(this.lblRemotePort);
            this.Controls.Add(this.grpReceivedData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpStatusLog);
            this.Controls.Add(this.grpSendData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Client-Server";
            this.grpSendData.ResumeLayout(false);
            this.grpSendData.PerformLayout();
            this.grpStatusLog.ResumeLayout(false);
            this.grpStatusLog.PerformLayout();
            this.grpReceivedData.ResumeLayout(false);
            this.grpReceivedData.PerformLayout();
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpSendData;
        private System.Windows.Forms.GroupBox grpStatusLog;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.Button btnSend;
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblSentBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblReceivedBytes;
        private System.Windows.Forms.ToolStripStatusLabel lblReceivedTotalBytes;
        private System.Windows.Forms.Button btnClearSendData;
        private System.Windows.Forms.Button btnClearReceivedData;
        private System.Windows.Forms.Button btnClearStatusLog;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label lblLocalPort;
    }
}

