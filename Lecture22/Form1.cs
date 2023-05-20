using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// connection to the database
using System.Data.SqlClient;

namespace Lecture22
{
    public partial class Form1 : Form
    {
        // to connect to the database
        string connectionString = "Data Source=.;Initial Catalog=Lecture21;Integrated Security=True";
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refereshDataGridView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
                   
            // if u want to run any sql command on sql server from ur application you need to use SqlCommand
            string stringCommand = $"Insert into Students(StudentName) values('{txtName.Text}')";
            SqlCommand command = new SqlCommand(stringCommand, connection);
            // to run the command on SQL server from your application
            connection.Open();
            command.ExecuteNonQuery(); // this will execute commands that are not queries (not select)
            connection.Close();
            refereshDataGridView();
            txtName.Text = "";
            MessageBox.Show("Added");
        }
        private void refereshDataGridView() 
        {
            // if u want to run any sql command on sql server from ur application you need to use SqlCommand
            string stringCommand = $"Select * from Students";
            SqlCommand command = new SqlCommand(stringCommand, connection);
            // ناقل لل Data
            SqlDataAdapter da = new SqlDataAdapter(command);
            // نسخة بالميموري من الداتا تيبل الموجود
            DataTable dt = new DataTable();
            // fill the data table from database
            da.Fill(dt);
            dgvStudents.DataSource = dt;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // if u want to run any sql command on sql server from ur application you need to use SqlCommand
            string stringCommand = $"Update Students set StudentName = '{txtName.Text}' where StudentId = {txtId.Text}";
            SqlCommand command = new SqlCommand(stringCommand, connection);
            // to run the command on SQL server from your application
            connection.Open();
            command.ExecuteNonQuery(); // this will execute commands that are not queries (not select)
            connection.Close();
            refereshDataGridView();
            txtName.Text = "";
            MessageBox.Show("Updated");
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // if u want to run any sql command on sql server from ur application you need to use SqlCommand
            string stringCommand = $"Delete from Students where StudentId = {txtId.Text}";
            SqlCommand command = new SqlCommand(stringCommand, connection);
            // to run the command on SQL server from your application
            connection.Open();
            command.ExecuteNonQuery(); // this will execute commands that are not queries (not select)
            connection.Close();
            refereshDataGridView();
            txtName.Text = "";
            txtId.Text = "";
            MessageBox.Show("Deleted");
        }
        private string getStudentById(string studentId) 
        {
            string studentReport = "";
            if (!string.IsNullOrEmpty(studentId))
            {
                string commandString = $"Select * from Students where studentId = {studentId}";
                SqlCommand command = new SqlCommand(commandString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    studentReport = reader.GetInt32(0).ToString() + "\n\n" + reader.GetString(1);

                }
                connection.Close();
               
            }
            else 
            {
                studentReport = "Record does not exist";
            }
            return studentReport;
        }
        private void btnGetStudentById_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getStudentById(txtId.Text));
        }
    }
}
