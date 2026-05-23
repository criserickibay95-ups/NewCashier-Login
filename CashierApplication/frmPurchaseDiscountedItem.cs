using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
	public partial class frmPurchaseDiscountedItem : Form
	{
		DiscountedItem item;
		public frmPurchaseDiscountedItem()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			double price;
			int quantity;
			double discount;

			if (double.TryParse(textBox2.Text, out price) &&
				int.TryParse(textBox4.Text, out quantity) &&
				double.TryParse(textBox3.Text, out discount))
			{
				item = new DiscountedItem(name, price, quantity, discount);
				label5.Text = "Total amount: " + item.GetTotalPrice().ToString("0.00");
			}
			else
			{
				MessageBox.Show("Please type numbers for Price, Quantity, and Discount.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (item != null)
			{
				double payment = Convert.ToDouble(textBox5.Text);
				item.SetPayment(payment);

				label10.Text = "Change: " + item.GetChange().ToString("0.00");
			}
		}
		private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			frmLoginAccount loginForm = new frmLoginAccount();
			loginForm.Show();
			this.Hide();
		}

		private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
