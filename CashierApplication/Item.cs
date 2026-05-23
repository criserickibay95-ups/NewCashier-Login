using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ItemNamespace
{
        public abstract class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            protected double total_price;

            public Item(string name, double price, int quantity)
            {
                this.item_name = name;
                this.item_price = price;
                this.item_quantity = quantity;
            }

            public abstract double GetTotalPrice();

            public virtual void SetPayment(double amount)
            {
            }
        }
    }




