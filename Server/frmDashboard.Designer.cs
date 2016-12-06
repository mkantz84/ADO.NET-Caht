namespace Server
{
    partial class frmDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.lstClientsConnected = new System.Windows.Forms.ListView();
            this.clmnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.lstClientsHistory = new System.Windows.Forms.ListView();
            this.clmnHistoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnOutTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.btnSearchMessage = new System.Windows.Forms.Button();
            this.txtMessageSearch = new System.Windows.Forms.TextBox();
            this.dtMessages = new System.Windows.Forms.DateTimePicker();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstUsers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbxMessagesResults = new System.Windows.Forms.ComboBox();
            this.cmbxMessages = new System.Windows.Forms.ComboBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.cmbxUsersResults = new System.Windows.Forms.ComboBox();
            this.cmbxSerachUsers = new System.Windows.Forms.ComboBox();
            this.lblSearchUsers = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbUsers.SuspendLayout();
            this.tbHistory.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbUsers);
            this.tabControl1.Controls.Add(this.tbHistory);
            this.tabControl1.Controls.Add(this.tbSearch);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 537);
            this.tabControl1.TabIndex = 2;
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.lstClientsConnected);
            this.tbUsers.Location = new System.Drawing.Point(4, 33);
            this.tbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tbUsers.Size = new System.Drawing.Size(663, 500);
            this.tbUsers.TabIndex = 0;
            this.tbUsers.Text = "USERS";
            this.tbUsers.UseVisualStyleBackColor = true;
            // 
            // lstClientsConnected
            // 
            this.lstClientsConnected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnID,
            this.clmnNickName,
            this.clmnStatus,
            this.clmnTime});
            this.lstClientsConnected.Location = new System.Drawing.Point(9, 9);
            this.lstClientsConnected.Margin = new System.Windows.Forms.Padding(6);
            this.lstClientsConnected.Name = "lstClientsConnected";
            this.lstClientsConnected.Size = new System.Drawing.Size(635, 467);
            this.lstClientsConnected.TabIndex = 0;
            this.lstClientsConnected.UseCompatibleStateImageBehavior = false;
            this.lstClientsConnected.View = System.Windows.Forms.View.Details;
            // 
            // clmnID
            // 
            this.clmnID.Text = "ID    ";
            this.clmnID.Width = 90;
            // 
            // clmnNickName
            // 
            this.clmnNickName.Text = "Nick Name";
            this.clmnNickName.Width = 136;
            // 
            // clmnStatus
            // 
            this.clmnStatus.Text = "Status            ";
            this.clmnStatus.Width = 124;
            // 
            // clmnTime
            // 
            this.clmnTime.Text = "Login Time";
            this.clmnTime.Width = 133;
            // 
            // tbHistory
            // 
            this.tbHistory.Controls.Add(this.lstClientsHistory);
            this.tbHistory.Location = new System.Drawing.Point(4, 33);
            this.tbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tbHistory.Size = new System.Drawing.Size(663, 500);
            this.tbHistory.TabIndex = 1;
            this.tbHistory.Text = "HISTORY";
            this.tbHistory.UseVisualStyleBackColor = true;
            // 
            // lstClientsHistory
            // 
            this.lstClientsHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHistoryId,
            this.columnHeader1,
            this.columnHeader2,
            this.clmnOutTime});
            this.lstClientsHistory.Location = new System.Drawing.Point(9, 9);
            this.lstClientsHistory.Margin = new System.Windows.Forms.Padding(6);
            this.lstClientsHistory.Name = "lstClientsHistory";
            this.lstClientsHistory.Size = new System.Drawing.Size(635, 467);
            this.lstClientsHistory.TabIndex = 1;
            this.lstClientsHistory.UseCompatibleStateImageBehavior = false;
            this.lstClientsHistory.View = System.Windows.Forms.View.Details;
            // 
            // clmnHistoryId
            // 
            this.clmnHistoryId.Text = "ID    ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nick Name";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status                     ";
            this.columnHeader2.Width = 179;
            // 
            // clmnOutTime
            // 
            this.clmnOutTime.Text = "LogoutTime";
            this.clmnOutTime.Width = 159;
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.btnSearchMessage);
            this.tbSearch.Controls.Add(this.txtMessageSearch);
            this.tbSearch.Controls.Add(this.dtMessages);
            this.tbSearch.Controls.Add(this.lstMessages);
            this.tbSearch.Controls.Add(this.lstUsers);
            this.tbSearch.Controls.Add(this.cmbxMessagesResults);
            this.tbSearch.Controls.Add(this.cmbxMessages);
            this.tbSearch.Controls.Add(this.lblMessages);
            this.tbSearch.Controls.Add(this.cmbxUsersResults);
            this.tbSearch.Controls.Add(this.cmbxSerachUsers);
            this.tbSearch.Controls.Add(this.lblSearchUsers);
            this.tbSearch.Location = new System.Drawing.Point(4, 33);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.tbSearch.Size = new System.Drawing.Size(663, 500);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "SEARCH";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearchMessage
            // 
            this.btnSearchMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearchMessage.Location = new System.Drawing.Point(532, 103);
            this.btnSearchMessage.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchMessage.Name = "btnSearchMessage";
            this.btnSearchMessage.Size = new System.Drawing.Size(114, 39);
            this.btnSearchMessage.TabIndex = 10;
            this.btnSearchMessage.Text = "Search";
            this.btnSearchMessage.UseVisualStyleBackColor = true;
            this.btnSearchMessage.Visible = false;
            this.btnSearchMessage.Click += new System.EventHandler(this.btnSearchMessage_Click);
            // 
            // txtMessageSearch
            // 
            this.txtMessageSearch.Location = new System.Drawing.Point(330, 103);
            this.txtMessageSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtMessageSearch.Name = "txtMessageSearch";
            this.txtMessageSearch.Size = new System.Drawing.Size(187, 29);
            this.txtMessageSearch.TabIndex = 9;
            this.txtMessageSearch.Visible = false;
            // 
            // dtMessages
            // 
            this.dtMessages.Location = new System.Drawing.Point(330, 103);
            this.dtMessages.Margin = new System.Windows.Forms.Padding(6);
            this.dtMessages.Name = "dtMessages";
            this.dtMessages.Size = new System.Drawing.Size(318, 29);
            this.dtMessages.TabIndex = 8;
            this.dtMessages.Visible = false;
            this.dtMessages.ValueChanged += new System.EventHandler(this.dtMessages_ValueChanged);
            // 
            // lstMessages
            // 
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader8});
            this.lstMessages.Location = new System.Drawing.Point(13, 145);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(6);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(635, 338);
            this.lstMessages.TabIndex = 7;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            this.lstMessages.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "UserName";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Text Meassage             ";
            this.columnHeader7.Width = 104;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Recipient";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time";
            this.columnHeader8.Width = 179;
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5});
            this.lstUsers.Location = new System.Drawing.Point(13, 144);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(6);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(635, 338);
            this.lstUsers.TabIndex = 6;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID    ";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name  ";
            this.columnHeader9.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nick Name";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status                     ";
            this.columnHeader5.Width = 179;
            // 
            // cmbxMessagesResults
            // 
            this.cmbxMessagesResults.FormattingEnabled = true;
            this.cmbxMessagesResults.Location = new System.Drawing.Point(330, 103);
            this.cmbxMessagesResults.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxMessagesResults.Name = "cmbxMessagesResults";
            this.cmbxMessagesResults.Size = new System.Drawing.Size(187, 32);
            this.cmbxMessagesResults.TabIndex = 5;
            this.cmbxMessagesResults.Visible = false;
            this.cmbxMessagesResults.SelectedIndexChanged += new System.EventHandler(this.cmbxMessagesResults_SelectedIndexChanged);
            // 
            // cmbxMessages
            // 
            this.cmbxMessages.FormattingEnabled = true;
            this.cmbxMessages.Items.AddRange(new object[] {
            "All",
            "General Search",
            "Search messages by user sent",
            "Search messages that user got",
            "Search messages by date"});
            this.cmbxMessages.Location = new System.Drawing.Point(13, 103);
            this.cmbxMessages.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxMessages.Name = "cmbxMessages";
            this.cmbxMessages.Size = new System.Drawing.Size(310, 32);
            this.cmbxMessages.TabIndex = 4;
            this.cmbxMessages.SelectedIndexChanged += new System.EventHandler(this.cmbxMessages_SelectedIndexChanged);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(7, 76);
            this.lblMessages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(177, 25);
            this.lblMessages.TabIndex = 3;
            this.lblMessages.Text = "Search Messages:";
            // 
            // cmbxUsersResults
            // 
            this.cmbxUsersResults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUsersResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUsersResults.FormattingEnabled = true;
            this.cmbxUsersResults.Location = new System.Drawing.Point(330, 35);
            this.cmbxUsersResults.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxUsersResults.Name = "cmbxUsersResults";
            this.cmbxUsersResults.Size = new System.Drawing.Size(187, 32);
            this.cmbxUsersResults.TabIndex = 2;
            this.cmbxUsersResults.Visible = false;
            this.cmbxUsersResults.SelectedIndexChanged += new System.EventHandler(this.cmbxUsersResults_SelectedIndexChanged);
            // 
            // cmbxSerachUsers
            // 
            this.cmbxSerachUsers.FormattingEnabled = true;
            this.cmbxSerachUsers.Items.AddRange(new object[] {
            "All",
            "Search users by name",
            "Search users by ID"});
            this.cmbxSerachUsers.Location = new System.Drawing.Point(13, 35);
            this.cmbxSerachUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxSerachUsers.Name = "cmbxSerachUsers";
            this.cmbxSerachUsers.Size = new System.Drawing.Size(310, 32);
            this.cmbxSerachUsers.TabIndex = 1;
            this.cmbxSerachUsers.SelectedIndexChanged += new System.EventHandler(this.cmbxSerachUsers_SelectedIndexChanged);
            // 
            // lblSearchUsers
            // 
            this.lblSearchUsers.AutoSize = true;
            this.lblSearchUsers.Location = new System.Drawing.Point(7, 7);
            this.lblSearchUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchUsers.Name = "lblSearchUsers";
            this.lblSearchUsers.Size = new System.Drawing.Size(137, 25);
            this.lblSearchUsers.TabIndex = 0;
            this.lblSearchUsers.Text = "Search Users:";
            // 
            // frmDashboard
            // 
            this.AcceptButton = this.btnSearchMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 574);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.Text = "Server Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
            this.tbHistory.ResumeLayout(false);
            this.tbSearch.ResumeLayout(false);
            this.tbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.ListView lstClientsConnected;
        private System.Windows.Forms.ColumnHeader clmnNickName;
        private System.Windows.Forms.ColumnHeader clmnStatus;
        private System.Windows.Forms.TabPage tbHistory;
        private System.Windows.Forms.ListView lstClientsHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader clmnOutTime;
        private System.Windows.Forms.ColumnHeader clmnID;
        private System.Windows.Forms.ColumnHeader clmnHistoryId;
        private System.Windows.Forms.ColumnHeader clmnTime;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbxMessagesResults;
        private System.Windows.Forms.ComboBox cmbxMessages;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.ComboBox cmbxUsersResults;
        private System.Windows.Forms.ComboBox cmbxSerachUsers;
        private System.Windows.Forms.Label lblSearchUsers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.DateTimePicker dtMessages;
        private System.Windows.Forms.TextBox txtMessageSearch;
        private System.Windows.Forms.Button btnSearchMessage;
    }
}