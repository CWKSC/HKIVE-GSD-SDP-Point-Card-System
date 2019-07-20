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
    public partial class PlayerPointCard : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerPointCardInformation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerPointCard()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(txtPointCardID.Text == "")
            {
                MessageBox.Show("Point Card ID should not be empty.");
                return;
            }

            if(!DataBaseControl.MatchingOneColumn_OfTable("PointCard", "PointCardID", txtPointCardID.Text))
            {
                MessageBox.Show("Point Card ID does not exist.");
                return;
            }

            PointCardDataBaseControl.pointCardID = txtPointCardID.Text;

            btnEnter.Enabled = false;
            ((PlayerMenu)MdiParent).ChangeMDIForm_callByOtherForm(PlayerMenu.Page.PointCard_inSide);
        }

        private void PlayerPointCard_Load(object sender, EventArgs e)
        {
            if (PlayerDataBaseControl.isEnglish)
            {
                lblPointCardID.Text = "Point Card ID:";
                btnEnter.Text = "Enter";
            }
            else
            {
                lblPointCardID.Text = "點卡 ID:";
                btnEnter.Text = "輸入";
            }
        }

    }
}
