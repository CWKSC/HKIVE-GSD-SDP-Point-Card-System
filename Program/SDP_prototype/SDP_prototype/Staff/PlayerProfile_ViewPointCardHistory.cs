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
    public partial class PlayerProfile_ViewPointCardHistory : Form
    {
        public PlayerProfile_ViewPointCardHistory()
        {
            InitializeComponent();
        }

        private void PlayerProfile_ViewPointCardHistory_Load(object sender, EventArgs e)
        {
            TopUpHistoryDataBaseControl.Load();
            lblPointCardHistory.Text = "";
            for(int i = 0; i < TopUpHistoryDataBaseControl.dataTable.Rows.Count; i++)
            {
                lblPointCardHistory.Text += "PointCardID: " + TopUpHistoryDataBaseControl.PointCardIDs[i] + " ";
                lblPointCardHistory.Text += "RetailValue: " + PointCardDataBaseControl.GetData_ByColumn(
                    "PointCardID", TopUpHistoryDataBaseControl.PointCardIDs[i], "RetailValue") + " ";
                lblPointCardHistory.Text += "TopUpDate: " + TopUpHistoryDataBaseControl.TopUpDates[i] + Environment.NewLine;
            }
        }

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void lblPointCardHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PlayerProfile_ViewPointCardHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // It use to make it draggable. //
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
