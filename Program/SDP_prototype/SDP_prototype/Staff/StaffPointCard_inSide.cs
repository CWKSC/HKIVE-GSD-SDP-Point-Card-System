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
    public partial class StaffPointCard_inSide : Form
    {
        public StaffPointCard_inSide()
        {
            InitializeComponent();
        }

        private void BtnChangeRetailValue_Click(object sender, EventArgs e)
        {
            Staff.StaffPointCard_ChangeRetailValue staffPointCard_ChangeRetailValue = new Staff.StaffPointCard_ChangeRetailValue();
            staffPointCard_ChangeRetailValue.ShowDialog();
            RefreshPage();
        }

        private void btnChangeGoldCoins_Click(object sender, EventArgs e)
        {
            Staff.StaffPointCard_ChangeGoldCoins staffPointCard_ChangeGoldCoins = new Staff.StaffPointCard_ChangeGoldCoins();
            staffPointCard_ChangeGoldCoins.ShowDialog();
            RefreshPage();
        }

        private void BtnRemainLuckyDrawTimes_Click(object sender, EventArgs e)
        {
            Staff.StaffPointCard_ChangeRemainLuckyDrawTimes staffPointCard_ChangeRemainLuckyDrawTimes = new Staff.StaffPointCard_ChangeRemainLuckyDrawTimes();
            staffPointCard_ChangeRemainLuckyDrawTimes.ShowDialog();
            RefreshPage();
        }

        private void BtnChangeStatus_Click(object sender, EventArgs e)
        {
            Staff.StaffPointCard_ChangeStatus staffPointCard_ChangeStatus = new Staff.StaffPointCard_ChangeStatus();
            staffPointCard_ChangeStatus.ShowDialog();
            RefreshPage();
        }

        private void StaffPointCard_inSide_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {
            PointCardDataBaseControl.Load();

            lblPointCardIDOutput.Text          = PointCardDataBaseControl.pointCardID;
            lblRetailValueOutput.Text          = PointCardDataBaseControl.retailValue.ToString();
            lblGoldCoinsOutput.Text            = PointCardDataBaseControl.goldCoins.ToString();
            lblStatusOutput.Text               = PointCardDataBaseControl.status;
            lblGenerationDateOutput.Text       = PointCardDataBaseControl.generationDate;
            lblRemainLuckyDrawTimesOutput.Text = PointCardDataBaseControl.remainLuckyDrawTimes.ToString();
        }

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StaffPointCard_inSide_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        
    }
}
