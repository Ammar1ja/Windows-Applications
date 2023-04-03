using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        private void btnCreateControl_Click(object sender, EventArgs e)
        {
            // Getting the number of controls from the user
            int numberOfControls = int.Parse(txtNumberOfControls.Text);
            // Creating Object to use addControl methods
            CreateControls createControls = new CreateControls();
            if (cbControlType.Text == "Button")
            {
                // call create new button method and give it three things (number of controls , Type of Control , Panel)
                createControls.createNewButton(numberOfControls,"Button", pnl);
            }
            else if (cbControlType.Text == "TextBox")
            {
                // call create new TextBox method and give it three things (number of controls , Type of Control , Panel)
                createControls.createNewTextBox(numberOfControls, "TextBox", pnl);
            }
            else if (cbControlType.Text == "Label") 
            {
                // call create new Label method and give it three things (number of controls , Type of Control , Panel)
                createControls.createNewLabel(numberOfControls, "Label", pnl);
            }
        }
    }
}
