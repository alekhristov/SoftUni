using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FixEmails
{
	class FixEmails
	{
		static void Main(string[] args)
		{
			var emailsBook = new Dictionary<string, string>();
			string input = Console.ReadLine();

			while (input != "stop")
			{
				string name = input;
				string email = Console.ReadLine();

				emailsBook[name] = email;
				input = Console.ReadLine();
			}
			var fixedEmailsBook = emailsBook
				.Where(e => !e.Value.EndsWith("us") && !e.Value.EndsWith("uk")).ToDictionary(p => p.Key, p => p.Value);

			foreach (var item in fixedEmailsBook)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
