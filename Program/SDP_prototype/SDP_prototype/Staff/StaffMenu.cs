using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype
{
    public partial class StaffMenu : Form
    {

        #region it make Draggable Code
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LeftGradientPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public StaffMenu()
        {
            InitializeComponent();
        }

        public StaffMenu(string staffAccount, string staffEmail, bool useUserNameToLogin)
        {
            InitializeComponent();

            // use User Name to Login
            if (useUserNameToLogin)
            {
                StaffDataBaseControl.staffID = StaffDataBaseControl.GetData_ByColumn("StaffAccountName", staffAccount, "StaffID");
            }
            else
            {
                StaffDataBaseControl.staffID = StaffDataBaseControl.GetData_ByColumn("StaffEmail", staffEmail, "StaffID");
            }

            StaffDataBaseControl.Load();

            lblPlayerName.Text = StaffDataBaseControl.staffName;
        }


        public void RefreshPage()
        {
            lblPlayerName.Text = StaffDataBaseControl.staffName;

            if (StaffDataBaseControl.isEnglish)
            {
                lblWelcome.Text = "Welcome";
                btnHome.Text = "Home";
                btnProfile.Text = "Profile";
                btnPlayerAccount.Text = "Player Account";
                btnPointCard.Text = "Point Card";
                btnReceiveProblems.Text = "Receive Problems";
                btnLogout.Text = "Logout";
                btnSetting.Text = "Setting";
            }
            else
            {
                lblWelcome.Text = "歡迎";
                btnHome.Text = "首頁";
                btnProfile.Text = "個人資料";
                btnPlayerAccount.Text = "玩家帳戶";
                btnPointCard.Text = "點卡";
                btnReceiveProblems.Text = "問題反饋";
                btnLogout.Text = "登出";
                btnSetting.Text = "設置";
            }
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
            Staff.StaffHome staffHome = new Staff.StaffHome
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            staffHome.Show();

            currentForm = staffHome;
            currentPage = Page.Home;

            RefreshPage();

        }

        public enum Page
        {
            Home, Profile, PlayerAccount, PlayerAccount_inSide, PointCard, PointCard_inSide, ReceiveProblems, Setting
        }

        #region Exit Button

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Button click and change the Page 

        Form currentForm;
        Page currentPage;

        public void ChangeMDIForm(Page page)
        {
            if (currentPage == page) return;

            //currentForm.Close();
            currentForm.Dispose();

            Form newFormPage;
            switch (page)
            {
                case Page.Home:
                    newFormPage = new Staff.StaffHome();
                    break;
                case Page.Profile:
                    newFormPage = new Staff.StaffProfile();
                    break;
                case Page.PlayerAccount:
                    newFormPage = new Staff.StaffPlayerAccount();
                    break;
                case Page.PlayerAccount_inSide:
                    newFormPage = new Staff.StaffPlayerAccount_inSide();
                    break;
                case Page.PointCard:
                    newFormPage = new Staff.StaffPointCard();
                    break;
                case Page.PointCard_inSide:
                    newFormPage = new Staff.StaffPointCard_inSide();
                    break;
                case Page.ReceiveProblems:
                    newFormPage = new Staff.StaffReceiveProblems();
                    break;
                case Page.Setting:
                    newFormPage = new Staff.StaffSetting();
                    break;
                default:
                    MessageBox.Show("Unexpect switch flow.");
                    return;
            }

            newFormPage.MdiParent = this;
            newFormPage.Dock = DockStyle.Fill;
            newFormPage.Show();

            currentForm = newFormPage;
            currentPage = page;

        }

        private void ChangeMenuButtonSelected(Page page, bool inBool)
        {
            switch (page)
            {
                case Page.Home:                 btnHome.selected            = inBool;  break;
                case Page.Profile:              btnProfile.selected         = inBool;  break;
                case Page.PlayerAccount:        btnPlayerAccount.selected   = inBool;  break;
                case Page.PlayerAccount_inSide: btnPlayerAccount.selected   = inBool;  break;
                case Page.PointCard:            btnPointCard.selected       = inBool;  break;
                case Page.PointCard_inSide:     btnPointCard.selected       = inBool;  break;
                case Page.ReceiveProblems:      btnReceiveProblems.selected = inBool;  break;
                case Page.Setting:              btnSetting.selected         = inBool;  break;
            }
        }

        public void ChangeMDIForm_callByOtherForm(Page page)
        {
            ChangeMenuButtonSelected(currentPage, false);
            ChangeMenuButtonSelected(page, true);

            ChangeMDIForm(page);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Home);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Profile);
        }

        private void BtnPlayerAccount_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.PlayerAccount);
        }

        private void BtnPointCard_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.PointCard);
        }

        private void BtnReceiveProblems_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.ReceiveProblems);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PlayerDataBaseControl.playerID = "";
            StaffDataBaseControl.staffID = "";
            CSMDataBaseControl.CSMID = "";
            PointCardDataBaseControl.pointCardID = "";
            Close();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Setting);
        }

        #endregion

        
    }
}
