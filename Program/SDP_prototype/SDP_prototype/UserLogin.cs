using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace SDP_prototype
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
        }

        public DataTable dt = new DataTable();

        public enum User
        {
            Player, Staff, CustomerServiceManager, Quit
        }

        public User user = User.Quit;

        public string userAccountName;
        public string userEmail;


        #region Top SignUp SignIn Button

        public bool isItSignUp = true;

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            isItSignUp = true;

            // Bar
            bar.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y + 49);

            // Sign
            lblSignUpForFree.Visible = true;

            // Sign btn
            btnSign.Text = "Sign Up";

            // User Name field
            lblUserAccountName.Visible = true;
            txtUserAccountName.Visible = true;
            lblUseNameOrEmailLogin.Visible = false;
            lblUserAccountName.Location = new Point(79, 210);
            txtUserAccountName.Location = new Point(83, 237);

            // Email field
            lblEmail.Visible = true;
            lblEmailCanBeEmpty.Visible = true;
            txtEmail.Visible = true;
            lblEmail.Location = new Point(79, 295);
            txtEmail.Location = new Point(83, 321);
            lblEmailCanBeEmpty.Location = new Point(134, 295);

            // Password field
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblForgotPassword.Visible = false;
            lblPassword.Location = new Point(79, 382);
            txtPassword.Location = new Point(83, 407);
            
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            isItSignUp = false;

            // Bar
            bar.Location = new Point(btnSignIn.Location.X, btnSignIn.Location.Y + 49);

            // Sign
            lblSignUpForFree.Visible = false;

            // Sign byn
            btnSign.Text = "Sign In";

            if (useUserNameToLogin)
            {
                // User Name field
                lblUserAccountName.Visible = true;
                txtUserAccountName.Visible = true;
                lblUserAccountName.Location = new Point(79, 210 - 10);
                txtUserAccountName.Location = new Point(83, 237 - 10);

                // Email field
                lblEmail.Visible = false;
                txtEmail.Visible = false;
            }
            else
            {
                // User Name field
                lblUserAccountName.Visible = false;
                txtUserAccountName.Visible = false;

                // Email field
                lblEmail.Visible = true;
                txtEmail.Visible = true;
                lblEmail.Location = new Point(79, 210 - 10);
                txtEmail.Location = new Point(83, 237 - 10);

            }

            // Email can be empty Text 
            lblEmailCanBeEmpty.Visible = false;

            // Use Name Or Email to Login text
            lblUseNameOrEmailLogin.Location = new Point(271, 214 - 10);
            lblUseNameOrEmailLogin.Visible = true;

            // Password field
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblForgotPassword.Visible = true;
            lblPassword.Location = new Point(79, 382 - 60);
            txtPassword.Location = new Point(83, 407 - 60);
            lblForgotPassword.Location = new Point(282, 383 - 60);
            
        }

        #endregion


        #region Use UserName Or Email ToLogin

        public bool useUserNameToLogin = true;

        private void LblUseNameOrEmailLogin_Click(object sender, EventArgs e)
        {
            if (useUserNameToLogin)
            {
                // Use Name Or Email to Login text
                lblUseNameOrEmailLogin.Text = "Use name to login ?";

                // User Name field
                lblUserAccountName.Visible = false;
                txtUserAccountName.Visible = false;

                //Email field
                lblEmail.Visible = true;
                txtEmail.Visible = true;
                lblEmail.Location = new Point(79, 210 - 10);
                txtEmail.Location = new Point(83, 237 - 10);
            }
            else
            {
                // Use Name Or Email to Login text
                lblUseNameOrEmailLogin.Text = "Use email to login ?";

                // User Name field
                lblUserAccountName.Visible = true;
                txtUserAccountName.Visible = true;
                lblUserAccountName.Location = new Point(79, 210 - 10);
                txtUserAccountName.Location = new Point(83, 237 - 10);

                // Email field
                lblEmail.Visible = false;
                txtEmail.Visible = false;
            }

            // reverse bool
            useUserNameToLogin = !useUserNameToLogin;
        }

        #endregion


        private void CleanUpTextBox()
        {
            txtUserAccountName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }


        #region Sign Button

        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (isItSignUp)
            {
                SignUp();
            }
            else
            {
                SignIn();
            }
        }

        #region SignUp

        private void SignUp()
        {
            if(txtUserAccountName.Text == "")
            {
                MessageBox.Show("User Account Name should not be empty.");
                return;
            }

            if(txtPassword.Text == "")
            {
                MessageBox.Show("User Account Name should not be empty.");
                return;
            }

            bool anyError = false;
            if (!FormatChecking.UserName(txtUserAccountName.Text)) anyError = true;
            if (!FormatChecking.Password(txtPassword.Text)) anyError = true;

            if (anyError)
            {
                CleanUpTextBox();
                return;
            }

            if (DataBaseControl.MatchingAccountName_OfAllTable(txtUserAccountName.Text))
            {
                MessageBox.Show("Sorry, the User Account Name has been used.");
                return;
            }

            if (txtEmail.Text != "" && PlayerDataBaseControl.MatchingEmail(txtEmail.Text))
            {
                MessageBox.Show("Sorry, the Email has been used.");
                return;
            }

            

            PlayerDataBaseControl.Insert(txtUserAccountName.Text,
                                         txtPassword.Text,
                                         txtEmail.Text);


            userAccountName = txtUserAccountName.Text;
            userEmail = txtEmail.Text;

            PlayerDataBaseControl.playerAccountName = userAccountName;
            PlayerDataBaseControl.Load_PlayerID_By_PlayerAccountName();

            user = User.Player;
            Close();
        }

        #endregion

        #region SignIn

        private void SignIn()
        {

            if (useUserNameToLogin)
            {
                SignIn_useUserNameToLogin();
            }
            else
            {
                SignIn_useEmailToLogin();
            }

        }

        #region SignIn By Account Name and Password

        private User LoginByAccountNameAndPassword(string accountName, string password)
        {
            if (PlayerDataBaseControl.MatchingAccountPassword(accountName, password))
                return User.Player;
            if (DataBaseControl.MatchingAccountPassword_InStaffTable(accountName, password))
                return User.Staff;
            if (DataBaseControl.MatchingAccountPassword_InCSMTable(accountName, password))
                return User.CustomerServiceManager;

            return User.Quit;
        }

        private void SignIn_useUserNameToLogin()
        {

            bool anyError = false;
            if (!FormatChecking.UserName(txtUserAccountName.Text)) anyError = true;
            if (!FormatChecking.Password(txtPassword.Text)) anyError = true;
            if (anyError) return;

            if (!DataBaseControl.MatchingAccountName_OfAllTable(txtUserAccountName.Text))
            {
                MessageBox.Show("User Account Name does not exist.");
                return;
            }

            user = LoginByAccountNameAndPassword(txtUserAccountName.Text, txtPassword.Text);

            if(user == User.Quit)
            {
                MessageBox.Show("User Account Name or Password is wrong.");
                return;
            }

            userAccountName = txtUserAccountName.Text;
            userEmail = txtEmail.Text;

            Close();
        }

        #endregion

        #region SignIn By Email and Password

        private User LoginByEmailAndPassword(string email, string password)
        {
            if (PlayerDataBaseControl.MatchingEmailPassword(email, password))
                return User.Player;
            if (DataBaseControl.MatchingEmailPassword_InStaffTable(email, password))
                return User.Staff;
            if (DataBaseControl.MatchingEmailPassword_InCSMTable(email, password))
                return User.CustomerServiceManager;

            return User.Quit;
        }

        private void SignIn_useEmailToLogin()
        {
            if(txtEmail.Text == "")
            {
                MessageBox.Show("Email field can not be empty.");
                return;
            }

            if (!FormatChecking.Password(txtPassword.Text)) return;


            if (!DataBaseControl.MatchingEmail_OfAllTable(txtEmail.Text))
            {
                MessageBox.Show("Email does not exist");
                return;
            }

            user = LoginByEmailAndPassword(txtEmail.Text, txtPassword.Text);

            if (user == User.Quit)
            {
                MessageBox.Show("Email or Password is wrong.");
                return;
            }

            userEmail = txtEmail.Text;

            Close();
        }

        #endregion

        #endregion

        #endregion


        #region Exit Button

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region it make Draggable Code
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void GradientPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // It use to make it draggable. //
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            txtUserAccountName.Text = "TestPlayer";
            txtEmail.Text = "Test@Player.com";
            txtPassword.Text = "TestPlayer";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtUserAccountName.Text = "TestStaff";
            txtEmail.Text = "Test@Staff.com";
            txtPassword.Text = "TestStaff";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtUserAccountName.Text = "TestCSM";
            txtEmail.Text = "Test@CSM.com";
            txtPassword.Text = "TestCSM";
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please look at your Email and see your password.");
        }
    }
}
