using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype.CSM
{
    public partial class CSMProfile : Form
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

        public CSMProfile()
        {
            InitializeComponent();
        }

        private void PlayerProfile_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {

            if (CSMDataBaseControl.isEnglish)
            {
                lblAccountName.Text = "Account Name:";
                lblName.Text = "Name:";
                btnChangeName.Text = "Change Name";
                lblPassword.Text = "Password";
                btnChangePassword.Text = "Change Password";
                lblEmail.Text = "Email";
                btnChangeEmail.Text = "Change Email";
                lblProfile.Text = "Profile:";
                btnChangeProfile.Text = "Change Profile";
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
                lblProfile.Text = "個人簡介：";
                btnChangeProfile.Text = "更改個人簡介";
            }

            lblPlayerIDOutput.Text = CSMDataBaseControl.CSMID;
            lblAccountNameOutput.Text = CSMDataBaseControl.CSMAccountName;
            lblNameOutput.Text = CSMDataBaseControl.CSMName;
            lblEmailOutput.Text = CSMDataBaseControl.CSMEmail;
            lblProfileOutput.Text = CSMDataBaseControl.CSMProfile;

            string star = "";
            int length = CSMDataBaseControl.CSMPassword.Length;
            for (int i = 0; i < length; i++)
            {
                star += "*";
            }
            lblPasswordOutput.Text = star;

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            CSM.CSMProfile_ChangePassword cSMProfile_ChangePassword = new CSM.CSMProfile_ChangePassword();
            cSMProfile_ChangePassword.ShowDialog();
            RefreshPage();
        }

        private void BtnChangeProfile_Click(object sender, EventArgs e)
        {
            CSM.CSMProfile_ChangeProfile cSMProfile_ChangeProfile = new CSM.CSMProfile_ChangeProfile();
            cSMProfile_ChangeProfile.ShowDialog();
            RefreshPage();
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            CSM.CSMProfile_ChangeName cSMProfile_ChangeName = new CSM.CSMProfile_ChangeName();
            cSMProfile_ChangeName.ShowDialog();
            RefreshPage();
            ((CSMMenu)MdiParent).RefreshPage();
        }

        private void BtnChangeEmail_Click(object sender, EventArgs e)
        {
            CSM.CSMProfile_ChangeEmail cSMProfile_ChangeEmail = new CSM.CSMProfile_ChangeEmail();
            cSMProfile_ChangeEmail.ShowDialog();
            RefreshPage();
        }


    }
}
