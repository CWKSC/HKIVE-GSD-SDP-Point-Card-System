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
    public partial class PlayerPromotion : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerPromotion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LblPromotion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // It use to make it draggable. //
        #endregion

        public PlayerPromotion()
        {
            InitializeComponent();
        }

        private void PlayerPromotion_Load(object sender, EventArgs e)
        {
            lblPromotion.Text = "";
            if (PlayerDataBaseControl.isEnglish)
            {
                lblPromotion.Text += "Point Card Overview\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "HK$50 = 150 Virtual Gold Coins\n";
                lblPromotion.Text += "HK$100 = 350 Virtual Gold Coins + one Lucky Draw\n";
                lblPromotion.Text += "HK$200 = 800 Virtual Gold Coins + two Lucky Draw\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "\tWhen activating the Point Card, player gets a fixed number of chances to play the Lucky Draw. The player need to guess a secret number is greater than five or not correctly.  If the player wins, he/she then has a chance to increase the values of the Virtual Gold Coins by 10%, 20%, 50% or 100%.\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "Mini game \"Lucky Draw\"\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "The game generates a random number between one and ten.  The player needs to guess whether the secret number is greater than number five or not.  When the guessing is correct, the player will has a lucky draw. \n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "Chance of Increasing the Virtual Gold Coins\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "Chance of increasing 10% of topped-up Virtual Gold Coins is 0.5\n";
                lblPromotion.Text += "Chance of increasing 20% of topped-up Virtual Gold Coins is 0.3\n";
                lblPromotion.Text += "Chance of increasing 50% of topped-up Virtual Gold Coins is 0.15\n";
                lblPromotion.Text += "Chance of increasing 100% of topped-up Virtual Gold Coins is 0.05";
            }
            else
            {
                lblPromotion.Text += "點卡概述\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "HK $ 50 = 150枚虛擬金幣\n";
                lblPromotion.Text += "HK $ 100 = 350個虛擬金幣+一次幸運抽獎\n";
                lblPromotion.Text += "HK $ 200= 800個虛擬金幣+兩個幸運抽獎\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "\t激活積分卡時,玩家可獲得一定數量的機會參加幸運抽獎。 玩家需要猜測一個大於五的秘密號碼或者不正確。 如果玩家獲勝,他 / 她則有機會將虛擬金幣的價值提高10 %,20 %,50 % 或100 %。\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "迷你游戲“幸運抽獎”\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "遊戲生成1到10之間的隨機數。 玩家需要猜測密碼是否大於5號。 當猜測正確時,玩家將獲得幸運抽獎。\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "增加虛擬金幣的機會\n";
                lblPromotion.Text += "\n";
                lblPromotion.Text += "增加10%的充值虛擬金幣的機會是0.5\n";
                lblPromotion.Text += "增加20%的虛擬金幣的可能性為0.3\n";
                lblPromotion.Text += "增加50%的虛擬金幣的可能性為0.15\n";
                lblPromotion.Text += "增加100%的充值虛擬金幣的機會是0.05";
            }
        }

        
    }
}
