using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlTest
{
    class Register
    {
        string name;
        string username;
        string email;
        int age;
        string password;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Username
		{
			get { return username; }
			set { username = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public string Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}
