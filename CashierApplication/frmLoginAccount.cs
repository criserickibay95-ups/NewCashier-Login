using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashierApplication
{
	public partial class frmLoginAccount : Form
	{
		private Administrator admin;

		public frmLoginAccount()
		{
			InitializeComponent();
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			string pass = textBox2.Text;

			admin = new Administrator(name, pass);

			if (admin.verifyLogin(name, pass))
			{
				MessageBox.Show("Login successful!");
			}
			else
			{
				MessageBox.Show("Login failed. Please check your credentials.");
			}
		}
	}
}
