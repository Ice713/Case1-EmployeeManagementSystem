using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case1_EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display employee details when an item is selected
            if (listBox1.SelectedItem == null)
                return;
            if (listBox1.SelectedItem is Employee selectedEmployee)
            {
                selectedEmployee.Display();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // try catch block to handle potential exceptions during Employee creation
            try
            {
                // Create list of employees
                List<Employee> employees = new List<Employee>
                {
                    new Employee("John Doe", 500000, 101),
                    new Employee("Alice Smith", 60000, 102),
                    new Employee("", -10000, 103)
                };

                // Bind the list to the ListBox
                listBox1.DataSource = employees;
                listBox1.DisplayMember = "Name"; // Display the Name property in the ListBox
            }
            catch (ArgumentOutOfRangeException rangeEx)
            {
                MessageBox.Show($"Range error: {rangeEx.Message}");
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Argument error: {argEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing employee list: {ex.Message}");
            }
            finally
            { 
                listBox1.SelectedIndex = -1; // No selection initially
            }
            
        }
    }
}
