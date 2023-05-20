using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_21_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lecture21DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.lecture21DataSet.Students);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
