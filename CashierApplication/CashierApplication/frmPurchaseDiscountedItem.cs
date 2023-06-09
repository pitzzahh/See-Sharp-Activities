namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        private double total_price;

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

        public override double GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public override void SetPayment(double amount)
        {
            throw new NotImplementedException();
        }
    }
}