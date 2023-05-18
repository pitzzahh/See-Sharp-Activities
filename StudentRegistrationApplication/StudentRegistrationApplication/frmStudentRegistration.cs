using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            var arrayList = new ArrayList();
            const string bachelor = "Bachelor of Science in ";
            arrayList.Add($"{bachelor}Computer Science");
            arrayList.Add($"{bachelor}Information Technology");
            arrayList.Add($"{bachelor}Information Systems");
            arrayList.Add($"{bachelor}Computer Engineering");

            foreach (var item in arrayList)
            {
                programs.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _middleName = middleName.Text;
            var _firstName = firstName.Text;
            var _lastName = lastName.Text;

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
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Gender is required!");
                return;
            }
            if (day == null)
            {
                MessageBox.Show("Day is required!");
                return;
            }
            if (month == null)
            {
                MessageBox.Show("Month is required!");
                return;
            }
            if (year == null)
            {
                MessageBox.Show("Year is required!");
                return;
            }
            if (programs == null)
            {
                MessageBox.Show("Program is required!");
                return;
            }

            if (Avatar.Image == null)
            {
                MessageBox.Show("Student Image is required!");
                return;
            }

            var _fullName = _middleName.Trim().Length == 0 ?
                _firstName + " " + _lastName :
                _firstName + " " + _middleName + " " + _lastName;
            var _selectedGender = male != null ? male.Text : female.Text;


            var sm = Convert.ToInt32(month.SelectedItem);

            var _selectedMonth = ConvertMonthToString(sm);

            var _selectedProgram = (string) programs.SelectedItem;
            var _birthDate = $"{day.SelectedItem}/{_selectedMonth}/{year.SelectedItem}";

            ShowFullDialog(_fullName, _selectedGender, _birthDate, _selectedProgram);
            ShowPartiaalDialogFullname(_firstName, _middleName, _lastName, _selectedProgram);
            ShowPartiaalDialogNoMiddleName(_firstName, _lastName, _selectedProgram);
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedImagePath = openFileDialog.FileName;
                var originalImage = Image.FromFile(selectedImagePath);

                var imageSize = Math.Min(Avatar.Width, Avatar.Height);
                var newSize = new Size(imageSize, imageSize);

                var resizedImage = new Bitmap(originalImage, newSize);

                Avatar.Image = resizedImage;
            }
        }

        private void ShowFullDialog(string FullName, string Gender, string DateOfBirth, string Program)
        {
            var firstWindow = new CustomeMessageBox($"Student Name: {FullName}{Environment.NewLine}Gender: {Gender}{Environment.NewLine}Date of birth: {DateOfBirth}{Environment.NewLine}Program: {Program}");
            firstWindow.Show();
        }

        private void ShowPartiaalDialogFullname(String FirstName, string MiddleName, string LastName, string Program)
        {
            var firstWindow = new CustomeMessageBox($"Student Name: {FirstName} {MiddleName} {LastName}{Environment.NewLine}Program: {Program}");
            firstWindow.Show();
        }

        private void ShowPartiaalDialogNoMiddleName(String FirstName, string LastName, String Program)
        {
            var firstWindow = new CustomeMessageBox($"Student Name: {FirstName} {LastName}{Environment.NewLine}Program: {Program}");
            firstWindow.Show();
        }

        private string ConvertMonthToString(int monthValue)
        {
            if (monthValue < 1 || monthValue > 12)
            {
                return "Invalid month";
            }

            DateTime date = new DateTime(1, monthValue, 1);
            string monthString = date.ToString("MMMM");

            return monthString;

        }
    }

    class CustomeMessageBox : Form // used to make custom message dialog
    {
        public CustomeMessageBox(string message)
        {
            var messageTextBox = new TextBox();
            messageTextBox.Font = new Font("Arial", 12); 
            messageTextBox.Multiline = true;
            messageTextBox.ReadOnly = true;
            messageTextBox.Text = message;
            messageTextBox.Dock = DockStyle.Fill;
            messageTextBox.AcceptsReturn = true;
            MaximizeBox = false;

            Controls.Add(messageTextBox);
            Width = 300;
            Height = 200;
        }
    }
}
