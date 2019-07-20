using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype.Player
{
    public partial class PlayerProfile : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerProfile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerProfile()
        {
            InitializeComponent();
        }

        private void PlayerProfile_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {

            if (PlayerDataBaseControl.isEnglish)
            {
                lblAccountName.Text = "Account Name:";
                lblName.Text = "Name:";
                btnChangeName.Text = "Change Name";
                lblPassword.Text = "Password";
                btnChangePassword.Text = "Change Password";
                lblEmail.Text = "Email";
                btnChangeEmail.Text = "Change Email";
                lblGoldCoins.Text = "Gold Coins";
                lblProfile.Text = "Profile:";
                btnChangeProfile.Text = "Change Profile";
                lblGameProgress.Text = "Game Progress:";
            }
            else
            {
                lblAccountName.Text = "用戶名：";
                lblName.Text = "名稱：";
                btnChangeName.Text = "更改名稱";
                lblPassword.Text = "密碼：";
                btnChangePassword.Text = "更改密碼";
                lblEmail.Text = "電子郵件：";
                btnChangeEmail.Text = "更改電郵";
                lblGoldCoins.Text = "金幣：";
                lblProfile.Text = "個人簡介：";
                btnChangeProfile.Text = "更改個人簡介";
                lblGameProgress.Text = "遊戲進度：";

            }

            lblPlayerIDOutput.Text = PlayerDataBaseControl.playerID;
            lblAccountNameOutput.Text = PlayerDataBaseControl.playerAccountName;
            lblNameOutput.Text = PlayerDataBaseControl.playerName;
            lblEmailOutput.Text = PlayerDataBaseControl.playerEmail;
            lblProfileOutput.Text = PlayerDataBaseControl.playerProfile;
            lblGoldCoinsOutput.Text = PlayerDataBaseControl.playerGoldCoins.ToString();

            string star = "";
            int length = PlayerDataBaseControl.playerPassword.Length;
            for (int i = 0; i < length; i++)
            {
                star += "*";
            }
            lblPasswordOutput.Text = star;


            lblGameProgressOutput.Text = "";
            if (PlayerDataBaseControl.isEnglish)
            {
                lblGameProgressOutput.Text += "GSD War Zone Game Process: ";
                lblGameProgressOutput.Text += DataBaseControl.GetData_OfGSDWarZoneTable("PlayerID", PlayerDataBaseControl.playerID, "GameProgress");
                lblGameProgressOutput.Text += "\n\nGSD F1 Race Game Process: ";
                lblGameProgressOutput.Text += DataBaseControl.GetData_OfGSDF1RaceTable("PlayerID", PlayerDataBaseControl.playerID, "GameProgress");
            }
            else
            {
                lblGameProgressOutput.Text += "GSD War Zone 遊戲進度: ";
                lblGameProgressOutput.Text += DataBaseControl.GetData_OfGSDWarZoneTable("PlayerID", PlayerDataBaseControl.playerID, "GameChineseProgress");
                lblGameProgressOutput.Text += "\n\nGSD F1 Race 遊戲進度: ";
                lblGameProgressOutput.Text += DataBaseControl.GetData_OfGSDF1RaceTable("PlayerID", PlayerDataBaseControl.playerID, "GameChineseProgress");
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Player.PlayerProfile_ChangePassword playerProfile_ChangePassword = new Player.PlayerProfile_ChangePassword();
            playerProfile_ChangePassword.ShowDialog();
            RefreshPage();
        }

        private void BtnChangeProfile_Click(object sender, EventArgs e)
        {
            Player.PlayerProfile_ChangeProfile playerProfile_ChangeProfile = new Player.PlayerProfile_ChangeProfile();
            playerProfile_ChangeProfile.ShowDialog();
            RefreshPage();
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            Player.PlayerProfile_ChangeName playerProfile_ChangeName = new Player.PlayerProfile_ChangeName();
            playerProfile_ChangeName.ShowDialog();
            RefreshPage();
            ((PlayerMenu)MdiParent).RefreshPage();
        }

        private void BtnChangeEmail_Click(object sender, EventArgs e)
        {
            Player.PlayerProfile_ChangeEmail playerProfile_ChangeEmail = new Player.PlayerProfile_ChangeEmail();
            playerProfile_ChangeEmail.ShowDialog();
            RefreshPage();
        }


    }
}
