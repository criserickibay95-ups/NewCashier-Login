using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashierApplication;
using Usernamespace;

namespace UserNamespace
{

	internal class Administrator : User
	{
		private string admin_name;
		public Administrator(string name, string pass) : base(name, pass)
		{
			this.admin_name = name;
		}

		public void updateAdminName(string name)
		{
			admin_name = name;
		}

		public string getAdminInfo()
		{
			return $"Admin Name: {admin_name} | Password: {user_password}";
		}
	}
}