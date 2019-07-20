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
    public partial class PlayerMenu : Form
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

        public PlayerMenu()
        {
            InitializeComponent();
        }

        public PlayerMenu(string playerAccountName, string playerEmail, bool isItSignUp, bool useUserNameToLogin)
        {
            InitializeComponent();

            if (isItSignUp)
            {
                Player.PlayerMenu_SignUp playerMenu_SignUp = new Player.PlayerMenu_SignUp
                {
                    Owner = this
                };
                playerMenu_SignUp.ShowDialog();
                lblPlayerName.Text = PlayerDataBaseControl.playerName;
                PlayerDataBaseControl.Load();
                return;
            }

            // use User Name to Login
            if (useUserNameToLogin)
            {
                PlayerDataBaseControl.playerID = PlayerDataBaseControl.GetData_ByColumn("PlayerAccountName", playerAccountName, "PlayerID");
            }
            else
            {
                PlayerDataBaseControl.playerID = PlayerDataBaseControl.GetData_ByColumn("PlayerEmail", playerEmail, "PlayerID");
            }

            PlayerDataBaseControl.Load();

            lblPlayerName.Text = PlayerDataBaseControl.playerName;
        }

        public void RefreshPage()
        {
            lblPlayerName.Text = PlayerDataBaseControl.playerName;

            if (PlayerDataBaseControl.isEnglish)
            {
                lblWelcome.Text = "Welcome";
                btnHome.Text = "Home";
                btnProfile.Text = "Profile";
                btnGame.Text = "Game";
                btnPromotion.Text = "Promotion";
                btnPointCard.Text = "Point Card";
                btnSetting.Text = "Setting";
                btnLogout.Text = "Logout";
                btnReflectProblems.Text = "Reflect Problems";
            }
            else
            {
                lblWelcome.Text = "歡迎";
                btnHome.Text = "首頁";
                btnProfile.Text = "個人資料";
                btnGame.Text = "遊戲";
                btnPromotion.Text = "推廣";
                btnPointCard.Text = "點卡";
                btnSetting.Text = "設置";
                btnLogout.Text = "登出";
                btnReflectProblems.Text = "回報問題";
            }
        }

        private void PlayerMenu_Load(object sender, EventArgs e)
        {
            Player.PlayerHome playerHome = new Player.PlayerHome
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            playerHome.Show();

            currentForm = playerHome;
            currentPage = Page.Home;

            RefreshPage();

        }

        public enum Page
        {
            Home, Profile, Game, Promotion, PointCard, PointCard_inSide, Setting, ReflectProblems
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
                    newFormPage = new Player.PlayerHome();
                    break;
                case Page.Profile:
                    newFormPage = new Player.PlayerProfile();
                    break;
                case Page.Game:
                    newFormPage = new Player.PlayerGame();
                    break;
                case Page.Promotion:
                    newFormPage = new Player.PlayerPromotion();
                    break;
                case Page.PointCard:
                    newFormPage = new Player.PlayerPointCard();
                    break;
                case Page.PointCard_inSide:
                    newFormPage = new Player.PlayerPointCard_inSide();
                    break;
                case Page.Setting:
                    newFormPage = new Player.PlayerSetting();
                    break;
                case Page.ReflectProblems:
                    newFormPage = new Player.PlayerReflectProblems();
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
                case Page.Home:             btnHome.selected            = inBool;  break;
                case Page.Profile:          btnProfile.selected         = inBool;  break;
                case Page.Game:             btnGame.selected            = inBool;  break;
                case Page.Promotion:        btnPromotion.selected       = inBool;  break;
                case Page.PointCard:        btnPointCard.selected       = inBool;  break;
                case Page.PointCard_inSide: btnPointCard.selected       = inBool;  break;
                case Page.Setting:          btnSetting.selected         = inBool;  break;
                case Page.ReflectProblems:  btnReflectProblems.selected = inBool;  break;
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

        private void BtnGame_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Game);
        }

        private void BtnPromotion_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Promotion);
        }

        private void BtnPointCard_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.PointCard);
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.Setting);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PlayerDataBaseControl.playerID = "";
            StaffDataBaseControl.staffID = "";
            CSMDataBaseControl.CSMID = "";
            PointCardDataBaseControl.pointCardID = "";
            Close();
        }

        private void BtnReflectProblems_Click(object sender, EventArgs e)
        {
            ChangeMDIForm(Page.ReflectProblems);
        }


        #endregion

        
    }
}
