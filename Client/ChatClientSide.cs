using Classes;
using ClientCommunication;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class frmChatClientSide : Form
    {
        #region Variables

        //*** API for terminating progress:
        [DllImport("kernel32.dll")]
        private static extern void ExitProcess(int a);

        private Communication _CommManager;
        private readonly User _ActiveUser;
        private string _IPAdress;
        private int _Port;

        #endregion

        #region Constructor

        public frmChatClientSide(User user, string ipAdress, int port)
        {
            InitializeComponent();

            _ActiveUser = user;
            _IPAdress = ipAdress;
            _Port = port;

            Thread openCommunicationThread = new Thread(OpenCommunication);
            openCommunicationThread.Start();
        }

        #endregion

        #region Methods

        private void OpenCommunication()
        {
            _CommManager = new Communication(_ActiveUser, _IPAdress, _Port);
            _CommManager.MessageReceived += _Client_MessageReceived;
            _CommManager.UsersInit += _Client_UsersInit;
            _CommManager.NewUserAdded += _Client_NewUserAdded;
            _CommManager.UserRemoved += _Client_UserRemoved;
            _CommManager.ConnectionStoped += _Client_ConnectionStoped;
            _CommManager.UserNameExist += _CommManager_UserNameExist;
            _CommManager.Init();
        }

        #endregion

        #region Event Handlers

        private void _CommManager_UserNameExist()
        {
            Invoke((MethodInvoker)delegate
            {
                Hide();
            });
            OnUserNameExist();
        }

        private void _Client_ConnectionStoped()
        {
            MessageBox.Show("The connection has stoped. SORRY...", "ERROR");
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text.Length > 0)
            {
                List<User> selectedUsers = new List<User>();
                foreach (User user in chkbxlstUsers.CheckedItems)
                {
                    selectedUsers.Add(user);
                }
                _CommManager.SendMessage(txtMsg.Text, selectedUsers);
                txtMsg.Text = "";
            }
        }

        private void frmChatClientSide_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            ExitProcess(0);
            ActiveForm.Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _CommManager.ActiveUser.UserColor = colorDialog1.Color;
            }
        }

        private void _Client_UserRemoved(User user, string message)
        {
            Invoke((MethodInvoker)delegate
            {
                txtbxMessages.SelectedText += message + "\r\n";
                txtbxMessages.ScrollToCaret();
                int index = -1;
                for (int i = 0; i < chkbxlstUsers.Items.Count; i++)
                {
                    if (((User)chkbxlstUsers.Items[i]).Id == user.Id)
                    {
                        index = i;
                        break;
                    }
                }
                chkbxlstUsers.Items.RemoveAt(index);
            });
        }

        private void _Client_NewUserAdded(User user)
        {
            Invoke((MethodInvoker)delegate
            {
                chkbxlstUsers.Items.Add(user);
            });
        }

        private void _Client_UsersInit(List<User> usersList)
        {
            Invoke((MethodInvoker)delegate
            {
                foreach (var item in usersList)
                {
                    if (item.Id == _CommManager.ActiveUser.Id)
                    {
                        item.NickName += " (You)";
                    }
                    chkbxlstUsers.Items.Add(item);
                }
            });
        }

        private void chkbxlstUsers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chkbxlstUsers.Items == null
                || chkbxlstUsers.Items.Count == 0 || e.Index < 0)
            {
                return;
            }

            User user = chkbxlstUsers.Items[e.Index] as User;
            if (user == null) return;

            if (user.Id == _CommManager.ActiveUser.Id)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void _Client_MessageReceived(string message, Color color, bool? isExists)
        {
            string text = message + "\r\n";
            Invoke((MethodInvoker)delegate
            {
                txtbxMessages.SelectionColor = color;
                txtbxMessages.SelectedText += text;
                txtbxMessages.ScrollToCaret();
                if (isExists == true)
                {
                    MessageBox.Show("WELCOME BACK TO CHAT !!");
                }
                else if (isExists == false)
                {
                    MessageBox.Show("WELCOME TO CHAT !!");
                }
            });
        }

        #endregion

        #region events

        public delegate void UserNameExistDelegate();
        public event UserNameExistDelegate UserNameExist;
        private void OnUserNameExist()
        {
            if (UserNameExist == null) return;
            UserNameExist.Invoke();
        }

        #endregion
    }
}