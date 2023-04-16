using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxCountries.Items.Add(txtCountries.Text);
            txtCountries.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxCountries.Items.Add("Aqaba");
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(txtCombo.Text);
            txtCombo.Text = string.Empty;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelected.Text = comboBox1.SelectedItem.ToString();
        }

        private void lbxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedListBox.Text = lbxCountries.SelectedItem.ToString();
            txtSelectedListBox.Text = string.Empty;
        }
    }
}
