namespace SDP_prototype
{
    partial class MenuDemo2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EnquireGameDetail = new System.Windows.Forms.Button();
            this.ViewGamePromotion = new System.Windows.Forms.Button();
            this.EnquirePlayerInformation = new System.Windows.Forms.Button();
            this.TopUpBalanceByPointCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnquireGameDetail
            // 
            this.EnquireGameDetail.Location = new System.Drawing.Point(81, 68);
            this.EnquireGameDetail.Margin = new System.Windows.Forms.Padding(4);
            this.EnquireGameDetail.Name = "EnquireGameDetail";
            this.EnquireGameDetail.Size = new System.Drawing.Size(396, 48);
            this.EnquireGameDetail.TabIndex = 0;
            this.EnquireGameDetail.Text = "Enquire Game Detail";
            this.EnquireGameDetail.UseVisualStyleBackColor = true;
            this.EnquireGameDetail.Click += new System.EventHandler(this.EnquireGameDetail_Click);
            // 
            // ViewGamePromotion
            // 
            this.ViewGamePromotion.Location = new System.Drawing.Point(81, 153);
            this.ViewGamePromotion.Margin = new System.Windows.Forms.Padding(4);
            this.ViewGamePromotion.Name = "ViewGamePromotion";
            this.ViewGamePromotion.Size = new System.Drawing.Size(396, 57);
            this.ViewGamePromotion.TabIndex = 0;
            this.ViewGamePromotion.Text = "View Game Promotion and Point Card information";
            this.ViewGamePromotion.UseVisualStyleBackColor = true;
            this.ViewGamePromotion.Click += new System.EventHandler(this.ViewGamePromotion_Click);
            // 
            // EnquirePlayerInformation
            // 
            this.EnquirePlayerInformation.Location = new System.Drawing.Point(81, 243);
            this.EnquirePlayerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.EnquirePlayerInformation.Name = "EnquirePlayerInformation";
            this.EnquirePlayerInformation.Size = new System.Drawing.Size(396, 56);
            this.EnquirePlayerInformation.TabIndex = 0;
            this.EnquirePlayerInformation.Text = "Enquire Player Information and Game Progress";
            this.EnquirePlayerInformation.UseVisualStyleBackColor = true;
            this.EnquirePlayerInformation.Click += new System.EventHandler(this.EnquirePlayerInformation_Click);
            // 
            // TopUpBalanceByPointCard
            // 
            this.TopUpBalanceByPointCard.Location = new System.Drawing.Point(81, 344);
            this.TopUpBalanceByPointCard.Margin = new System.Windows.Forms.Padding(4);
            this.TopUpBalanceByPointCard.Name = "TopUpBalanceByPointCard";
            this.TopUpBalanceByPointCard.Size = new System.Drawing.Size(396, 48);
            this.TopUpBalanceByPointCard.TabIndex = 0;
            this.TopUpBalanceByPointCard.Text = "Top-up balance by Point Card";
            this.TopUpBalanceByPointCard.UseVisualStyleBackColor = true;
            this.TopUpBalanceByPointCard.Click += new System.EventHandler(this.TopUpBalanceByPointCard_Click);
            // 
            // PlayerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 472);
            this.Controls.Add(this.TopUpBalanceByPointCard);
            this.Controls.Add(this.EnquirePlayerInformation);
            this.Controls.Add(this.ViewGamePromotion);
            this.Controls.Add(this.EnquireGameDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerMainMenu";
            this.Text = "HKIVE Game Entertainment Point Card System - Player Main Menu";
            this.Load += new System.EventHandler(this.PlayerMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnquireGameDetail;
        private System.Windows.Forms.Button ViewGamePromotion;
        private System.Windows.Forms.Button EnquirePlayerInformation;
        private System.Windows.Forms.Button TopUpBalanceByPointCard;
    }
}

