namespace SDP_prototype
{
    partial class CSMMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSMMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftGradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPointCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayerAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReceiveProblems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bar = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPlayerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblWelcome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTopUpToPlayer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreatePointCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.leftGradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftGradientPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // leftGradientPanel
            // 
            this.leftGradientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.leftGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftGradientPanel.BackgroundImage")));
            this.leftGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftGradientPanel.Controls.Add(this.btnLogout);
            this.leftGradientPanel.Controls.Add(this.btnTopUpToPlayer);
            this.leftGradientPanel.Controls.Add(this.btnCreatePointCard);
            this.leftGradientPanel.Controls.Add(this.btnPointCard);
            this.leftGradientPanel.Controls.Add(this.btnPlayerAccount);
            this.leftGradientPanel.Controls.Add(this.btnSetting);
            this.leftGradientPanel.Controls.Add(this.btnReceiveProblems);
            this.leftGradientPanel.Controls.Add(this.btnProfile);
            this.leftGradientPanel.Controls.Add(this.btnHome);
            this.leftGradientPanel.Controls.Add(this.bar);
            this.leftGradientPanel.Controls.Add(this.lblPlayerName);
            this.leftGradientPanel.Controls.Add(this.lblWelcome);
            this.leftGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.leftGradientPanel.GradientBottomRight = System.Drawing.Color.Cyan;
            this.leftGradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.leftGradientPanel.GradientTopRight = System.Drawing.Color.Black;
            this.leftGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.leftGradientPanel.Name = "leftGradientPanel";
            this.leftGradientPanel.Quality = 10;
            this.leftGradientPanel.Size = new System.Drawing.Size(200, 600);
            this.leftGradientPanel.TabIndex = 0;
            this.leftGradientPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftGradientPanel_MouseDown);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = false;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = false;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = true;
            this.btnLogout.Location = new System.Drawing.Point(0, 482);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(200, 48);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnPointCard
            // 
            this.btnPointCard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnPointCard.BackColor = System.Drawing.Color.Transparent;
            this.btnPointCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPointCard.BorderRadius = 0;
            this.btnPointCard.ButtonText = "Point Card";
            this.btnPointCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPointCard.DisabledColor = System.Drawing.Color.Gray;
            this.btnPointCard.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPointCard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPointCard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPointCard.Iconimage")));
            this.btnPointCard.Iconimage_right = null;
            this.btnPointCard.Iconimage_right_Selected = null;
            this.btnPointCard.Iconimage_Selected = null;
            this.btnPointCard.IconMarginLeft = 0;
            this.btnPointCard.IconMarginRight = 0;
            this.btnPointCard.IconRightVisible = false;
            this.btnPointCard.IconRightZoom = 0D;
            this.btnPointCard.IconVisible = false;
            this.btnPointCard.IconZoom = 90D;
            this.btnPointCard.IsTab = true;
            this.btnPointCard.Location = new System.Drawing.Point(0, 262);
            this.btnPointCard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPointCard.Name = "btnPointCard";
            this.btnPointCard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPointCard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnPointCard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPointCard.selected = false;
            this.btnPointCard.Size = new System.Drawing.Size(200, 48);
            this.btnPointCard.TabIndex = 7;
            this.btnPointCard.Text = "Point Card";
            this.btnPointCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPointCard.Textcolor = System.Drawing.Color.White;
            this.btnPointCard.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPointCard.Click += new System.EventHandler(this.BtnPointCard_Click);
            // 
            // btnPlayerAccount
            // 
            this.btnPlayerAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnPlayerAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerAccount.BorderRadius = 0;
            this.btnPlayerAccount.ButtonText = "Player Account";
            this.btnPlayerAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayerAccount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPlayerAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayerAccount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayerAccount.Iconimage")));
            this.btnPlayerAccount.Iconimage_right = null;
            this.btnPlayerAccount.Iconimage_right_Selected = null;
            this.btnPlayerAccount.Iconimage_Selected = null;
            this.btnPlayerAccount.IconMarginLeft = 0;
            this.btnPlayerAccount.IconMarginRight = 0;
            this.btnPlayerAccount.IconRightVisible = false;
            this.btnPlayerAccount.IconRightZoom = 0D;
            this.btnPlayerAccount.IconVisible = false;
            this.btnPlayerAccount.IconZoom = 90D;
            this.btnPlayerAccount.IsTab = true;
            this.btnPlayerAccount.Location = new System.Drawing.Point(0, 207);
            this.btnPlayerAccount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPlayerAccount.Name = "btnPlayerAccount";
            this.btnPlayerAccount.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayerAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnPlayerAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlayerAccount.selected = false;
            this.btnPlayerAccount.Size = new System.Drawing.Size(200, 48);
            this.btnPlayerAccount.TabIndex = 8;
            this.btnPlayerAccount.Text = "Player Account";
            this.btnPlayerAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayerAccount.Textcolor = System.Drawing.Color.White;
            this.btnPlayerAccount.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPlayerAccount.Click += new System.EventHandler(this.BtnPlayerAccount_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "Setting";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = false;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = false;
            this.btnSetting.IconZoom = 90D;
            this.btnSetting.IsTab = true;
            this.btnSetting.Location = new System.Drawing.Point(0, 537);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(200, 48);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.Textcolor = System.Drawing.Color.White;
            this.btnSetting.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // btnReceiveProblems
            // 
            this.btnReceiveProblems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnReceiveProblems.BackColor = System.Drawing.Color.Transparent;
            this.btnReceiveProblems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceiveProblems.BorderRadius = 0;
            this.btnReceiveProblems.ButtonText = "Receive Problems";
            this.btnReceiveProblems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveProblems.DisabledColor = System.Drawing.Color.Gray;
            this.btnReceiveProblems.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnReceiveProblems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReceiveProblems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReceiveProblems.Iconimage")));
            this.btnReceiveProblems.Iconimage_right = null;
            this.btnReceiveProblems.Iconimage_right_Selected = null;
            this.btnReceiveProblems.Iconimage_Selected = null;
            this.btnReceiveProblems.IconMarginLeft = 0;
            this.btnReceiveProblems.IconMarginRight = 0;
            this.btnReceiveProblems.IconRightVisible = false;
            this.btnReceiveProblems.IconRightZoom = 0D;
            this.btnReceiveProblems.IconVisible = false;
            this.btnReceiveProblems.IconZoom = 90D;
            this.btnReceiveProblems.IsTab = true;
            this.btnReceiveProblems.Location = new System.Drawing.Point(0, 427);
            this.btnReceiveProblems.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReceiveProblems.Name = "btnReceiveProblems";
            this.btnReceiveProblems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReceiveProblems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnReceiveProblems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReceiveProblems.selected = false;
            this.btnReceiveProblems.Size = new System.Drawing.Size(200, 48);
            this.btnReceiveProblems.TabIndex = 10;
            this.btnReceiveProblems.Text = "Receive Problems";
            this.btnReceiveProblems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReceiveProblems.Textcolor = System.Drawing.Color.White;
            this.btnReceiveProblems.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnReceiveProblems.Click += new System.EventHandler(this.BtnReceiveProblems_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.BorderRadius = 0;
            this.btnProfile.ButtonText = "Profile";
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProfile.Iconimage")));
            this.btnProfile.Iconimage_right = null;
            this.btnProfile.Iconimage_right_Selected = null;
            this.btnProfile.Iconimage_Selected = null;
            this.btnProfile.IconMarginLeft = 0;
            this.btnProfile.IconMarginRight = 0;
            this.btnProfile.IconRightVisible = false;
            this.btnProfile.IconRightZoom = 0D;
            this.btnProfile.IconVisible = false;
            this.btnProfile.IconZoom = 90D;
            this.btnProfile.IsTab = true;
            this.btnProfile.Location = new System.Drawing.Point(0, 152);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfile.selected = false;
            this.btnProfile.Size = new System.Drawing.Size(200, 48);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfile.Textcolor = System.Drawing.Color.White;
            this.btnProfile.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = false;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = false;
            this.btnHome.IconZoom = 90D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 97);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(200, 48);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar.LineThickness = 5;
            this.bar.Location = new System.Drawing.Point(30, 77);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(137, 12);
            this.bar.TabIndex = 5;
            this.bar.Transparency = 255;
            this.bar.Vertical = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(2, 52);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(196, 22);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Test Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(57, 18);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(83, 21);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExit.Iconcolor = System.Drawing.SystemColors.Control;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = false;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = false;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(946, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(41, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.Black;
            this.btnExit.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTopUpToPlayer
            // 
            this.btnTopUpToPlayer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTopUpToPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnTopUpToPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopUpToPlayer.BorderRadius = 0;
            this.btnTopUpToPlayer.ButtonText = "Top Up To Player";
            this.btnTopUpToPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopUpToPlayer.DisabledColor = System.Drawing.Color.Gray;
            this.btnTopUpToPlayer.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnTopUpToPlayer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTopUpToPlayer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTopUpToPlayer.Iconimage")));
            this.btnTopUpToPlayer.Iconimage_right = null;
            this.btnTopUpToPlayer.Iconimage_right_Selected = null;
            this.btnTopUpToPlayer.Iconimage_Selected = null;
            this.btnTopUpToPlayer.IconMarginLeft = 0;
            this.btnTopUpToPlayer.IconMarginRight = 0;
            this.btnTopUpToPlayer.IconRightVisible = false;
            this.btnTopUpToPlayer.IconRightZoom = 0D;
            this.btnTopUpToPlayer.IconVisible = false;
            this.btnTopUpToPlayer.IconZoom = 90D;
            this.btnTopUpToPlayer.IsTab = true;
            this.btnTopUpToPlayer.Location = new System.Drawing.Point(0, 372);
            this.btnTopUpToPlayer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTopUpToPlayer.Name = "btnTopUpToPlayer";
            this.btnTopUpToPlayer.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTopUpToPlayer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTopUpToPlayer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTopUpToPlayer.selected = false;
            this.btnTopUpToPlayer.Size = new System.Drawing.Size(200, 48);
            this.btnTopUpToPlayer.TabIndex = 7;
            this.btnTopUpToPlayer.Text = "Top Up To Player";
            this.btnTopUpToPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTopUpToPlayer.Textcolor = System.Drawing.Color.White;
            this.btnTopUpToPlayer.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnTopUpToPlayer.Click += new System.EventHandler(this.BtnTopUpToPlayer_Click);
            // 
            // btnCreatePointCard
            // 
            this.btnCreatePointCard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnCreatePointCard.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePointCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatePointCard.BorderRadius = 0;
            this.btnCreatePointCard.ButtonText = "Create Point Card";
            this.btnCreatePointCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePointCard.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreatePointCard.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnCreatePointCard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreatePointCard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreatePointCard.Iconimage")));
            this.btnCreatePointCard.Iconimage_right = null;
            this.btnCreatePointCard.Iconimage_right_Selected = null;
            this.btnCreatePointCard.Iconimage_Selected = null;
            this.btnCreatePointCard.IconMarginLeft = 0;
            this.btnCreatePointCard.IconMarginRight = 0;
            this.btnCreatePointCard.IconRightVisible = false;
            this.btnCreatePointCard.IconRightZoom = 0D;
            this.btnCreatePointCard.IconVisible = false;
            this.btnCreatePointCard.IconZoom = 90D;
            this.btnCreatePointCard.IsTab = true;
            this.btnCreatePointCard.Location = new System.Drawing.Point(0, 317);
            this.btnCreatePointCard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCreatePointCard.Name = "btnCreatePointCard";
            this.btnCreatePointCard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCreatePointCard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnCreatePointCard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreatePointCard.selected = false;
            this.btnCreatePointCard.Size = new System.Drawing.Size(200, 48);
            this.btnCreatePointCard.TabIndex = 7;
            this.btnCreatePointCard.Text = "Create Point Card";
            this.btnCreatePointCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreatePointCard.Textcolor = System.Drawing.Color.White;
            this.btnCreatePointCard.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnCreatePointCard.Click += new System.EventHandler(this.BtnCreatePointCard_Click);
            // 
            // CSMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "CSMMenu";
            this.Text = "PlayerMenu";
            this.Load += new System.EventHandler(this.StaffMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerMenu_MouseDown);
            this.panel1.ResumeLayout(false);
            this.leftGradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel leftGradientPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWelcome;
        private Bunifu.Framework.UI.BunifuSeparator bar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlayerName;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnPointCard;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayerAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        private Bunifu.Framework.UI.BunifuFlatButton btnReceiveProblems;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfile;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnTopUpToPlayer;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreatePointCard;
    }
}