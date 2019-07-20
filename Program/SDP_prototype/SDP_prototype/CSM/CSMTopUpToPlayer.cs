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
    public partial class CSMTopUpToPlayer : Form
    {
        public CSMTopUpToPlayer()
        {
            InitializeComponent();
        }

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CSMTopUpToPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // It use to make it draggable. //
        #endregion

        private void TopUpToPlayer()
        {
            PlayerDataBaseControl.Load();

            PointCardDataBaseControl.pointCardID = txtPointCardID.Text;
            PointCardDataBaseControl.Load();

            int beforeGoldCoins = int.Parse(PlayerDataBaseControl.GetData("PlayerGoldCoins"));
            int newGoldCoins = beforeGoldCoins + PointCardDataBaseControl.goldCoins;
            PlayerDataBaseControl.Updata_PlayerGoldCoins(newGoldCoins);

            PointCardDataBaseControl.Updata_Status("Actived");

            TopUpHistoryDataBaseControl.topUpDate = DateTime.Now.ToString("dd/MM/yyyy");
            TopUpHistoryDataBaseControl.Insert();

            MessageBox.Show("Top " + txtPointCardID.Text + " to " + PlayerDataBaseControl.playerAccountName + "(" + PlayerDataBaseControl.playerID + ")" + " Success.\n" +
                "\n" +
                "The Point Card retail value is          " + PointCardDataBaseControl.retailValue + ".\n" +
                "The Point Card gold coins value is " + PointCardDataBaseControl.goldCoins + ".\n" +
                "\n" +
                "The PlayerGoldCoins of " + txtPlayerAccountName.Text + " from " + beforeGoldCoins + " to " + newGoldCoins + ".");

            txtPlayerID.Text = "";
            txtPlayerAccountName.Text = "";
            txtPointCardID.Text = "";
        }

        private void BtnPlayerIDEnter_Click(object sender, EventArgs e)
        {
            if (txtPlayerID.Text == "")
            {
                MessageBox.Show("Player ID can not be empty.");
                return;
            }
            if (!PlayerDataBaseControl.MatchingOneColumn("PlayerID", txtPlayerID.Text))
            {
                MessageBox.Show("Player ID does not exist.");
                return;
            }

            if (txtPointCardID.Text == "")
            {
                MessageBox.Show("Point Card ID can not be empty.");
                return;
            }
            if (!DataBaseControl.MatchingOneColumn_OfTable("PointCard", "PointCardID", txtPointCardID.Text))
            {
                MessageBox.Show("Point Card ID does not exist.");
                return;
            }

            PlayerDataBaseControl.playerID = txtPlayerID.Text;

            TopUpToPlayer();
        }

        private void BtnPlayerAccountName_Click(object sender, EventArgs e)
        {
            if (txtPlayerAccountName.Text == "")
            {
                MessageBox.Show("Player Account Name can not be empty.");
                return;
            }
            if (!PlayerDataBaseControl.MatchingOneColumn("PlayerAccountName", txtPlayerAccountName.Text))
            {
                MessageBox.Show("Player Account Name does not exist.");
                return;
            }

            if (txtPointCardID.Text == "")
            {
                MessageBox.Show("Point Card ID can not be empty.");
                return;
            }
            if (!DataBaseControl.MatchingOneColumn_OfTable("PointCard", "PointCardID", txtPointCardID.Text))
            {
                MessageBox.Show("Point Card ID does not exist.");
                return;
            }

            PlayerDataBaseControl.Load_PlayerID_By_PlayerAccountName(txtPlayerAccountName.Text);

            TopUpToPlayer();
        }
    }
}
