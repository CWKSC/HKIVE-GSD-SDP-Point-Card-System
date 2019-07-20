namespace SDP_prototype.Player
{
    partial class PlayerPointCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPointCard));
            this.txtPointCardID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPointCardID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtPointCardID
            // 
            this.txtPointCardID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPointCardID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPointCardID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPointCardID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPointCardID.BorderThickness = 2;
            this.txtPointCardID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPointCardID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPointCardID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtPointCardID.isPassword = false;
            this.txtPointCardID.Location = new System.Drawing.Point(266, 270);
            this.txtPointCardID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPointCardID.Name = "txtPointCardID";
            this.txtPointCardID.Padding = new System.Windows.Forms.Padding(0, 0, 68, 0);
            this.txtPointCardID.Size = new System.Drawing.Size(255, 46);
            this.txtPointCardID.TabIndex = 6;
            this.txtPointCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPointCardID
            // 
            this.lblPointCardID.BackColor = System.Drawing.Color.Transparent;
            this.lblPointCardID.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPointCardID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblPointCardID.Location = new System.Drawing.Point(322, 236);
            this.lblPointCardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointCardID.Name = "lblPointCardID";
            this.lblPointCardID.Size = new System.Drawing.Size(143, 28);
            this.lblPointCardID.TabIndex = 7;
            this.lblPointCardID.Text = "Point Card ID:";
            this.lblPointCardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.BorderRadius = 0;
            this.btnEnter.ButtonText = "Enter";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnter.Iconimage")));
            this.btnEnter.Iconimage_right = null;
            this.btnEnter.Iconimage_right_Selected = null;
            this.btnEnter.Iconimage_Selected = null;
            this.btnEnter.IconMarginLeft = 0;
            this.btnEnter.IconMarginRight = 0;
            this.btnEnter.IconRightVisible = false;
            this.btnEnter.IconRightZoom = 0D;
            this.btnEnter.IconVisible = false;
            this.btnEnter.IconZoom = 90D;
            this.btnEnter.IsTab = false;
            this.btnEnter.Location = new System.Drawing.Point(346, 327);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(95, 35);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnEnter.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // PlayerPointCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPointCardID);
            this.Controls.Add(this.txtPointCardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerPointCard";
            this.Text = "PlayerPointCardInformation";
            this.Load += new System.EventHandler(this.PlayerPointCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerPointCardInformation_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtPointCardID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPointCardID;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
    }
}