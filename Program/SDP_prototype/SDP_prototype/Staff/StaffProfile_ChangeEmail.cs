using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype.Staff
{
    public partial class StaffProfile_ChangeEmail : Form
    {
        #region it make Draggable Code
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerProfile_ChangeEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // It use to make it draggable. //
        #endregion

        public StaffProfile_ChangeEmail()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnChangeEmail_Click(object sender, EventArgs e)
        {
            StaffDataBaseControl.Updata_StaffEmail(txtNewEmail.Text);
            Close();
        }

        private void PlayerProfile_ChangeEmail_Load(object sender, EventArgs e)
        {
            txtNewEmail.Text = StaffDataBaseControl.staffEmail;
        }
    }
}
