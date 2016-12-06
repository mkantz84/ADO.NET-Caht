namespace Client
{
    partial class frmConnect
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.nmrcPort = new System.Windows.Forms.NumericUpDown();
            this.txtbxNickName = new System.Windows.Forms.TextBox();
            this.txtbxIpAddress = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(222, 196);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.Location = new System.Drawing.Point(115, 196);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nmrcPort
            // 
            this.nmrcPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nmrcPort.Location = new System.Drawing.Point(164, 55);
            this.nmrcPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrcPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcPort.Name = "nmrcPort";
            this.nmrcPort.Size = new System.Drawing.Size(140, 23);
            this.nmrcPort.TabIndex = 1;
            this.nmrcPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtbxNickName
            // 
            this.txtbxNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbxNickName.Location = new System.Drawing.Point(164, 115);
            this.txtbxNickName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxNickName.Name = "txtbxNickName";
            this.txtbxNickName.Size = new System.Drawing.Size(141, 23);
            this.txtbxNickName.TabIndex = 3;
            // 
            // txtbxIpAddress
            // 
            this.txtbxIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbxIpAddress.Location = new System.Drawing.Point(164, 25);
            this.txtbxIpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxIpAddress.Name = "txtbxIpAddress";
            this.txtbxIpAddress.Size = new System.Drawing.Size(141, 23);
            this.txtbxIpAddress.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblColor.Location = new System.Drawing.Point(39, 159);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 17);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color:";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNickName.Location = new System.Drawing.Point(39, 118);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(90, 17);
            this.lblNickName.TabIndex = 11;
            this.lblNickName.Text = "Nick Name:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPort.Location = new System.Drawing.Point(39, 56);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(43, 17);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port:";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIpAddress.Location = new System.Drawing.Point(39, 25);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(91, 17);
            this.lblIpAddress.TabIndex = 7;
            this.lblIpAddress.Text = "IP Address:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(164, 150);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(141, 34);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color Picker";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFullName.Location = new System.Drawing.Point(39, 87);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 17);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFullName.Location = new System.Drawing.Point(163, 85);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(141, 23);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "titi";
            // 
            // frmConnect
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 247);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nmrcPort);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtbxNickName);
            this.Controls.Add(this.txtbxIpAddress);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIpAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nmrcPort;
        private System.Windows.Forms.TextBox txtbxNickName;
        private System.Windows.Forms.TextBox txtbxIpAddress;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
    }
}

