namespace SDP_prototype.Player
{
    partial class PlayerProfile_ViewPointCardHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerProfile_ViewPointCardHistory));
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPointCardHistory = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClose.Iconcolor = System.Drawing.SystemColors.Control;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = false;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = false;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(746, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.Black;
            this.btnClose.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPointCardHistory
            // 
            this.lblPointCardHistory.BorderColor = System.Drawing.Color.SeaGreen;
            this.lblPointCardHistory.Font = new System.Drawing.Font("Malgun Gothic", 16.25F);
            this.lblPointCardHistory.Location = new System.Drawing.Point(51, 61);
            this.lblPointCardHistory.Multiline = true;
            this.lblPointCardHistory.Name = "lblPointCardHistory";
            this.lblPointCardHistory.ReadOnly = true;
            this.lblPointCardHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblPointCardHistory.Size = new System.Drawing.Size(688, 476);
            this.lblPointCardHistory.TabIndex = 15;
            // 
            // PlayerProfile_ViewPointCardHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblPointCardHistory);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerProfile_ViewPointCardHistory";
            this.Text = "PlayerProfile_ViewPointCardHistory";
            this.Load += new System.EventHandler(this.PlayerProfile_ViewPointCardHistory_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerProfile_ViewPointCardHistory_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox lblPointCardHistory;
    }
}