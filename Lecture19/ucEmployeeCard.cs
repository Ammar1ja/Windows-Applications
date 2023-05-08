using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture19
{
    public partial class ucEmployeeCard : UserControl
    {
        public string  empId { get; set; }
        public string  empName { get; set; }
        public string  empTel { get; set; }
        public string  empJob { get; set; }
        public ucEmployeeCard()
        {
            InitializeComponent();
        }

        private void ucEmployeeCard_Load(object sender, EventArgs e)
        {
            txtId.Text = empId;
            txtName.Text = empName;
            txtTel.Text = empTel;
            txtJob.Text = empJob;
        }
    }
}
