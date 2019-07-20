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
    public partial class StaffPlayerAccount : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StaffPlayerAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public StaffPlayerAccount()
        {
            InitializeComponent();
        }

        private void StaffPlayerAccount_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlayerIDEnter_Click(object sender, EventArgs e)
        {
            if(txtPlayerID.Text == "")
            {
                MessageBox.Show("Player ID can not be empty.");
                return;
            }

            if(!PlayerDataBaseControl.MatchingOneColumn("PlayerID", txtPlayerID.Text))
            {
                MessageBox.Show("Player ID does not exist.");
                return;
            }

            PlayerDataBaseControl.playerID = txtPlayerID.Text;
            PlayerDataBaseControl.Load();

            if (StaffDataBaseControl.staffID != "")
            {
                ((StaffMenu)MdiParent).ChangeMDIForm_callByOtherForm(StaffMenu.Page.PlayerAccount_inSide);
            }
            else if (CSMDataBaseControl.CSMID != "")
            {
                ((CSMMenu)MdiParent).ChangeMDIForm_callByOtherForm(CSMMenu.Page.PlayerAccount_inSide);
            }
            else
            {
                MessageBox.Show("Unexpected flow.");
            }

            btnPlayerIDEnter.Enabled = false;
        }

        private void BtnPlayerAccountNameEnter_Click(object sender, EventArgs e)
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

            PlayerDataBaseControl.playerID = PlayerDataBaseControl.GetData_ByColumn("PlayerAccountName", txtPlayerAccountName.Text, "PlayerID");
            PlayerDataBaseControl.Load();

            if (StaffDataBaseControl.staffID != "")
            {
                ((StaffMenu)MdiParent).ChangeMDIForm_callByOtherForm(StaffMenu.Page.PlayerAccount_inSide);
            }
            else if (CSMDataBaseControl.CSMID != "")
            {
                ((CSMMenu)MdiParent).ChangeMDIForm_callByOtherForm(CSMMenu.Page.PlayerAccount_inSide);
            }
            else
            {
                MessageBox.Show("Unexpected flow.");
            }

            btnPlayerAccountNameEnter.Enabled = false;
        }

        
    }
}
