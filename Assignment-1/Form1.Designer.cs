namespace Assignment_1
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
            this.btnCreateControls = new System.Windows.Forms.Button();
            this.lblCreateControls = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.lblControlNumber = new System.Windows.Forms.Label();
            this.cbChooseControl = new System.Windows.Forms.ComboBox();
            this.lblChooseControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateControls
            // 
            this.btnCreateControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateControls.Location = new System.Drawing.Point(266, 82);
            this.btnCreateControls.Name = "btnCreateControls";
            this.btnCreateControls.Size = new System.Drawing.Size(212, 23);
            this.btnCreateControls.TabIndex = 0;
            this.btnCreateControls.Text = "Create Controls";
            this.btnCreateControls.UseVisualStyleBackColor = true;
            this.btnCreateControls.Click += new System.EventHandler(this.btnCreateControls_Click);
            // 
            // lblCreateControls
            // 
            this.lblCreateControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateControls.AutoSize = true;
            this.lblCreateControls.Location = new System.Drawing.Point(163, 87);
            this.lblCreateControls.Name = "lblCreateControls";
            this.lblCreateControls.Size = new System.Drawing.Size(74, 13);
            this.lblCreateControls.TabIndex = 1;
            this.lblCreateControls.Text = "Create Control";
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(166, 172);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(312, 362);
            this.p1.TabIndex = 2;
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Location = new System.Drawing.Point(266, 115);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(212, 20);
            this.txtNumberOfControls.TabIndex = 3;
            // 
            // lblControlNumber
            // 
            this.lblControlNumber.AutoSize = true;
            this.lblControlNumber.Location = new System.Drawing.Point(163, 118);
            this.lblControlNumber.Name = "lblControlNumber";
            this.lblControlNumber.Size = new System.Drawing.Size(97, 13);
            this.lblControlNumber.TabIndex = 4;
            this.lblControlNumber.Text = "Number of Controls";
            // 
            // cbChooseControl
            // 
            this.cbChooseControl.FormattingEnabled = true;
            this.cbChooseControl.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.cbChooseControl.Location = new System.Drawing.Point(266, 145);
            this.cbChooseControl.Name = "cbChooseControl";
            this.cbChooseControl.Size = new System.Drawing.Size(212, 21);
            this.cbChooseControl.TabIndex = 5;
            // 
            // lblChooseControl
            // 
            this.lblChooseControl.AutoSize = true;
            this.lblChooseControl.Location = new System.Drawing.Point(163, 148);
            this.lblChooseControl.Name = "lblChooseControl";
            this.lblChooseControl.Size = new System.Drawing.Size(79, 13);
            this.lblChooseControl.TabIndex = 6;
            this.lblChooseControl.Text = "Choose Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 558);
            this.Controls.Add(this.lblChooseControl);
            this.Controls.Add(this.cbChooseControl);
            this.Controls.Add(this.lblControlNumber);
            this.Controls.Add(this.txtNumberOfControls);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lblCreateControls);
            this.Controls.Add(this.btnCreateControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateControls;
        private System.Windows.Forms.Label lblCreateControls;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Label lblControlNumber;
        private System.Windows.Forms.ComboBox cbChooseControl;
        private System.Windows.Forms.Label lblChooseControl;
    }
}

