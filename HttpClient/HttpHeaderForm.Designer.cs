namespace HttpClient
{
    partial class HttpHeaderForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtHeaderName = new System.Windows.Forms.TextBox();
            this.txtHeaderValue = new System.Windows.Forms.TextBox();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.lblHeaderValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(297, 120);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(359, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // txtHeaderName
            // 
            this.txtHeaderName.Location = new System.Drawing.Point(23, 31);
            this.txtHeaderName.Name = "txtHeaderName";
            this.txtHeaderName.Size = new System.Drawing.Size(392, 20);
            this.txtHeaderName.TabIndex = 1;
            // 
            // txtHeaderValue
            // 
            this.txtHeaderValue.Location = new System.Drawing.Point(23, 81);
            this.txtHeaderValue.Name = "txtHeaderValue";
            this.txtHeaderValue.Size = new System.Drawing.Size(392, 20);
            this.txtHeaderValue.TabIndex = 3;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(76, 13);
            this.lblHeaderName.TabIndex = 0;
            this.lblHeaderName.Text = "Header Name:";
            // 
            // lblHeaderValue
            // 
            this.lblHeaderValue.AutoSize = true;
            this.lblHeaderValue.Location = new System.Drawing.Point(20, 65);
            this.lblHeaderValue.Name = "lblHeaderValue";
            this.lblHeaderValue.Size = new System.Drawing.Size(75, 13);
            this.lblHeaderValue.TabIndex = 2;
            this.lblHeaderValue.Text = "Header Value:";
            // 
            // HttpHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 160);
            this.Controls.Add(this.txtHeaderValue);
            this.Controls.Add(this.txtHeaderName);
            this.Controls.Add(this.lblHeaderValue);
            this.Controls.Add(this.lblHeaderName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HttpHeaderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Http Header";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtHeaderName;
        private System.Windows.Forms.TextBox txtHeaderValue;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblHeaderValue;
    }
}