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
    public partial class PlayerHome : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion


        public PlayerHome()
        {
            InitializeComponent();
        }


        #region Icon and Text Display

        private void PlayerHome_MouseEnter(object sender, EventArgs e)
        {
            // Game Icon
            GameIcon.Visible = true;
            btnGame.Visible = false;

            // Promotion Icon 
            PromotionIcon.Visible = true;
            btnPromotion.Visible = false;

            // Profile Icon
            ProfileIcon.Visible = true;
            btnProfile.Visible = false;

            // Top Up Icon
            TopUpIcon.Visible = true;
            btnTopUp.Visible = false;

            // Point Card Icon
            PointCardIcon.Visible = true;
            btnPointCardInformation.Visible = false;

            // Setting Icon
            SettingIcon.Visible = true;
            btnSetting.Visible = false;

            // Problem Icon
            ProblemIcon.Visible = true;
            btnReflectProblems.Visible = false;
        }


        // Game Icon //
        private void GameIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            GameIcon.Visible = false;
            btnGame.Visible = true;
        }
        private void GameIcon_MouseEnter(object sender, EventArgs e)
        {
            GameIcon.Visible = false;
            btnGame.Visible = true;
        }

        
        // Promotion Icon //
        private void PromotionIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            PromotionIcon.Visible = false;
            btnPromotion.Visible = true;
        }
        private void PromotionIcon_MouseEnter(object sender, EventArgs e)
        {
            PromotionIcon.Visible = false;
            btnPromotion.Visible = true;
        }

        // Profile Icon //
        private void ProfileIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            ProfileIcon.Visible = false;
            btnProfile.Visible = true;
        }
        private void ProfileIcon_MouseEnter(object sender, EventArgs e)
        {
            ProfileIcon.Visible = false;
            btnProfile.Visible = true;
        }

        // Top Up Icon //
        private void TopUpIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            TopUpIcon.Visible = false;
            btnTopUp.Visible = true;
        }
        private void TopUpIcon_MouseEnter(object sender, EventArgs e)
        {
            TopUpIcon.Visible = false;
            btnTopUp.Visible = true;
        }

        // Point Card Icon //
        private void PointCardIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            PointCardIcon.Visible = false;
            btnPointCardInformation.Visible = true;
        }
        private void PointCardIcon_MouseEnter(object sender, EventArgs e)
        {
            PointCardIcon.Visible = false;
            btnPointCardInformation.Visible = true;
        }

        // Setting Icon //
        private void SettingIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            SettingIcon.Visible = false;
            btnSetting.Visible = true;
        }
        private void SettingIcon_MouseEnter(object sender, EventArgs e)
        {
            SettingIcon.Visible = false;
            btnSetting.Visible = true;
        }

        // Problem Icon //
        private void ProblemIconCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            ProblemIcon.Visible = false;
            btnReflectProblems.Visible = true;
        }
        private void ProblemIcon_MouseEnter(object sender, EventArgs e)
        {
            ProblemIcon.Visible = false;
            btnReflectProblems.Visible = true;
        }

        #endregion


        #region Button Click and change Mdi Menu Form

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.Profile);
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            btnGame.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.Game);
        }

        private void BtnPromotion_Click(object sender, EventArgs e)
        {
            btnPromotion.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.Promotion);
        }

        private void BtnTopUp_Click(object sender, EventArgs e)
        {
            btnTopUp.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.PointCard);
        }

        private void BtnPointCardInformation_Click(object sender, EventArgs e)
        {
            btnPointCardInformation.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.PointCard);
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            btnSetting.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.Setting);
        }

        private void BtnReflectProblems_Click(object sender, EventArgs e)
        {
            btnReflectProblems.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.ReflectProblems);
        }

        #endregion

        private void PlayerHome_Load(object sender, EventArgs e)
        {
            if (PlayerDataBaseControl.isEnglish)
            {
                lblWhatDoYouWantToDo.Text = "What do you want to do ?";
            }
            else
            {
                lblWhatDoYouWantToDo.Text = "你想做什麼？";
            }
        }
    }
}
