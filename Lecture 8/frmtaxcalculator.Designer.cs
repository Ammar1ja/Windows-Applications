namespace Lecture_8
{
    partial class Form1
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblFinalTax = new System.Windows.Forms.Label();
            this.txtFinalTax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(210, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(148, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(168, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxRate.Location = new System.Drawing.Point(491, 60);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(54, 16);
            this.lblTaxRate.TabIndex = 2;
            this.lblTaxRate.Text = "Tax Rate";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(427, 79);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(165, 20);
            this.txtTaxRate.TabIndex = 3;
            // 
            // lblFinalTax
            // 
            this.lblFinalTax.AutoSize = true;
            this.lblFinalTax.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTax.Location = new System.Drawing.Point(344, 249);
            this.lblFinalTax.Name = "lblFinalTax";
            this.lblFinalTax.Size = new System.Drawing.Size(54, 16);
            this.lblFinalTax.TabIndex = 4;
            this.lblFinalTax.Text = "Final Tax";
            // 
            // txtFinalTax
            // 
            this.txtFinalTax.Enabled = false;
            this.txtFinalTax.Location = new System.Drawing.Point(263, 268);
            this.txtFinalTax.Name = "txtFinalTax";
            this.txtFinalTax.Size = new System.Drawing.Size(221, 20);
            this.txtFinalTax.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Tax";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFinalTax);
            this.Controls.Add(this.lblFinalTax);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lblFinalTax;
        private System.Windows.Forms.TextBox txtFinalTax;
        private System.Windows.Forms.Button button1;
    }
}

