using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EmployeeInterface;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void ComputeSalaryBtn_Click(object sender, EventArgs e)
        {
            if (FirstName.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter first name");
                return;
            }
            
            if (LastName.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter last name");
                return;
            }
            
            if (Department.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter department");
                return;
            }
            
            if (JobTitle.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter job title");
                return;
            }
            
            if (RatePerHour.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter rate per hour");
                return;
            }
            
            if (TotalHoursWorked.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter total hours worked");
                return;
            }

            if (!IsDecimalNumber(RatePerHour.Text) && !IsWholeNumber(RatePerHour.Text))
            {
                MessageBox.Show(@"Please enter a valid rate per hour");
                return;
            }
            
            if (!IsWholeNumber(TotalHoursWorked.Text))
            {
                MessageBox.Show(@"Please enter a valid total hours worked");
                return;
            }

            var partTimeEmployee = new PartTimeEmployee(FirstName.Text, LastName.Text, JobTitle.Text, Department.Text);
            FirstNameOutput.Text = partTimeEmployee.FirstName;
            LastNameOutput.Text = partTimeEmployee.LastName;
            partTimeEmployee.ComputeSalary(Int32.Parse(TotalHoursWorked.Text), Double.Parse(RatePerHour.Text));
            BasicSalaryOutput.Text = partTimeEmployee.getSalary().ToString(CultureInfo.CurrentCulture);
        }
        
        private static bool IsWholeNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private static bool IsDecimalNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+(\.\d+)?$");
        }
    }
}

namespace EmployeeInterface
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }
        void ComputeSalary(int hoursWorked, double ratePerHour);
    }
}

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            FirstName = FName;
            LastName = LName;
            Department = dept;
            JobTitle = job;
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary = ratePerHour * hoursWorked;
        }

        public double getSalary()
        {
            return BasicSalary;
        }
    }
}