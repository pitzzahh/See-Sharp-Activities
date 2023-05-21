using System;
using EmployeeNamespace;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var _id = EmployeeFirstNameInput.Text;
            var _firstName = EmployeeFirstNameInput.Text;
            var _lastName = EmployeeLastNameInput.Text;
            var _position = EmployeePositionInput.Text;

            if (_id.Length == 0) // guard clause pattern
            {
                MessageBox.Show("ID is required!");
                return;
            }
            if (_firstName.Length == 0)
            {
                MessageBox.Show("First Name is required!");
                return;
            }
            if (_lastName.Length == 0)
            {
                MessageBox.Show("Last Name is required!");
                return;
            }

            if (_position.Length == 0)
            {
                MessageBox.Show("Position is required!");
                return;
            }

            var employee = new Employee(_id, _firstName, _lastName, _position);

            EmployeeList.Rows.Add(
                employee.EmployeeID, 
                employee.EmployeeFirstName, 
                employee.EmployeeLastName, 
                employee.Position
            );

            EmployeeIDInput.Text = string.Empty;
            EmployeeFirstNameInput.Text = string.Empty;
            EmployeeLastNameInput.Text = string.Empty;
            EmployeePositionInput.Text = string.Empty;
        }
    }
}
namespace EmployeeNamespace
{
    public class Employee
    {
        private string employeeID;
        private string employeeFirstName;
        private string employeeLastName;
        private string position;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeFirstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }

        public string EmployeeLastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Employee(string employeeID, string employeeFirstName, string employeeLastName, string position)
        {
            this.employeeID = employeeID;
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.position = position;
        }

        public Employee(string employeeID, string employeeFirstName, string employeeLastName)
        {
            this.employeeID = employeeID;
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
        }

        public Employee(string employeeID, string position)
        {
            this.employeeID = employeeID;
            this.position = position;
        }

        public Employee()
        {
            this.employeeID = "55555555";
            this.employeeFirstName = "Default First Name";
            this.employeeLastName = "Default Last Name";
            this.position = "Default Position";
        }
    }
}