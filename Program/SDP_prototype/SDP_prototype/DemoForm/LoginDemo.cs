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
    public partial class LoginDemo : Form
    {
        public LoginDemo()
        {
            InitializeComponent();
        }

        /*
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        */


        private void PlayerLogin_Load(object sender, EventArgs e)
        {
            slideA.Left = 49;
            slideB.Left = 49;
            slideB.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            btnSignUp.IdleFillColor = Color.FromArgb(26, 177, 136);
            btnSignUp.IdleLineColor = Color.FromArgb(26, 177, 136);
            btnSignIn.IdleFillColor = Color.FromArgb(36, 49, 60);
            btnSignIn.IdleLineColor = Color.FromArgb(36, 49, 60);
            slideB.Visible = false;
            slideA.Visible = true;
            slideA.Refresh();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnSignUp.IdleFillColor = Color.FromArgb(36, 49, 60);
            btnSignUp.IdleLineColor = Color.FromArgb(36, 49, 60);
            btnSignIn.IdleFillColor = Color.FromArgb(26, 177, 136);
            btnSignIn.IdleLineColor = Color.FromArgb(26, 177, 136);
            slideA.Visible = false;
            slideB.Visible = true;
            slideB.Refresh();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
