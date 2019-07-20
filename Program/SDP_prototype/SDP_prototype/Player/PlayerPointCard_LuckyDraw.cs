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
    public partial class PlayerPointCard_LuckyDraw : Form
    {

        #region it make Draggable Code
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerPointCard_LuckyDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // It use to make it draggable. //
        #endregion

        public PlayerPointCard_LuckyDraw()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void PlayerPointCard_LuckyDraw_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        Random rnd = new Random();
        int randomNum;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            randomNum = rnd.Next(1, 10);
            lblRandomNum.Text = randomNum.ToString();
        }

        private void LuckDraw()
        {
            MessageBox.Show("You are correct!\nYou has a lucky draw.");
            randomNum = rnd.Next(1, 100);
            double mult = 1;
            if(randomNum <= 50)
            {
                mult = 1.1;
                MessageBox.Show("Chance of increasing 10 % of topped-up Virtual Gold Coins.");
            }
            else if (randomNum <= 50 + 30)
            {
                mult = 1.2;
                MessageBox.Show("Chance of increasing 20 % of topped-up Virtual Gold Coins.");
            }
            else if (randomNum <= 50 + 30 + 15)
            {
                mult = 1.5;
                MessageBox.Show("Chance of increasing 50 % of topped-up Virtual Gold Coins.");
            }
            else if (randomNum <= 50 + 30 + 15 + 5)
            {
                mult = 2;
                MessageBox.Show("Chance of increasing 100 % of topped-up Virtual Gold Coins.");
            }
            PlayerDataBaseControl.playerGoldCoins = (int)(PlayerDataBaseControl.playerGoldCoins * mult);
            PlayerDataBaseControl.Updata("PlayerGoldCoins", PlayerDataBaseControl.playerGoldCoins.ToString());
            PointCardDataBaseControl.Updata("RemainLuckyDrawTimes",
                  (PointCardDataBaseControl.remainLuckyDrawTimes - 1).ToString());
            Close();
        }

        private void WrongGuess()
        {
            MessageBox.Show("Unfortunately, your guess is wrong.");
            PointCardDataBaseControl.Updata("RemainLuckyDrawTimes",
                           (PointCardDataBaseControl.remainLuckyDrawTimes - 1).ToString());
            Close();
        }

        private void BtnGreaterThan5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (randomNum > 5)
            {
                LuckDraw();
            }
            else
            {
                WrongGuess();
            }
        }

        private void BtnLessThan5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (randomNum <= 5)
            {
                LuckDraw();
            }
            else
            {
                WrongGuess();
            }
        }


    }
}
