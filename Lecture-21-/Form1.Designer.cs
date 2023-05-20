namespace Lecture_21_
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
            this.components = new System.ComponentModel.Container();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lecture21DataSet = new Lecture_21_.Lecture21DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Lecture_21_.Lecture21DataSetTableAdapters.StudentsTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(0, 300);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(481, 150);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lecture21DataSet
            // 
            this.lecture21DataSet.DataSetName = "Lecture21DataSet";
            this.lecture21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.lecture21DataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(51, 102);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(133, 99);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(257, 20);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(133, 50);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(257, 20);
            this.txtStudentID.TabIndex = 4;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(54, 54);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblStudentId.TabIndex = 3;
            this.lblStudentId.Text = "Student ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(223, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(132, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Location = new System.Drawing.Point(314, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private Lecture21DataSet lecture21DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Lecture21DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

