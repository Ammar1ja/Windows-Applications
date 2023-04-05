using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture11
{
    public partial class frmLogin : Form
    {
        // Create 5 objects from User class.
        private User user1;
        private User user2;
        private User user3;
        private User user4;
        private User user5;
        // Create list of users.
        private List<User> users;
        
        public frmLogin()
        {
            InitializeComponent();
            users = new List<User>();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // User 1
            user1 = new User();
            users.Add(user1);
            user1.userId = 1124;
            user1.fullName = "Ammar Jaber";
            user1.userName = "AJ";
            user1.password = "Ammar1ja";
            // User 2
            user2 = new User();
            users.Add(user2);
            user2.userId = 4254;
            user2.fullName = "Ahmad Shraim";
            user2.userName = "AS";
            user2.password = "Ahmad";
            // User 3
            user3 = new User();
            users.Add(user3);
            user3.userId = 6236;
            user3.fullName = "Ismael arkad";
            user3.userName = "IA";
            user3.password = "Ismael";
            // User 4
            user4 = new User();
            users.Add(user4);
            user4.userId = 7686;
            user4.fullName = "Hashem Mahmoud";
            user4.userName = "HM";
            user4.password = "Hashem";
            // User 5
            user5 = new User();
            users.Add(user5);
            user5.userId = 2346;
            user5.fullName = "Ahmad Barghash";
            user5.userName = "AB";
            user5.password = "Ahmad";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // boolean expretion to check if the user is found or not.
            bool foundUser = false;
            // for loop from 0 to the length of the users list.
            for (int i=0;i<users.Count; ++i) 
            {
                if (users[i].userName == txtUserName.Text && users[i].password == txtPassword.Text)
                {
                    MessageBox.Show("Login Successfully");
                    foundUser = true;
                    // if we found the user name and password there is no need to continue(thats why i use break).
                    break;
                }
            }
            // after fishing the loop we will see the result of the boolean expretion to check if the user was'nt found to print the message box.
            if (foundUser == false) 
            {
                    MessageBox.Show("Username or Password is incorrect !");
            }
        }
    }
}
