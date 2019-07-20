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
    public partial class StaffPointCard_ChangeGoldCoins : Form
    {
        public StaffPointCard_ChangeGoldCoins()
        {
            InitializeComponent();
        }

        private void BtnChangeGoldCoins_Click(object sender, EventArgs e)
        {
            PointCardDataBaseControl.Updata_GoldCoins(int.Parse(txtGoldCoins.Text));
            Close();
        }

        private void StaffPointCard_ChangeGoldCoins_Load(object sender, EventArgs e)
        {
            txtGoldCoins.Text = PointCardDataBaseControl.goldCoins.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StaffPointCard_ChangeRetailValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

    }
}
