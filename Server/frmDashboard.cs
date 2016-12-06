using System;
using System.Threading;
using System.Windows.Forms;
using Classes;
using ChatServer;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    public partial class frmDashboard : Form
    {
        #region Variables

        private Chat _Server;
        private Thread _OpenCommunicationThread;
        private List<User> users;
        private List<Classes.Message> messages;

        #endregion

        #region Constructor

        public frmDashboard()
        {
            InitializeComponent();

            lstClientsHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstClientsConnected.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstMessages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            _OpenCommunicationThread = new Thread(OpenCommunication);
            _OpenCommunicationThread.Start();
        }

        #endregion

        #region Methods

        private void OpenCommunication()
        {
            _Server = new Chat();
            _Server.UserAdded += _Server_UserAdded;
            _Server.UserDisconnected += _Server_UserDisconnected;
            _Server.Init();
        }

        private void UpdateConnectedList(User user)
        {
            for (int i = 0; i < lstClientsConnected.Items.Count; i++)
            {
                if (lstClientsConnected.Items[i].Text == user.Id.ToString())
                {
                    lstClientsConnected.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void UpdateHistory(User user)
        {
            ListViewItem historyViewItem = new ListViewItem();
            historyViewItem.Text = user.Id.ToString();
            historyViewItem.SubItems.Add(user.NickName);
            historyViewItem.SubItems.Add("DISCONNECTED");
            historyViewItem.SubItems.Add(DateTime.Now.ToShortTimeString());
            lstClientsHistory.Items.Add(historyViewItem);
        }

        private void GetUsersId(ComboBox cmbx)
        {
            cmbx.Items.Clear();
            foreach (var user in users)
            {
                cmbx.Items.Add(user.Id + " - " + user.NickName);
            }
        }

        private void GetUsersName()
        {
            cmbxUsersResults.Items.Clear();
            foreach (var user in users)
            {
                cmbxUsersResults.Items.Add(user.NickName);
            }
        }

        private void ShowAllUsers()
        {
            lstMessages.Visible = false;
            cmbxUsersResults.Visible = false;
            lstUsers.Items.Clear();
            foreach (var user in users)
            {
                ShowUserSearch(user);
            }
            lstUsers.Visible = true;
        }

        private void ShowUserSearch(User user)
        {
            ListViewItem userViewItem = new ListViewItem();
            userViewItem.Text = user.Id.ToString();
            userViewItem.SubItems.Add(user.Name);
            userViewItem.SubItems.Add(user.NickName);
            userViewItem.SubItems.Add(user.Status);
            lstUsers.Items.Add(userViewItem);
        }

        private void ShowAllMessages()
        {
            lstUsers.Visible = false;
            cmbxMessagesResults.Visible = false;
            lstMessages.Items.Clear();
            foreach (var message in messages)
            {
                AddMessageSearch(message);
            }
            lstMessages.Visible = true;
        }

        private void AddMessageSearch(Classes.Message message)
        {
            ListViewItem messageViewItem = new ListViewItem();
            messageViewItem.Text = message.UserName;
            messageViewItem.SubItems.Add(message.MessageText);
            messageViewItem.SubItems.Add(message.RecipientName);
            messageViewItem.SubItems.Add(message.SentDate.ToString("dd/MM/yy"));
            lstMessages.Items.Add(messageViewItem);
        }

        #endregion

        #region Event Handlers

        private void _Server_UserDisconnected(User user)
        {
            Invoke(new Action(() =>
            {
                UpdateHistory(user);
                UpdateConnectedList(user);
            }));
        }

        private void _Server_UserAdded(User user)
        {
            Invoke(new Action(() =>
            {
                ListViewItem userViewItem = new ListViewItem();
                userViewItem.Text = user.Id.ToString();
                userViewItem.SubItems.Add(user.NickName);
                userViewItem.SubItems.Add("Connected");
                userViewItem.SubItems.Add(DateTime.Now.ToShortTimeString());
                lstClientsConnected.Items.Add(userViewItem);
            }));
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _OpenCommunicationThread.Abort();
            Environment.Exit(1);
        }

        private void cmbxSerachUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearchMessage.Visible = false;
            txtMessageSearch.Visible = false;
            dtMessages.Visible = false;
            cmbxMessagesResults.Visible = false;
            users = _Server.GetUsers();
            if (cmbxSerachUsers.SelectedItem.ToString().Contains("All"))
            {
                ShowAllUsers();
            }
            else
            {
                if (cmbxSerachUsers.SelectedItem.ToString().Contains("name"))
                {
                    GetUsersName();
                }
                else
                {
                    GetUsersId(cmbxUsersResults);
                }
                cmbxUsersResults.Visible = true;
            }
        }

        private void cmbxUsersResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMessages.Visible = false;
            lstUsers.Items.Clear();
            User user;
            if (cmbxSerachUsers.SelectedItem.ToString().Contains("name"))
            {
                user = users.FirstOrDefault
                    (item => item.NickName == cmbxUsersResults.SelectedItem.ToString());
            }
            else
            {
                string selected = cmbxUsersResults.SelectedItem.ToString();
                string id = selected.Substring(0, selected.IndexOf(" "));
                user = users.FirstOrDefault
                    (item => item.Id.ToString() == id);
            }
            ShowUserSearch(user);
            lstUsers.Visible = true;
        }

        private void cmbxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtMessages.Visible = false;
            btnSearchMessage.Visible = false;
            txtMessageSearch.Visible = false;
            cmbxUsersResults.Visible = false;
            users = _Server.GetUsers();
            messages = _Server.GetMessages();
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[0])
            {
                ShowAllMessages();
            }
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[1])
            {
                txtMessageSearch.Visible = true;
                btnSearchMessage.Visible = true;
            }
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[2])
            {
                GetUsersId(cmbxMessagesResults);
                cmbxMessagesResults.Visible = true;
            }
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[3])
            {
                GetUsersId(cmbxMessagesResults);
                cmbxMessagesResults.Visible = true;
            }
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[4])
            {
                dtMessages.Visible = true;
                cmbxMessagesResults.Visible = false;
            }
        }

        private void cmbxMessagesResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            string selected = cmbxMessagesResults.SelectedItem.ToString();
            string userName = selected.Split(' ').Last();
            if (cmbxMessages.SelectedItem == cmbxMessages.Items[2])
            {
                var _messages = messages.Where(msg => msg.UserName == userName);
                foreach (var msg in _messages)
                {
                    AddMessageSearch(msg);
                }
            }
            else
            {
                var _messages = messages.Where(msg => msg.RecipientName == userName);
                foreach (var msg in _messages)
                {
                    AddMessageSearch(msg);
                }
            }
            lstMessages.Visible = true;
        }

        private void dtMessages_ValueChanged(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            var _messages = messages.Where(msg => msg.SentDate == dtMessages.Value.Date);
            foreach (var msg in _messages)
            {
                AddMessageSearch(msg);
            }
            lstMessages.Visible = true;
        }

        private void btnSearchMessage_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            string text = txtMessageSearch.Text.ToLower();
            var _messages = messages.Where(msg => msg.UserName.ToLower().Contains(text)
            || msg.MessageText.ToLower().Contains(text)
            || msg.RecipientName != null
            && msg.RecipientName.ToLower().Contains(text));
            foreach (var msg in _messages)
            {
                AddMessageSearch(msg);
            }
            lstMessages.Visible = true;
            txtMessageSearch.Text = "";
        }

        #endregion
    }
}