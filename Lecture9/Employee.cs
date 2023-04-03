using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9
{
    public class Employee
    {
        public Employee(int id , string name , DateTime dateTime)
        {
            this.id = id;
            this.name = name;
            DateOfBirth=dateTime;
        }
        public int id { get; set; }
        public string name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string dateOfBirth(DateTime dateTime) 
        {
            dateTime = DateTime.Now.AddYears(-22);
            return dateTime.ToString();
        }
        public string employeeInfo()
        {
            return "Name: " + name + "\n" + "ID: " + id.ToString() + "\n" + "DOB: " + dateOfBirth(DateOfBirth);
        }
    }
}
