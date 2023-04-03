using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtNumberOfControls.Text);
            if (cbChooseControl.Text == "Button")
            {
                for (int i = 0; i < numberOfControls; ++i)
                {
                    // create a button control
                    Button newButton = new Button();
                    // give the button some properties
                    newButton.Name = "btn" + (i + 1);
                    newButton.Text = "button " + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (50 * i));
                    // add the control to the panel
                    p1.Controls.Add(newButton);
                }
            }
            else if (cbChooseControl.Text == "TextBox")
            {
                for (int i = 0; i < numberOfControls; ++i)
                {
                    // create a button control
                    TextBox newTextBox = new TextBox();
                    // give the button some properties
                    newTextBox.Name = "txt" + (i + 1);
                    newTextBox.Text = "TextBox " + (i + 1);
                    newTextBox.Size = new Size(120, 40);
                    newTextBox.Location = new Point(0, (50 * i));
                    // add the control to the panel
                    p1.Controls.Add(newTextBox);
                }
            }
            else if (cbChooseControl.Text == "Label") 
            {
                for (int i = 0; i < numberOfControls; ++i)
                {
                    // create a button control
                    Label newLabel = new Label();
                    // give the button some properties
                    newLabel.Name = "txt" + (i + 1);
                    newLabel.Text = "TextBox " + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(0, (50 * i));
                    // add the control to the panel
                    p1.Controls.Add(newLabel);
                }
            }




















           
        }
    }
}
