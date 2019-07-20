
namespace SDP_prototype
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSign = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUserAccountName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUseNameOrEmailLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblForgotPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmailCanBeEmpty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSignUpForFree = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bar = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblUserAccountName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.gradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 5;
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.gradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel.BackgroundImage")));
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Controls.Add(this.button2);
            this.gradientPanel.Controls.Add(this.button3);
            this.gradientPanel.Controls.Add(this.button1);
            this.gradientPanel.Controls.Add(this.btnExit);
            this.gradientPanel.Controls.Add(this.btnSign);
            this.gradientPanel.Controls.Add(this.txtPassword);
            this.gradientPanel.Controls.Add(this.txtEmail);
            this.gradientPanel.Controls.Add(this.txtUserAccountName);
            this.gradientPanel.Controls.Add(this.lblUseNameOrEmailLogin);
            this.gradientPanel.Controls.Add(this.lblForgotPassword);
            this.gradientPanel.Controls.Add(this.lblPassword);
            this.gradientPanel.Controls.Add(this.lblEmailCanBeEmpty);
            this.gradientPanel.Controls.Add(this.lblEmail);
            this.gradientPanel.Controls.Add(this.lblSignUpForFree);
            this.gradientPanel.Controls.Add(this.bar);
            this.gradientPanel.Controls.Add(this.btnSignIn);
            this.gradientPanel.Controls.Add(this.btnSignUp);
            this.gradientPanel.Controls.Add(this.lblUserAccountName);
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.gradientPanel.GradientBottomRight = System.Drawing.Color.Cyan;
            this.gradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gradientPanel.GradientTopRight = System.Drawing.Color.Black;
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(500, 600);
            this.gradientPanel.TabIndex = 4;
            this.gradientPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientPanel_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Staff";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "CSM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
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
            this.btnExit.Location = new System.Drawing.Point(446, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(41, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSign
            // 
            this.btnSign.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSign.BackColor = System.Drawing.Color.Transparent;
            this.btnSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSign.BorderRadius = 0;
            this.btnSign.ButtonText = "Sign Up";
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.DisabledColor = System.Drawing.Color.Gray;
            this.btnSign.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSign.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSign.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSign.Iconimage")));
            this.btnSign.Iconimage_right = null;
            this.btnSign.Iconimage_right_Selected = null;
            this.btnSign.Iconimage_Selected = null;
            this.btnSign.IconMarginLeft = 0;
            this.btnSign.IconMarginRight = 0;
            this.btnSign.IconRightVisible = false;
            this.btnSign.IconRightZoom = 0D;
            this.btnSign.IconVisible = false;
            this.btnSign.IconZoom = 90D;
            this.btnSign.IsTab = false;
            this.btnSign.Location = new System.Drawing.Point(110, 469);
            this.btnSign.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSign.Name = "btnSign";
            this.btnSign.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSign.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSign.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSign.selected = false;
            this.btnSign.Size = new System.Drawing.Size(284, 48);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign Up";
            this.btnSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSign.Textcolor = System.Drawing.Color.White;
            this.btnSign.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPassword.BorderColorFocused = System.Drawing.Color.White;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(88, 407);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(0, 0, 54, 16);
            this.txtPassword.Size = new System.Drawing.Size(329, 43);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "TestCSM";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtEmail.BorderColorFocused = System.Drawing.Color.White;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(88, 321);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(0, 0, 54, 16);
            this.txtEmail.Size = new System.Drawing.Size(329, 43);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Test@CSM.com";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserAccountName
            // 
            this.txtUserAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtUserAccountName.BorderColorFocused = System.Drawing.Color.White;
            this.txtUserAccountName.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtUserAccountName.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtUserAccountName.BorderThickness = 2;
            this.txtUserAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserAccountName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserAccountName.ForeColor = System.Drawing.Color.White;
            this.txtUserAccountName.isPassword = false;
            this.txtUserAccountName.Location = new System.Drawing.Point(88, 237);
            this.txtUserAccountName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserAccountName.Name = "txtUserAccountName";
            this.txtUserAccountName.Padding = new System.Windows.Forms.Padding(0, 0, 54, 16);
            this.txtUserAccountName.Size = new System.Drawing.Size(329, 43);
            this.txtUserAccountName.TabIndex = 3;
            this.txtUserAccountName.Text = "TestCSM";
            this.txtUserAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUseNameOrEmailLogin
            // 
            this.lblUseNameOrEmailLogin.AutoSize = true;
            this.lblUseNameOrEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUseNameOrEmailLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUseNameOrEmailLogin.ForeColor = System.Drawing.Color.White;
            this.lblUseNameOrEmailLogin.Location = new System.Drawing.Point(276, 214);
            this.lblUseNameOrEmailLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUseNameOrEmailLogin.Name = "lblUseNameOrEmailLogin";
            this.lblUseNameOrEmailLogin.Size = new System.Drawing.Size(141, 19);
            this.lblUseNameOrEmailLogin.TabIndex = 0;
            this.lblUseNameOrEmailLogin.Text = "Use email to login ?";
            this.lblUseNameOrEmailLogin.Visible = false;
            this.lblUseNameOrEmailLogin.Click += new System.EventHandler(this.LblUseNameOrEmailLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(287, 383);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(130, 19);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "forgot password ?";
            this.lblForgotPassword.Visible = false;
            this.lblForgotPassword.Click += new System.EventHandler(this.LblForgotPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(84, 382);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblEmailCanBeEmpty
            // 
            this.lblEmailCanBeEmpty.AutoSize = true;
            this.lblEmailCanBeEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCanBeEmpty.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEmailCanBeEmpty.ForeColor = System.Drawing.Color.White;
            this.lblEmailCanBeEmpty.Location = new System.Drawing.Point(139, 295);
            this.lblEmailCanBeEmpty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCanBeEmpty.Name = "lblEmailCanBeEmpty";
            this.lblEmailCanBeEmpty.Size = new System.Drawing.Size(127, 19);
            this.lblEmailCanBeEmpty.TabIndex = 0;
            this.lblEmailCanBeEmpty.Text = "( can be empty )";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(84, 295);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSignUpForFree
            // 
            this.lblSignUpForFree.AutoSize = true;
            this.lblSignUpForFree.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpForFree.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpForFree.ForeColor = System.Drawing.Color.White;
            this.lblSignUpForFree.Location = new System.Drawing.Point(140, 152);
            this.lblSignUpForFree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignUpForFree.Name = "lblSignUpForFree";
            this.lblSignUpForFree.Size = new System.Drawing.Size(220, 33);
            this.lblSignUpForFree.TabIndex = 0;
            this.lblSignUpForFree.Text = "Sign Up For Free";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar.LineThickness = 5;
            this.bar.Location = new System.Drawing.Point(98, 117);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(137, 12);
            this.bar.TabIndex = 4;
            this.bar.Transparency = 255;
            this.bar.Vertical = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 0;
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Iconimage")));
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconMarginLeft = 0;
            this.btnSignIn.IconMarginRight = 0;
            this.btnSignIn.IconRightVisible = false;
            this.btnSignIn.IconRightZoom = 0D;
            this.btnSignIn.IconVisible = false;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = false;
            this.btnSignIn.Location = new System.Drawing.Point(270, 68);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignIn.selected = false;
            this.btnSignIn.Size = new System.Drawing.Size(137, 48);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 0;
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Iconimage")));
            this.btnSignUp.Iconimage_right = null;
            this.btnSignUp.Iconimage_right_Selected = null;
            this.btnSignUp.Iconimage_Selected = null;
            this.btnSignUp.IconMarginLeft = 0;
            this.btnSignUp.IconMarginRight = 0;
            this.btnSignUp.IconRightVisible = false;
            this.btnSignUp.IconRightZoom = 0D;
            this.btnSignUp.IconVisible = false;
            this.btnSignUp.IconZoom = 90D;
            this.btnSignUp.IsTab = false;
            this.btnSignUp.Location = new System.Drawing.Point(98, 68);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(137, 48);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Textcolor = System.Drawing.Color.White;
            this.btnSignUp.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // lblUserAccountName
            // 
            this.lblUserAccountName.AutoSize = true;
            this.lblUserAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserAccountName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUserAccountName.ForeColor = System.Drawing.Color.White;
            this.lblUserAccountName.Location = new System.Drawing.Point(84, 210);
            this.lblUserAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserAccountName.Name = "lblUserAccountName";
            this.lblUserAccountName.Size = new System.Drawing.Size(168, 21);
            this.lblUserAccountName.TabIndex = 0;
            this.lblUserAccountName.Text = "User Account Name";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.Text = "PlayerLogin";
            this.panel1.ResumeLayout(false);
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnSign;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserAccountName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUseNameOrEmailLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblForgotPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSignUpForFree;
        private Bunifu.Framework.UI.BunifuSeparator bar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserAccountName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmailCanBeEmpty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}