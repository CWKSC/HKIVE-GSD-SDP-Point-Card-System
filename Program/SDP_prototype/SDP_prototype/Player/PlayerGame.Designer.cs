namespace SDP_prototype.Player
{
    partial class PlayerGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerGame));
            this.ComingSoon = new System.Windows.Forms.PictureBox();
            this.F1RacePicture = new System.Windows.Forms.PictureBox();
            this.WarZonePicture = new System.Windows.Forms.PictureBox();
            this.txtGameName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblGameName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblWarZone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblF1Race = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.WarZoneCollisionDetection = new System.Windows.Forms.Label();
            this.F1RaceCollisionDetection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComingSoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1RacePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarZonePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ComingSoon
            // 
            this.ComingSoon.Image = global::SDP_prototype.Properties.Resources.ComingSoon;
            this.ComingSoon.Location = new System.Drawing.Point(328, 332);
            this.ComingSoon.Name = "ComingSoon";
            this.ComingSoon.Size = new System.Drawing.Size(449, 227);
            this.ComingSoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComingSoon.TabIndex = 2;
            this.ComingSoon.TabStop = false;
            this.ComingSoon.MouseEnter += new System.EventHandler(this.ComingSoon_MouseEnter);
            // 
            // F1RacePicture
            // 
            this.F1RacePicture.Image = global::SDP_prototype.Properties.Resources.F1Race;
            this.F1RacePicture.Location = new System.Drawing.Point(328, 76);
            this.F1RacePicture.Name = "F1RacePicture";
            this.F1RacePicture.Size = new System.Drawing.Size(449, 250);
            this.F1RacePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F1RacePicture.TabIndex = 1;
            this.F1RacePicture.TabStop = false;
            this.F1RacePicture.MouseEnter += new System.EventHandler(this.F1RacePicture_MouseEnter);
            // 
            // WarZonePicture
            // 
            this.WarZonePicture.Image = global::SDP_prototype.Properties.Resources.WarZone;
            this.WarZonePicture.Location = new System.Drawing.Point(37, 76);
            this.WarZonePicture.Name = "WarZonePicture";
            this.WarZonePicture.Size = new System.Drawing.Size(276, 483);
            this.WarZonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WarZonePicture.TabIndex = 0;
            this.WarZonePicture.TabStop = false;
            this.WarZonePicture.MouseEnter += new System.EventHandler(this.WarZonePicture_MouseEnter);
            // 
            // txtGameName
            // 
            this.txtGameName.BackColor = System.Drawing.SystemColors.Control;
            this.txtGameName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtGameName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtGameName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtGameName.BorderThickness = 2;
            this.txtGameName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGameName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.txtGameName.isPassword = false;
            this.txtGameName.Location = new System.Drawing.Point(361, 15);
            this.txtGameName.Margin = new System.Windows.Forms.Padding(6);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Padding = new System.Windows.Forms.Padding(0, 0, 68, 0);
            this.txtGameName.Size = new System.Drawing.Size(255, 46);
            this.txtGameName.TabIndex = 5;
            this.txtGameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblGameName
            // 
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.lblGameName.Location = new System.Drawing.Point(73, 29);
            this.lblGameName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(280, 23);
            this.lblGameName.TabIndex = 6;
            this.lblGameName.Text = "Search the Game Detail By Name :";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGo
            // 
            this.btnGo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.BorderRadius = 0;
            this.btnGo.ButtonText = "Go";
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.DisabledColor = System.Drawing.Color.Gray;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnGo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGo.Iconimage")));
            this.btnGo.Iconimage_right = null;
            this.btnGo.Iconimage_right_Selected = null;
            this.btnGo.Iconimage_Selected = null;
            this.btnGo.IconMarginLeft = 0;
            this.btnGo.IconMarginRight = 0;
            this.btnGo.IconRightVisible = false;
            this.btnGo.IconRightZoom = 0D;
            this.btnGo.IconVisible = false;
            this.btnGo.IconZoom = 90D;
            this.btnGo.IsTab = false;
            this.btnGo.Location = new System.Drawing.Point(628, 15);
            this.btnGo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnGo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.btnGo.selected = false;
            this.btnGo.Size = new System.Drawing.Size(85, 48);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.btnGo.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblWarZone
            // 
            this.lblWarZone.BackColor = System.Drawing.Color.Transparent;
            this.lblWarZone.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblWarZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.lblWarZone.Location = new System.Drawing.Point(56, 281);
            this.lblWarZone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarZone.Name = "lblWarZone";
            this.lblWarZone.Size = new System.Drawing.Size(243, 45);
            this.lblWarZone.TabIndex = 8;
            this.lblWarZone.Text = "GSD War Zone";
            this.lblWarZone.Visible = false;
            // 
            // lblF1Race
            // 
            this.lblF1Race.BackColor = System.Drawing.Color.Transparent;
            this.lblF1Race.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblF1Race.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(121)))), ((int)(((byte)(208)))));
            this.lblF1Race.Location = new System.Drawing.Point(440, 179);
            this.lblF1Race.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF1Race.Name = "lblF1Race";
            this.lblF1Race.Size = new System.Drawing.Size(226, 45);
            this.lblF1Race.TabIndex = 8;
            this.lblF1Race.Text = "GSD F1 Race";
            this.lblF1Race.Visible = false;
            // 
            // WarZoneCollisionDetection
            // 
            this.WarZoneCollisionDetection.Location = new System.Drawing.Point(35, 76);
            this.WarZoneCollisionDetection.Name = "WarZoneCollisionDetection";
            this.WarZoneCollisionDetection.Size = new System.Drawing.Size(278, 483);
            this.WarZoneCollisionDetection.TabIndex = 9;
            this.WarZoneCollisionDetection.MouseEnter += new System.EventHandler(this.WarZoneCollisionDetection_MouseEnter);
            // 
            // F1RaceCollisionDetection
            // 
            this.F1RaceCollisionDetection.Location = new System.Drawing.Point(326, 76);
            this.F1RaceCollisionDetection.Name = "F1RaceCollisionDetection";
            this.F1RaceCollisionDetection.Size = new System.Drawing.Size(451, 250);
            this.F1RaceCollisionDetection.TabIndex = 9;
            this.F1RaceCollisionDetection.MouseEnter += new System.EventHandler(this.F1RaceCollisionDetection_MouseEnter);
            // 
            // PlayerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblF1Race);
            this.Controls.Add(this.lblWarZone);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.ComingSoon);
            this.Controls.Add(this.F1RacePicture);
            this.Controls.Add(this.WarZonePicture);
            this.Controls.Add(this.WarZoneCollisionDetection);
            this.Controls.Add(this.F1RaceCollisionDetection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerGame";
            this.Text = "PlayerGame";
            this.Load += new System.EventHandler(this.PlayerGame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerGame_MouseDown);
            this.MouseEnter += new System.EventHandler(this.PlayerGame_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ComingSoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1RacePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarZonePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WarZonePicture;
        private System.Windows.Forms.PictureBox F1RacePicture;
        private System.Windows.Forms.PictureBox ComingSoon;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGameName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGameName;
        private Bunifu.Framework.UI.BunifuFlatButton btnGo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWarZone;
        private Bunifu.Framework.UI.BunifuCustomLabel lblF1Race;
        private System.Windows.Forms.Label WarZoneCollisionDetection;
        private System.Windows.Forms.Label F1RaceCollisionDetection;
    }
}