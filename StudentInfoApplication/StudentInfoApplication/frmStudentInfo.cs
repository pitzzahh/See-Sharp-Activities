using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {

        private ArrayList StudentIdListContainer = new ArrayList();
        private ArrayList LastNameListContainer = new ArrayList();
        private ArrayList FirstNameListContainer = new ArrayList();

        public frmStudentInfo()
        {
            InitializeComponent();
            Student student = new Student();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var _studentId = StudentIDInput.Text;
            var _lastName = LastNameInput.Text;
            var _firstName = FirstNameInput.Text;

            if (_studentId.Length == 0) // guard clause pattern
            {
                MessageBox.Show("Student ID is required!");
                return;
            }
            if (_lastName.Length == 0) // guard clause pattern
            {
                MessageBox.Show("Last Name is required!");
                return;
            }
            if (_firstName.Length == 0)
            {
                MessageBox.Show("First Name is required!");
                return;
            }

            StudentIdListContainer.Add(_studentId);
            LastNameListContainer.Add(_lastName);
            FirstNameListContainer.Add(_firstName);

            StudentIDList.Items.Clear();
            LastNameList.Items.Clear();
            FirstNameList.Items.Clear();

            InsertData(StudentIDList, StudentIdListContainer);
            InsertData(LastNameList, LastNameListContainer);
            InsertData(FirstNameList, FirstNameListContainer);

        }

        private void InsertData(ListBox view, ArrayList data)
        {
            foreach (string item in data)
            {
                if (item != null)
                {
                    view.Items.Add(item);
                }
            }
        }
    }

    class Student
    {
        private string StudentId;
        private string LastName;
        private string FirstName;

        public Student() { }

        public Student(string StudentId, string LastName, string FirstName)
        {
            this.StudentId = StudentId;
            this.LastName = LastName;
            this.FirstName = FirstName;
        }

        public string GetStudentId()
        {
            return StudentId;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetStudentId(string StudentId)
        {
            this.StudentId = StudentId.Trim();
        }

        public void SetLastName(string LastName)
        {
            this.LastName = LastName.Trim();
        }

        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

    }
}
