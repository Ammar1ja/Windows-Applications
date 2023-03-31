using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTakeValues_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(int.Parse(txtId.Text), txtName.Text, txtDateOfBirth.Value);
            MessageBox.Show(newEmployee.employeeInfo());
        }

        private void btnCreateTextBox_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(int.Parse(txtId.Text), txtName.Text, txtDateOfBirth.Value);
            TextBox newTextBox = new TextBox();
            newTextBox.Text = newEmployee.name;
            panel1.Controls.Add(newTextBox);
        }
    }
}
