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
    public partial class PlayerReflectProblems : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerReflectProblems_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerReflectProblems()
        {
            InitializeComponent();
        }

        private void PlayerReflectProblems_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text == "")
            {
                MessageBox.Show("Title can not be empty.");
                return;
            }

            if(txtDetail.Text == "")
            {
                MessageBox.Show("Detail can not be empty.");
                return;
            }

            ProblemReportDataBaseControl.title = txtTitle.Text;
            ProblemReportDataBaseControl.detail = txtDetail.Text;

            ProblemReportDataBaseControl.Insert();
            SystemDataBaseControl.Updata_ProblemReportNum_PlusOne();

            MessageBox.Show("Send Problem Report success.");
            txtTitle.Text = "";
            txtDetail.Text = "";

        }
    }
}
