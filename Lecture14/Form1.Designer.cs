namespace Lecture14
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbxCountries = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCountries = new System.Windows.Forms.TextBox();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.txtSelectedListBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbxCountries
            // 
            this.lbxCountries.FormattingEnabled = true;
            this.lbxCountries.Location = new System.Drawing.Point(30, 161);
            this.lbxCountries.Name = "lbxCountries";
            this.lbxCountries.Size = new System.Drawing.Size(287, 95);
            this.lbxCountries.TabIndex = 2;
            this.lbxCountries.SelectedIndexChanged += new System.EventHandler(this.lbxCountries_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCountries
            // 
            this.txtCountries.Location = new System.Drawing.Point(112, 265);
            this.txtCountries.Name = "txtCountries";
            this.txtCountries.Size = new System.Drawing.Size(205, 20);
            this.txtCountries.TabIndex = 7;
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(112, 129);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(205, 20);
            this.txtCombo.TabIndex = 9;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(30, 127);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 8;
            this.btnCombo.Text = "Add Item";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(523, 100);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(111, 13);
            this.lblSelected.TabIndex = 10;
            this.lblSelected.Text = "Selected text box item";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(526, 127);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(179, 20);
            this.txtSelected.TabIndex = 11;
            // 
            // txtSelectedListBox
            // 
            this.txtSelectedListBox.Location = new System.Drawing.Point(526, 210);
            this.txtSelectedListBox.Name = "txtSelectedListBox";
            this.txtSelectedListBox.Size = new System.Drawing.Size(179, 20);
            this.txtSelectedListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "List Box Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.txtSelectedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.txtCountries);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCountries);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbxCountries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCountries;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.TextBox txtSelectedListBox;
        private System.Windows.Forms.Label label1;
    }
}

