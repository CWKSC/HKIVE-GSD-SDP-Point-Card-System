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
    public partial class PlayerPointCard_inSide : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerPointCard_inSide_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerPointCard_inSide()
        {
            InitializeComponent();
        }

        private void RefreshPage()
        {
            PointCardDataBaseControl.Load();

            lblPointCardIDOutput.Text          = PointCardDataBaseControl.pointCardID;
            lblRetailValueOutput.Text          = PointCardDataBaseControl.retailValue.ToString();
            lblStatusOutput.Text               = PointCardDataBaseControl.status;
            lblGenerationDateOutput.Text       = PointCardDataBaseControl.generationDate;
            lblGoldCoinsOutput.Text            = PointCardDataBaseControl.goldCoins.ToString();
            lblRemainLuckyDrawTimesOutput.Text = PointCardDataBaseControl.remainLuckyDrawTimes.ToString();
        }

        private void PlayerPointCard_inSide_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void BtnPlayLuckyDrawMiniGame_Click(object sender, EventArgs e)
        {
            if (PointCardDataBaseControl.status != "Actived")
            {
                MessageBox.Show("Point Card need to be Actived before.");
                return;
            }

            if (PointCardDataBaseControl.remainLuckyDrawTimes == 0)
            {
                MessageBox.Show("Remain Lucky Draw Times is 0.");
                return;
            }

            Player.PlayerPointCard_LuckyDraw playerPointCard_LuckyDraw = new PlayerPointCard_LuckyDraw();
            playerPointCard_LuckyDraw.ShowDialog();

            RefreshPage();
        }

        int tryTimes = 0;

        private void BtnTopUp_Click(object sender, EventArgs e)
        {

            if (PointCardDataBaseControl.status != "Actived")
            {
                tryTimes++;

                if (tryTimes == 4)
                {
                    PointCardDataBaseControl.Updata_Status("Suspended");
                    MessageBox.Show("Too many password attempts, the point card has been frozen (Suspended).");
                    RefreshPage();
                    return;
                }
            }

            if(txtActivePassword.Text == "")
            {
                MessageBox.Show("Active Password can not be empty.");
                return;
            }

            if (!DataBaseControl.MatchingPointCardIDActivePwd_InPointCardTable(PointCardDataBaseControl.pointCardID, txtActivePassword.Text))
            {
                MessageBox.Show("Active Password is Incorrect.");
                return;
            }

            if (PointCardDataBaseControl.status == "Actived")
            {
                MessageBox.Show("It Point Card have been Actived.");
                return;
            }

            if (PointCardDataBaseControl.status == "Suspended")
            {
                MessageBox.Show("It Point Card is Suspended, please contact the staff.");
                return;
            }

            int newGoldCoins = PlayerDataBaseControl.playerGoldCoins + PointCardDataBaseControl.goldCoins;
            PlayerDataBaseControl.Updata_PlayerGoldCoins(newGoldCoins);

            PointCardDataBaseControl.Updata_Status("Actived");

            TopUpHistoryDataBaseControl.topUpDate = DateTime.Now.ToString("dd/MM/yyyy");
            TopUpHistoryDataBaseControl.Insert();

            MessageBox.Show("Top Up success.");

            txtActivePassword.Text = "";

            RefreshPage();
        }
    }
}
