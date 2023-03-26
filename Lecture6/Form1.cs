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

namespace Lecture6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
            textBox1.Text = "AD1124";
            cbCountries.Items.Add("Jordan");
            cbCountries.Items.Add("Syria");
            cbCountries.Items.Add("Egypt");
        }

  
    }
}
