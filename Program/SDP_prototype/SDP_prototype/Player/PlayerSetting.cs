﻿using System;
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
    public partial class PlayerSetting : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlayerSetting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public PlayerSetting()
        {
            InitializeComponent();
        }

        private void RefreshPage()
        {
            if (PlayerDataBaseControl.isEnglish)
            {
                lblLanguage.Text = "Language:";
                btnChangeLanguage.Text = "Change to Chinese";
            }
            else
            {
                lblLanguage.Text = "語言:";
                btnChangeLanguage.Text = "換成英文";
            }
        }

        private void PlayerSetting_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void BtnChangeLanguage_Click(object sender, EventArgs e)
        {

            PlayerDataBaseControl.Updata_isEnglish(!PlayerDataBaseControl.isEnglish);

            ((PlayerMenu)MdiParent).RefreshPage();
            RefreshPage();
        }
    }
}