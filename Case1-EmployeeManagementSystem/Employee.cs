using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case1_EmployeeManagementSystem
{
    internal class Employee
    {
        private string name;
        private int salary;
        private int EmployeeID { get; set; }

        public string Name
        {
            get { return name; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                else
                    name = value; 
            }
        }

        public int Salary
        {
            get { return salary; }
            set 
            { 
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                else
                    salary = value; 
            }
        }

        public Employee(string name, int salary, int employeeID)
        {
            Name = name; // Using property to leverage validation
            Salary = salary; // Using property to leverage validation
            EmployeeID = employeeID;
        }

        public void Display()
        {
            MessageBox.Show($"Employee ID: {EmployeeID}\nName: {Name}\nSalary: {Salary}");
        }

    }
}
