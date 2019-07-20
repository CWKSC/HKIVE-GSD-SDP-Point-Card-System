namespace SDP_prototype.Staff
{
    partial class StaffReceiveProblems
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
            this.lblReceiveProblem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // lblReceiveProblem
            // 
            this.lblReceiveProblem.BorderColor = System.Drawing.Color.SeaGreen;
            this.lblReceiveProblem.Font = new System.Drawing.Font("Malgun Gothic", 16.25F);
            this.lblReceiveProblem.Location = new System.Drawing.Point(56, 51);
            this.lblReceiveProblem.Multiline = true;
            this.lblReceiveProblem.Name = "lblReceiveProblem";
            this.lblReceiveProblem.ReadOnly = true;
            this.lblReceiveProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblReceiveProblem.Size = new System.Drawing.Size(700, 500);
            this.lblReceiveProblem.TabIndex = 9;
            // 
            // StaffReceiveProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblReceiveProblem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffReceiveProblems";
            this.Text = "StaffReceiveProblems";
            this.Load += new System.EventHandler(this.StaffReceiveProblems_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StaffReceiveProblems_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox lblReceiveProblem;
    }
}