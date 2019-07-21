﻿namespace SDP_prototype.Staff
{
    partial class StaffPlayerAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPlayerAccount));
            this.btnPlayerIDEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPlayerID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPlayerID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPlayerAccountName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPlayerAccountName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPlayerAccountNameEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btnPlayerIDEnter
            // 
            this.btnPlayerIDEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlayerIDEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerIDEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerIDEnter.BorderRadius = 0;
            this.btnPlayerIDEnter.ButtonText = "Enter";
            this.btnPlayerIDEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerIDEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayerIDEnter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPlayerIDEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayerIDEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayerIDEnter.Iconimage")));
            this.btnPlayerIDEnter.Iconimage_right = null;
            this.btnPlayerIDEnter.Iconimage_right_Selected = null;
            this.btnPlayerIDEnter.Iconimage_Selected = null;
            this.btnPlayerIDEnter.IconMarginLeft = 0;
            this.btnPlayerIDEnter.IconMarginRight = 0;
            this.btnPlayerIDEnter.IconRightVisible = false;
            this.btnPlayerIDEnter.IconRightZoom = 0D;
            this.btnPlayerIDEnter.IconVisible = false;
            this.btnPlayerIDEnter.IconZoom = 90D;
            this.btnPlayerIDEnter.IsTab = false;
            this.btnPlayerIDEnter.Location = new System.Drawing.Point(175, 331);
            this.btnPlayerIDEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPlayerIDEnter.Name = "btnPlayerIDEnter";
            this.btnPlayerIDEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayerIDEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlayerIDEnter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnPlayerIDEnter.selected = false;
            this.btnPlayerIDEnter.Size = new System.Drawing.Size(95, 35);
            this.btnPlayerIDEnter.TabIndex = 11;
            this.btnPlayerIDEnter.Text = "Enter";
            this.btnPlayerIDEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayerIDEnter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnPlayerIDEnter.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPlayerIDEnter.Click += new System.EventHandler(this.BtnPlayerIDEnter_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerID.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPlayerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblPlayerID.Location = new System.Drawing.Point(151, 240);
            this.lblPlayerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(143, 28);
            this.lblPlayerID.TabIndex = 10;
            this.lblPlayerID.Text = "Player ID:";
            this.lblPlayerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlayerID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerID.BorderThickness = 2;
            this.txtPlayerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPlayerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerID.isPassword = false;
            this.txtPlayerID.Location = new System.Drawing.Point(95, 274);
            this.txtPlayerID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.Padding = new System.Windows.Forms.Padding(0, 0, 68, 0);
            this.txtPlayerID.Size = new System.Drawing.Size(255, 46);
            this.txtPlayerID.TabIndex = 9;
            this.txtPlayerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPlayerAccountName
            // 
            this.txtPlayerAccountName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlayerAccountName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerAccountName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerAccountName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerAccountName.BorderThickness = 2;
            this.txtPlayerAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerAccountName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPlayerAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPlayerAccountName.isPassword = false;
            this.txtPlayerAccountName.Location = new System.Drawing.Point(446, 274);
            this.txtPlayerAccountName.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlayerAccountName.Name = "txtPlayerAccountName";
            this.txtPlayerAccountName.Padding = new System.Windows.Forms.Padding(0, 0, 68, 0);
            this.txtPlayerAccountName.Size = new System.Drawing.Size(255, 46);
            this.txtPlayerAccountName.TabIndex = 9;
            this.txtPlayerAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPlayerAccountName
            // 
            this.lblPlayerAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerAccountName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPlayerAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblPlayerAccountName.Location = new System.Drawing.Point(456, 240);
            this.lblPlayerAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerAccountName.Name = "lblPlayerAccountName";
            this.lblPlayerAccountName.Size = new System.Drawing.Size(234, 28);
            this.lblPlayerAccountName.TabIndex = 10;
            this.lblPlayerAccountName.Text = "Player Account Name:";
            this.lblPlayerAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayerAccountNameEnter
            // 
            this.btnPlayerAccountNameEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlayerAccountNameEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerAccountNameEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerAccountNameEnter.BorderRadius = 0;
            this.btnPlayerAccountNameEnter.ButtonText = "Enter";
            this.btnPlayerAccountNameEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerAccountNameEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayerAccountNameEnter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPlayerAccountNameEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayerAccountNameEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayerAccountNameEnter.Iconimage")));
            this.btnPlayerAccountNameEnter.Iconimage_right = null;
            this.btnPlayerAccountNameEnter.Iconimage_right_Selected = null;
            this.btnPlayerAccountNameEnter.Iconimage_Selected = null;
            this.btnPlayerAccountNameEnter.IconMarginLeft = 0;
            this.btnPlayerAccountNameEnter.IconMarginRight = 0;
            this.btnPlayerAccountNameEnter.IconRightVisible = false;
            this.btnPlayerAccountNameEnter.IconRightZoom = 0D;
            this.btnPlayerAccountNameEnter.IconVisible = false;
            this.btnPlayerAccountNameEnter.IconZoom = 90D;
            this.btnPlayerAccountNameEnter.IsTab = false;
            this.btnPlayerAccountNameEnter.Location = new System.Drawing.Point(526, 331);
            this.btnPlayerAccountNameEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPlayerAccountNameEnter.Name = "btnPlayerAccountNameEnter";
            this.btnPlayerAccountNameEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayerAccountNameEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlayerAccountNameEnter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnPlayerAccountNameEnter.selected = false;
            this.btnPlayerAccountNameEnter.Size = new System.Drawing.Size(95, 35);
            this.btnPlayerAccountNameEnter.TabIndex = 11;
            this.btnPlayerAccountNameEnter.Text = "Enter";
            this.btnPlayerAccountNameEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayerAccountNameEnter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnPlayerAccountNameEnter.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPlayerAccountNameEnter.Click += new System.EventHandler(this.BtnPlayerAccountNameEnter_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(373, 283);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(53, 28);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "OR";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffPlayerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnPlayerAccountNameEnter);
            this.Controls.Add(this.btnPlayerIDEnter);
            this.Controls.Add(this.lblPlayerAccountName);
            this.Controls.Add(this.txtPlayerAccountName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.txtPlayerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffPlayerAccount";
            this.Text = "StaffPlayerAccount";
            this.Load += new System.EventHandler(this.StaffPlayerAccount_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StaffPlayerAccount_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnPlayerIDEnter;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlayerID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPlayerID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPlayerAccountName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlayerAccountName;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayerAccountNameEnter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}