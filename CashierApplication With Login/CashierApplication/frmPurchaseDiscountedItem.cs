
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {

        private static DiscountedItem? discountedItem;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                discountedItem = new DiscountedItem(
                Item.Text,
                Double.Parse(Price.Text),
                Int32.Parse(Quantity.Text),
                Double.Parse(Discount.Text)
                );
                TotalAmount.Text = (Double.Parse(Price.Text) * Int32.Parse(Quantity.Text)).ToString();
                TotalAmount.Text = discountedItem.GetTotalPrice().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("One of the inputs are invalid.");
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (discountedItem == null)
                {
                    MessageBox.Show("Please Enter Item details first");
                    return;
                }
                discountedItem.SetPayment(Double.Parse(Payment.Text));
                Change.Text = discountedItem.GetChange().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Payment input is invalid");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoginAcount().Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string? item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string? name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract double GetTotalPrice();

        public abstract void SetPayment(double amount);
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string? name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            item_discount = discount;
        }

        public override double GetTotalPrice()
        {
            total_price = item_price * item_quantity;
            discounted_price = total_price - (total_price * (item_discount / 100));
            return discounted_price;
        }

        public override void SetPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - GetTotalPrice();
        }

        public double GetChange()
        {
            return change;
        }
    }
}
