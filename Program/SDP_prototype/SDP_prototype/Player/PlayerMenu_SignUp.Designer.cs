namespace SDP_prototype.Player
{
    partial class PlayerMenu_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenu_SignUp));
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSign = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(35, 122);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(0, 0, 54, 16);
            this.txtUserName.Size = new System.Drawing.Size(329, 43);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.lblUserName.Location = new System.Drawing.Point(46, 33);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(301, 71);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Since you are first times to use our system, please enter your user name. (you ca" +
    "n change it later)";
            this.lblUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblUserName_MouseDown);
            // 
            // btnSign
            // 
            this.btnSign.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSign.BackColor = System.Drawing.Color.Transparent;
            this.btnSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSign.BorderRadius = 0;
            this.btnSign.ButtonText = "OK";
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
            this.btnSign.Location = new System.Drawing.Point(64, 175);
            this.btnSign.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSign.Name = "btnSign";
            this.btnSign.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSign.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSign.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.btnSign.selected = false;
            this.btnSign.Size = new System.Drawing.Size(268, 48);
            this.btnSign.TabIndex = 6;
            this.btnSign.Text = "OK";
            this.btnSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSign.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.btnSign.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // PlayerMenu_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerMenu_SignUp";
            this.Text = "PlayerMenu_SignUp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerMenu_SignUp_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSign;
    }
}