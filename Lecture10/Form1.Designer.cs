namespace Lecture10
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.btnCreateControl = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.cbControlType = new System.Windows.Forms.ComboBox();
            this.lblControlType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Controls";
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNumberOfControls.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNumberOfControls.Location = new System.Drawing.Point(160, 54);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(270, 20);
            this.txtNumberOfControls.TabIndex = 1;
            // 
            // btnCreateControl
            // 
            this.btnCreateControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateControl.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreateControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateControl.Location = new System.Drawing.Point(60, 80);
            this.btnCreateControl.Name = "btnCreateControl";
            this.btnCreateControl.Size = new System.Drawing.Size(370, 29);
            this.btnCreateControl.TabIndex = 2;
            this.btnCreateControl.Text = "Create";
            this.btnCreateControl.UseVisualStyleBackColor = false;
            this.btnCreateControl.Click += new System.EventHandler(this.btnCreateControl_Click);
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(60, 116);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(370, 384);
            this.pnl.TabIndex = 3;
            // 
            // cbControlType
            // 
            this.cbControlType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbControlType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbControlType.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbControlType.FormattingEnabled = true;
            this.cbControlType.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.cbControlType.Location = new System.Drawing.Point(160, 29);
            this.cbControlType.Name = "cbControlType";
            this.cbControlType.Size = new System.Drawing.Size(270, 19);
            this.cbControlType.TabIndex = 4;
            // 
            // lblControlType
            // 
            this.lblControlType.AutoSize = true;
            this.lblControlType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblControlType.Font = new System.Drawing.Font("Yet R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblControlType.Location = new System.Drawing.Point(60, 36);
            this.lblControlType.Name = "lblControlType";
            this.lblControlType.Size = new System.Drawing.Size(72, 11);
            this.lblControlType.TabIndex = 5;
            this.lblControlType.Text = "Control Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(502, 540);
            this.Controls.Add(this.lblControlType);
            this.Controls.Add(this.cbControlType);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnCreateControl);
            this.Controls.Add(this.txtNumberOfControls);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Button btnCreateControl;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cbControlType;
        private System.Windows.Forms.Label lblControlType;
    }
}

