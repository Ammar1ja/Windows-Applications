﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tishreeen_Restaurant
{
    public partial class Form1 : Form
    {
        public static bool IsAdmin = false;
        public static int UId = -3;
        DataClassDataContext db = new DataClassDataContext();
        public Form1()
        {
            User user = new User();


            user.UName = "Ahmadammar";
            user.UPassword = "Ahmadammar";
            user.URole = true;
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();

            User admin = new User();

            admin.UName = "Admin";
            admin.UPassword = "Admin";
            admin.URole = false;
            db.Users.InsertOnSubmit(admin);
            db.SubmitChanges();
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Username = txtName.Text;
            var password = txtPassword.Text;
            var User = db.Users.Where(u => u.UName == Username && u.UPassword == password).Select(s => s);

            int id = 0;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "this field is required!!");
            }
            else
            {
                if (User.Count() > 0)
                {
                    UId = id = User.FirstOrDefault().Id;

                    IsAdmin = User.FirstOrDefault().URole;
                    if (!IsAdmin)
                    {
                        CashiersPanel cp = new CashiersPanel();
                        cp.Show();
                    }
                    else
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "are you sure you want exit?";
            string title = "Exit Application";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
