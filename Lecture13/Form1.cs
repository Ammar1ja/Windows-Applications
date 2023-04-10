using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the key wasn't letter or spetial charachter ignor it 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) 
                e.Handled = true;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the key wasn't Digit or spetial charachter ignor it 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
            }
        }
    }
}
