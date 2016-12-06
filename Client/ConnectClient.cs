using Classes;
using ClientCommunication;
using System;
using System.Windows.Forms;


namespace Client
{
    public partial class frmConnect : Form
    {
        #region Variables

        private User _User;
        private frmChatClientSide _ClientChat;
        //private Communication _Communication;
        #endregion

        #region Constructor

        public frmConnect()
        {
            InitializeComponent();
            _User = new User();

            txtbxIpAddress.Text = Properties.Settings.Default.IP_ADDRESS;
            nmrcPort.Value = Properties.Settings.Default.PORT;

#if DEBUG
            txtbxNickName.Text = "Titi";
#endif
        }

        #endregion

        #region Methods

        private bool ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtbxIpAddress.Text))
            {
                MessageBox.Show("IP Address field must be filled");
                isValid = false;
            }
            else if (nmrcPort.Value == 0)
            {
                MessageBox.Show("Port field must be filled");
                isValid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name field must be filled");
                isValid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtbxNickName.Text))
            {
                MessageBox.Show("Nick Name field must be filled");
                isValid = false;
            }
            return isValid;
        }

        #endregion

        #region Event Handlers

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _User.UserColor = colorDialog1.Color;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool areFieldsValid = ValidateFields();
            if (areFieldsValid)
            {
                _User.Name = txtFullName.Text;
                _User.NickName = txtbxNickName.Text;                
                Hide();
                _ClientChat = new frmChatClientSide(_User, txtbxIpAddress.Text, (int)nmrcPort.Value);
                _ClientChat.UserNameExist += _ClientChat_UserNameExist;
                _ClientChat.Show();                      
            }
        }

        private void _ClientChat_UserNameExist()
        {
            Invoke((MethodInvoker)delegate
            {
                Show();
                MessageBox.Show("Nick Name taken. Choose new one!");
            });                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
