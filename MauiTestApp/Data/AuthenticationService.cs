using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Data
{
	public class AuthenticationService
	{
		public static void Login(string userName, string password)
		{
			var hash = Helper.ConvertHash(password, "");

			File.ReadAllText("");
		}
	}
}
