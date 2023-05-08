using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            // show specifice images
            openFileDialog.Filter = "|Image Files|*.jpg;*.png;";
            // show the file dialog
            openFileDialog.ShowDialog();
            // save the file name in string 
            string fileName = openFileDialog.FileName;
            // put the path into the image to be shown to the user
            pictureBox1.ImageLocation = fileName;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.name = txtName.Text;
            newUser.dateOfBirth = dtpUser.Value; 
            newUser.imageLocation = openFileDialog.FileName;
        }
    }
}

