namespace Client
{
    partial class frmChatClientSide
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxMessages = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkbxlstUsers = new System.Windows.Forms.CheckedListBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSend.Location = new System.Drawing.Point(505, 372);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 33);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMsg.Location = new System.Drawing.Point(15, 373);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(484, 30);
            this.txtMsg.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMsg, "Select user from list for private message, or write his/er name at the beginning");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select user from the list for private message:";
            // 
            // txtbxMessages
            // 
            this.txtbxMessages.Location = new System.Drawing.Point(19, 27);
            this.txtbxMessages.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxMessages.Name = "txtbxMessages";
            this.txtbxMessages.Size = new System.Drawing.Size(480, 310);
            this.txtbxMessages.TabIndex = 11;
            this.txtbxMessages.Text = "";
            // 
            // chkbxlstUsers
            // 
            this.chkbxlstUsers.CheckOnClick = true;
            this.chkbxlstUsers.FormattingEnabled = true;
            this.chkbxlstUsers.Location = new System.Drawing.Point(505, 27);
            this.chkbxlstUsers.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxlstUsers.Name = "chkbxlstUsers";
            this.chkbxlstUsers.Size = new System.Drawing.Size(148, 310);
            this.chkbxlstUsers.TabIndex = 12;
            this.chkbxlstUsers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkbxlstUsers_ItemCheck);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChangeColor.Location = new System.Drawing.Point(505, 331);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(147, 36);
            this.btnChangeColor.TabIndex = 13;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // frmChatClientSide
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 418);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.chkbxlstUsers);
            this.Controls.Add(this.txtbxMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmChatClientSide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatClientSide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChatClientSide_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtbxMessages;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox chkbxlstUsers;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}