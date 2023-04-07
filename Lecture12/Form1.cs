using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lecture12
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        // to create a new custom event handling method:
        // object sender represents the control that triggerd the event.
        // EventArgs: represents all the data related to the event.
        float num1, answer;
        int count;
   
        private void myEventHandler(object sender, EventArgs e)
        {
            txtScreen.Text += ((System.Windows.Forms.Button)sender).Text;   
        }
        private void s_Load(object sender, EventArgs e)
        {
            // Multi Buttons liked with one method
            btn1.Click += new EventHandler(myEventHandler);
            btn2.Click += new EventHandler(myEventHandler);
            button3.Click += new EventHandler(myEventHandler);
            button4.Click += new EventHandler(myEventHandler);
            button5.Click += new EventHandler(myEventHandler);
            button6.Click += new EventHandler(myEventHandler);
            button7.Click += new EventHandler(myEventHandler);
            button8.Click += new EventHandler(myEventHandler);
            button9.Click += new EventHandler(myEventHandler);
            button11.Click += new EventHandler(myEventHandler);
        }
        // this method is called when u click the equal button 
        private void btnFindAnswer_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        // this method is called when u click the Plus button
        private void button10_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.Focus();
            count = 2;
        }
        // this method is called when u click the multiply button
        private void Multiply_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.Focus();
            count = 3;
        }
        // this method is called when u click the minus button
        private void button12_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.Focus();
            count = 1;
        }
        // this method is called when u click the division button
        private void Divide_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.Focus();
            count = 4;
        }
        // this method is called when u click the equal button 
        public void compute(int count)
        {
            switch (count)
            {
                // minus case
                case 1:
                    answer = num1 - float.Parse(txtScreen.Text);
                    txtScreen.Text = answer.ToString();
                    break;
                // plus case
                case 2:
                    answer = num1 + float.Parse(txtScreen.Text);
                    txtScreen.Text = answer.ToString();
                    break;
                // multiply case
                case 3:
                    answer = num1 * float.Parse(txtScreen.Text);
                    txtScreen.Text = answer.ToString();
                    break;
                // division case
                case 4:
                    answer = num1 / float.Parse(txtScreen.Text);
                    txtScreen.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
