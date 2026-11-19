namespace Martos_HomeSales_Activity
{
    partial class FrmSalesHouse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Initial = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_Initial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_Output);
            this.panel1.Controls.Add(this.Btn_Submit);
            this.panel1.Controls.Add(this.Btn_Print);
            this.panel1.Controls.Add(this.Btn_Clear);
            this.panel1.Controls.Add(this.txt_Amount);
            this.panel1.Controls.Add(this.txt_Initial);
            this.panel1.Controls.Add(this.lbl_amount);
            this.panel1.Controls.Add(this.lbl_Initial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 366);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Output
            // 
            this.lbl_Output.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Output.Location = new System.Drawing.Point(37, 261);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(397, 91);
            this.lbl_Output.TabIndex = 4;
            this.lbl_Output.Text = "Ready to enter sales...";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Submit.Location = new System.Drawing.Point(184, 194);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(72, 40);
            this.Btn_Submit.TabIndex = 3;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print.Location = new System.Drawing.Point(340, 194);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(72, 40);
            this.Btn_Print.TabIndex = 3;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = false;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(262, 194);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(72, 40);
            this.Btn_Clear.TabIndex = 3;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Amount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(197, 140);
            this.txt_Amount.Multiline = true;
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(215, 30);
            this.txt_Amount.TabIndex = 2;
            // 
            // txt_Initial
            // 
            this.txt_Initial.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Initial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Initial.Location = new System.Drawing.Point(197, 88);
            this.txt_Initial.Multiline = true;
            this.txt_Initial.Name = "txt_Initial";
            this.txt_Initial.Size = new System.Drawing.Size(215, 30);
            this.txt_Initial.TabIndex = 2;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_amount.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_amount.Location = new System.Drawing.Point(17, 145);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(111, 21);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount of Sale :";
            // 
            // lbl_Initial
            // 
            this.lbl_Initial.AutoSize = true;
            this.lbl_Initial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Initial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Initial.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Initial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Initial.Location = new System.Drawing.Point(17, 94);
            this.lbl_Initial.Name = "lbl_Initial";
            this.lbl_Initial.Size = new System.Drawing.Size(174, 21);
            this.lbl_Initial.TabIndex = 1;
            this.lbl_Initial.Text = "Enter Sales Person Initial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesperson Codes:  [ D - Danielle ]     [ E - Edward ]     [ F - Fatima ]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSalesHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 389);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSalesHouse";
            this.Text = "Home Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Initial;
        private System.Windows.Forms.TextBox txt_Initial;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_amount;
    }
}

