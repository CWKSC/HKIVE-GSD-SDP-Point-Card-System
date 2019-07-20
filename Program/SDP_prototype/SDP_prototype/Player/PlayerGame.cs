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
    public partial class PlayerGame : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerGame()
        {
            InitializeComponent();
        }

        #region Picture and Text Display

        private void PlayerGame_MouseEnter(object sender, EventArgs e)
        {
            lblWarZone.Visible = false;
            lblF1Race.Visible = false;

            WarZonePicture.Visible = true;
            F1RacePicture.Visible = true;
        }
        private void ComingSoon_MouseEnter(object sender, EventArgs e)
        {
            lblWarZone.Visible = false;
            lblF1Race.Visible = false;

            WarZonePicture.Visible = true;
            F1RacePicture.Visible = true;
        }

        private void WarZoneCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            WarZonePicture.Visible = false;
            lblWarZone.Visible = true;

            F1RacePicture.Visible = true;
            lblF1Race.Visible = false;
        }
        private void WarZonePicture_MouseEnter(object sender, EventArgs e)
        {
            WarZonePicture.Visible = false;
            lblWarZone.Visible = true;

            F1RacePicture.Visible = true;
            lblF1Race.Visible = false;
        }

        private void F1RaceCollisionDetection_MouseEnter(object sender, EventArgs e)
        {
            F1RacePicture.Visible = false;
            lblF1Race.Visible = true;

            WarZonePicture.Visible = true;
            lblWarZone.Visible = false;
        }
        private void F1RacePicture_MouseEnter(object sender, EventArgs e)
        {
            F1RacePicture.Visible = false;
            lblF1Race.Visible = true;

            WarZonePicture.Visible = true;
            lblWarZone.Visible = false;
        }

        #endregion

        private void BtnGo_Click(object sender, EventArgs e)
        {

            if(txtGameName.Text == "")
            {
                MessageBox.Show("Game Name should not be empty.");
                return;
            }

            if (!DataBaseControl.MatchingOneColumn_OfTable("Game", "GameName", txtGameName.Text))
            {
                MessageBox.Show("This Game is not exist.");
                return;
            }

            string gameDetail;
            if (PlayerDataBaseControl.isEnglish)
            {
                gameDetail = DataBaseControl.GetData_OfGameTable("GameName", txtGameName.Text, "GameDescription");
            }
            else
            {
                gameDetail = DataBaseControl.GetData_OfGameTable("GameName", txtGameName.Text, "GameChineseDescription");
            }

            

            MessageBox.Show(gameDetail, "Game Detail Of " + txtGameName.Text);
        }

        private void PlayerGame_Load(object sender, EventArgs e)
        {
            if (PlayerDataBaseControl.isEnglish)
            {
                lblGameName.Text = "Search the Game Detail By Name :";
            }
            else
            {
                lblGameName.Text = "按名稱搜索遊戲細節：";
            }
        }
    }
}
