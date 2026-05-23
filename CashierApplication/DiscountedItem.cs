using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemNamespace;


namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;
        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount * 0.01;
        }
        public override double GetTotalPrice()
        {
            discounted_price = item_price - (item_price * item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }
        public override void SetPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - total_price;
        }
        public double GetChange()
        {
            return change;
        }
    }
}
