using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CenturiesToNanoseconds
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte centuries = sbyte.Parse(Console.ReadLine());
			int years = centuries * 100;
			double days = (int)(years * 365.2422);
			int hours = (int)(days * 24);
			int minutes = hours * 60;
			long seconds = (long)minutes * 60;
			long milliseconds = (long)seconds * 1000;
			long microseconds = (long)milliseconds * 1000;
			decimal nanoseconds = (decimal)microseconds * 1000;

			Console.WriteLine($"{centuries} centuries = {years} years " +
				$"= {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
		}
	}
}
