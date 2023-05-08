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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.id = "aj";
            employee1.name = "Ammar";
            employee1.tel = "+962 795220582";
            employee1.job = "Web Developer";
            Employee employee2 = new Employee();
            employee1.id = "as";
            employee1.name = "Ahmad";
            employee1.tel = "+962 795224365";
            employee1.job = "Android Developer";
            Employee employee3 = new Employee();
            employee1.id = "bm";
            employee1.name = "Baraa";
            employee1.tel = "+962 795350582";
            employee1.job = "Games Developer";

            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);

            ucEmployeeCard newEmployeeCard1 = new ucEmployeeCard();
            ucEmployeeCard newEmployeeCard2 = new ucEmployeeCard();
            ucEmployeeCard newEmployeeCard3 = new ucEmployeeCard();
            List<ucEmployeeCard> ucList = new List<ucEmployeeCard>();
            ucList.Add(newEmployeeCard1);
            ucList.Add(newEmployeeCard2);
            ucList.Add(newEmployeeCard3);

            for (int i = 0; i < employeesList.Count; ++i)
            {

                ucList[i].Location = new Point(40, i * ucList[i].Height);
                ucList[i].empId = employeesList[i].id;
                ucList[i].empName = employeesList[i].name;
                ucList[i].empJob = employeesList[i].job;
                ucList[i].empTel = employeesList[i].tel;
                this.Controls.Add(ucList[i]);
            }
        }
    }
}
