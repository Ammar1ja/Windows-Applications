using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Employee
    {
        
        // Employee ahmad = new Employee("ahmad",1263,Date); 
        public Employee(string name,int id,DateTime date) 
        {
            this.name = name;
            this.id = id;
            this.date = date;
        }
        public string name { get; set; }
        public int id { get; set; }
        public DateTime date { get; set; }
        public string employeeInfo()
        {
            return "Name: " + name + "\n" + "ID: " + id.ToString() + "\n" + "DOB: " + date.ToShortDateString();
        }
    }
}