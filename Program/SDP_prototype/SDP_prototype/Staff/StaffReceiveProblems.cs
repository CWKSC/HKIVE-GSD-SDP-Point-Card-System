﻿using System;
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
    public partial class StaffReceiveProblems : Form
    {

        #region it make Draggable
        // It use to make it draggable. //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StaffReceiveProblems_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(MdiParent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // It use to make it draggable. //
        #endregion

        public StaffReceiveProblems()
        {
            InitializeComponent();
        }

        private void StaffReceiveProblems_Load(object sender, EventArgs e)
        {
            ProblemReportDataBaseControl.Load();
            lblReceiveProblem.Text = "";
            for (int i = 0; i < ProblemReportDataBaseControl.dataTable.Rows.Count; i++)
            {
                lblReceiveProblem.Text += "ProblemReportID: " + ProblemReportDataBaseControl.problemReportIDs[i] + Environment.NewLine;
                lblReceiveProblem.Text += "Title: " + ProblemReportDataBaseControl.titles[i] + Environment.NewLine;
                lblReceiveProblem.Text += "Detail: " + ProblemReportDataBaseControl.details[i] + Environment.NewLine + Environment.NewLine;
            }
        }

        
    }
}