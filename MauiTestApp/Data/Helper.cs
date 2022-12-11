using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Data
{
	public class Helper
	{
		private static string _secretKey = "asDbqwue989dnASGnlk2131knj24v";

		public static string ConvertHash(string input, string secretKey)
		{
			secretKey = _secretKey;
			using (var hmac = new HMACSHA512())
			{
				hmac.Key = Encoding.UTF8.GetBytes(secretKey);

				// Convert the input string to a byte array and compute the hash.
				byte[] data = hmac.ComputeHash(Encoding.UTF8.GetBytes(input));

				// Create a new Stringbuilder to collect the bytes
				// and create a string.
				var sBuilder = new StringBuilder();

				// Loop through each byte of the hashed data
				// and format each one as a hexadecimal string.
				for (int i = 0; i < data.Length; i++)
				{
					sBuilder.Append(data[i].ToString("x2"));
				}

				// Return the hexadecimal string.
				return sBuilder.ToString();
			}
		}
	}
}
