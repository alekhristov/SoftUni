using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejctsAndClasses
{
	class DayOfWeek
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine(date.DayOfWeek);
		}
	}
}
