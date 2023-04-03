using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10
{
    internal class CreateControls
    {      
        public void createNewButton(int numberOfControls, string controlType, Panel panel) 
        {
            for (int i = 0; i < numberOfControls; ++i)
            {
                Button newButton = new Button();
                newButton.Name = "btn" + (i + 1);
                newButton.Text = "New Button " + (i + 1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point(0, (50 * i));
                panel.Controls.Add(newButton);
            }
        }
        public void createNewTextBox(int numberOfControls, string controlType, Panel panel) 
        {
            for (int i = 0; i < numberOfControls; ++i)
            {
                TextBox newTextBox = new TextBox();
                newTextBox.Name = "txt" + (i + 1);
                newTextBox.Text = "New TextBox " + (i + 1);
                newTextBox.Size = new Size(120, 40);
                newTextBox.Location = new Point(0, (50 * i));
                panel.Controls.Add(newTextBox);
            }
        }
        public void createNewLabel(int numberOfControls, string controlType, Panel panel)
        {
            for (int i = 0; i < numberOfControls; ++i)
            {
                Label newLabel = new Label();
                newLabel.Name = "lbl" + (i + 1);
                newLabel.Text = "New Label " + (i + 1);
                newLabel.Size = new Size(120, 40);
                newLabel.Location = new Point(0, (50 * i));
                panel.Controls.Add(newLabel);
            }
        }
    }
}
