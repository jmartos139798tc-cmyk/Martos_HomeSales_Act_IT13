namespace Martos_HomeSales_Activity
{
    partial class FrmSalesSummary
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
            this.lblReportBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReportBody
            // 
            this.lblReportBody.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblReportBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReportBody.Location = new System.Drawing.Point(235, 25);
            this.lblReportBody.Name = "lblReportBody";
            this.lblReportBody.Size = new System.Drawing.Size(361, 298);
            this.lblReportBody.TabIndex = 0;
            this.lblReportBody.Text = "label1";
            // 
            // FrmSalesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReportBody);
            this.Name = "FrmSalesSummary";
            this.Text = "FrmSalesSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportBody;
    }
}