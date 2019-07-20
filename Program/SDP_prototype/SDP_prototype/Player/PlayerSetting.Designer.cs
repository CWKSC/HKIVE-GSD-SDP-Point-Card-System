namespace SDP_prototype.Player
{
    partial class PlayerSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSetting));
            this.btnChangeLanguage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblLanguage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnChangeLanguage.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeLanguage.BorderRadius = 0;
            this.btnChangeLanguage.ButtonText = "Change to Chinese";
            this.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeLanguage.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangeLanguage.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnChangeLanguage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangeLanguage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangeLanguage.Iconimage")));
            this.btnChangeLanguage.Iconimage_right = null;
            this.btnChangeLanguage.Iconimage_right_Selected = null;
            this.btnChangeLanguage.Iconimage_Selected = null;
            this.btnChangeLanguage.IconMarginLeft = 0;
            this.btnChangeLanguage.IconMarginRight = 0;
            this.btnChangeLanguage.IconRightVisible = false;
            this.btnChangeLanguage.IconRightZoom = 0D;
            this.btnChangeLanguage.IconVisible = false;
            this.btnChangeLanguage.IconZoom = 90D;
            this.btnChangeLanguage.IsTab = false;
            this.btnChangeLanguage.Location = new System.Drawing.Point(198, 66);
            this.btnChangeLanguage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChangeLanguage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnChangeLanguage.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnChangeLanguage.selected = false;
            this.btnChangeLanguage.Size = new System.Drawing.Size(231, 49);
            this.btnChangeLanguage.TabIndex = 11;
            this.btnChangeLanguage.Text = "Change to Chinese";
            this.btnChangeLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeLanguage.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnChangeLanguage.TextFont = new System.Drawing.Font("Century Gothic", 16F);
            this.btnChangeLanguage.Click += new System.EventHandler(this.BtnChangeLanguage_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblLanguage.Location = new System.Drawing.Point(68, 77);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(135, 28);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Language: ";
            // 
            // PlayerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.lblLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerSetting";
            this.Text = "PlayerSetting";
            this.Load += new System.EventHandler(this.PlayerSetting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerSetting_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnChangeLanguage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLanguage;
    }
}