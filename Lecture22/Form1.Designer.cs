namespace Lecture22
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lecture21DataSet = new Lecture22.Lecture21DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Lecture22.Lecture21DataSetTableAdapters.StudentsTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetStudentById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(60, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(330, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(59, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(0, 130);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(414, 320);
            this.dgvStudents.TabIndex = 5;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
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
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(144, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(231, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetStudentById
            // 
            this.btnGetStudentById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetStudentById.Location = new System.Drawing.Point(315, 88);
            this.btnGetStudentById.Name = "btnGetStudentById";
            this.btnGetStudentById.Size = new System.Drawing.Size(76, 36);
            this.btnGetStudentById.TabIndex = 8;
            this.btnGetStudentById.Text = "Get Stu";
            this.btnGetStudentById.UseVisualStyleBackColor = false;
            this.btnGetStudentById.Click += new System.EventHandler(this.btnGetStudentById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.btnGetStudentById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStudents;
        private Lecture21DataSet lecture21DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Lecture21DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetStudentById;
    }
}

