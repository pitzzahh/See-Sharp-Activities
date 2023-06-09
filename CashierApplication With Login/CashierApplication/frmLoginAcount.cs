using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAcount : Form
    {
        public frmLoginAcount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashier = new Cashier(
                "Peter John Arao",
                "IT",
                "pitzzahh",
                "P@ssword01"
                );

            var isAuthenticated = cashier.validateLogin(UsernameInput.Text, PasswordInput.Text);

            if (isAuthenticated)
            {
                MessageBox.Show($"Welcome {cashier.getFullName()}");
                this.Hide();
                new frmPurchaseDiscountedItem().Show();
            }
            else MessageBox.Show("Invalid username or password");
        }
    }
}

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string username;
        protected string password;

        protected UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.username = uName;
            this.password = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return full_name;
        }
    }

    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            return username.Equals(uName) && base.password.Equals(password);
        }

        public string getDepartment()
        {
            return department;
        }
    }
}