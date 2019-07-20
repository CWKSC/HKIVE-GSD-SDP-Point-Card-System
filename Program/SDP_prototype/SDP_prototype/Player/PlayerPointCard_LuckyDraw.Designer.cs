namespace SDP_prototype.Player
{
    partial class PlayerPointCard_LuckyDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPointCard_LuckyDraw));
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLessThan5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblRandomNum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGreaterThan5 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.btnClose.Location = new System.Drawing.Point(573, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.Black;
            this.btnClose.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnLessThan5
            // 
            this.btnLessThan5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLessThan5.BackColor = System.Drawing.Color.Transparent;
            this.btnLessThan5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLessThan5.BorderRadius = 0;
            this.btnLessThan5.ButtonText = "<= 5";
            this.btnLessThan5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLessThan5.DisabledColor = System.Drawing.Color.Gray;
            this.btnLessThan5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnLessThan5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLessThan5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLessThan5.Iconimage")));
            this.btnLessThan5.Iconimage_right = null;
            this.btnLessThan5.Iconimage_right_Selected = null;
            this.btnLessThan5.Iconimage_Selected = null;
            this.btnLessThan5.IconMarginLeft = 0;
            this.btnLessThan5.IconMarginRight = 0;
            this.btnLessThan5.IconRightVisible = false;
            this.btnLessThan5.IconRightZoom = 0D;
            this.btnLessThan5.IconVisible = false;
            this.btnLessThan5.IconZoom = 90D;
            this.btnLessThan5.IsTab = false;
            this.btnLessThan5.Location = new System.Drawing.Point(217, 218);
            this.btnLessThan5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLessThan5.Name = "btnLessThan5";
            this.btnLessThan5.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLessThan5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLessThan5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnLessThan5.selected = false;
            this.btnLessThan5.Size = new System.Drawing.Size(91, 64);
            this.btnLessThan5.TabIndex = 20;
            this.btnLessThan5.Text = "<= 5";
            this.btnLessThan5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLessThan5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnLessThan5.TextFont = new System.Drawing.Font("Century Gothic", 20F);
            this.btnLessThan5.Click += new System.EventHandler(this.BtnLessThan5_Click);
            // 
            // lblRandomNum
            // 
            this.lblRandomNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRandomNum.Font = new System.Drawing.Font("Century Gothic", 70F);
            this.lblRandomNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblRandomNum.Location = new System.Drawing.Point(237, 67);
            this.lblRandomNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandomNum.Name = "lblRandomNum";
            this.lblRandomNum.Size = new System.Drawing.Size(158, 118);
            this.lblRandomNum.TabIndex = 19;
            this.lblRandomNum.Text = "10";
            this.lblRandomNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 314);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(581, 36);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "( If the guessing is correct, will increase your gold coins ! )";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnGreaterThan5
            // 
            this.btnGreaterThan5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnGreaterThan5.BackColor = System.Drawing.Color.Transparent;
            this.btnGreaterThan5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreaterThan5.BorderRadius = 0;
            this.btnGreaterThan5.ButtonText = "> 5";
            this.btnGreaterThan5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreaterThan5.DisabledColor = System.Drawing.Color.Gray;
            this.btnGreaterThan5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnGreaterThan5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGreaterThan5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGreaterThan5.Iconimage")));
            this.btnGreaterThan5.Iconimage_right = null;
            this.btnGreaterThan5.Iconimage_right_Selected = null;
            this.btnGreaterThan5.Iconimage_Selected = null;
            this.btnGreaterThan5.IconMarginLeft = 0;
            this.btnGreaterThan5.IconMarginRight = 0;
            this.btnGreaterThan5.IconRightVisible = false;
            this.btnGreaterThan5.IconRightZoom = 0D;
            this.btnGreaterThan5.IconVisible = false;
            this.btnGreaterThan5.IconZoom = 90D;
            this.btnGreaterThan5.IsTab = false;
            this.btnGreaterThan5.Location = new System.Drawing.Point(324, 218);
            this.btnGreaterThan5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGreaterThan5.Name = "btnGreaterThan5";
            this.btnGreaterThan5.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGreaterThan5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnGreaterThan5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnGreaterThan5.selected = false;
            this.btnGreaterThan5.Size = new System.Drawing.Size(91, 64);
            this.btnGreaterThan5.TabIndex = 20;
            this.btnGreaterThan5.Text = "> 5";
            this.btnGreaterThan5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGreaterThan5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btnGreaterThan5.TextFont = new System.Drawing.Font("Century Gothic", 20F);
            this.btnGreaterThan5.Click += new System.EventHandler(this.BtnGreaterThan5_Click);
            // 
            // PlayerPointCard_LuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 391);
            this.Controls.Add(this.btnGreaterThan5);
            this.Controls.Add(this.btnLessThan5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblRandomNum);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerPointCard_LuckyDraw";
            this.Text = "PlayerPointCard_LuckyDraw";
            this.Load += new System.EventHandler(this.PlayerPointCard_LuckyDraw_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerPointCard_LuckyDraw_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnLessThan5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRandomNum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGreaterThan5;
    }
}