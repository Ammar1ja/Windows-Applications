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
            int numberOfControls = int.Parse(txtNumberOfControls.Text);
            CreateControls createControls = new CreateControls();
            if (cbControlType.Text == "Button")
            {
                createControls.createNewButton(numberOfControls,"Button", pnl);
            }
            else if (cbControlType.Text == "TextBox")
            {
                createControls.createNewTextBox(numberOfControls, "TextBox", pnl);
            }
            else if (cbControlType.Text == "Label") 
            {
                createControls.createNewLabel(numberOfControls, "Label", pnl);
            }
        }
    }
}
