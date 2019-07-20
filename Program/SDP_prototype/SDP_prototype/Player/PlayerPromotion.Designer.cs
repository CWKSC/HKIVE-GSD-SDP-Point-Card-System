namespace SDP_prototype.Player
{
    partial class PlayerPromotion
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
            this.lblPromotion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblPromotion
            // 
            this.lblPromotion.BackColor = System.Drawing.Color.Transparent;
            this.lblPromotion.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.lblPromotion.Location = new System.Drawing.Point(34, 30);
            this.lblPromotion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(725, 531);
            this.lblPromotion.TabIndex = 6;
            this.lblPromotion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblPromotion_MouseDown);
            // 
            // PlayerPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblPromotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerPromotion";
            this.Text = "PlayerPromotion";
            this.Load += new System.EventHandler(this.PlayerPromotion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerPromotion_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblPromotion;
    }
}