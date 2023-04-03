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
            // this.Controls.Add(new Label());
            
        }

        private void btnCreateControl_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtNumberOfControls.Text);
            if (cbControlType.Text == "Button")
            {
                
                for (int i = 0; i < numberOfControls; ++i)
                {
                    Button newButton = new Button();
                    newButton.Name = "btn" + (i+1);
                    newButton.Text = "New Button " + (i+1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (50 * i));
                    pnl.Controls.Add(newButton);
                }
            }
            else if (cbControlType.Text == "TextBox")
            {
                for (int i = 0; i < numberOfControls; ++i)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Name = "txt" + (i + 1);
                    newTextBox.Text = "New TextBox " + (i + 1);
                    newTextBox.Size = new Size(120, 40);
                    newTextBox.Location = new Point(0, (50 * i));
                    pnl.Controls.Add(newTextBox);
                }
            }
            else if (cbControlType.Text == "Label") 
            {
                for (int i = 0; i < numberOfControls; ++i)
                {
                    Label newLabel = new Label();
                    newLabel.Name = "lbl" + (i + 1);
                    newLabel.Text = "New Label " + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(0, (50 * i));
                    pnl.Controls.Add(newLabel);
                }
            }
           
        }
    }
}
