using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usernamespace
{
	internal class User
	{
		private string user_id;
		protected string user_password;

		public User(string user_id, string user_password)
		{
			this.user_id = user_id;
			this.user_password = user_password;
		}

		public bool verifyLogin(string user_id, string user_password)
		{
			return this.user_id == user_id && this.user_password == user_password;
		}

		public void updatePassword(string new_password)
		{
			this.user_password = new_password;
		}
	}
}