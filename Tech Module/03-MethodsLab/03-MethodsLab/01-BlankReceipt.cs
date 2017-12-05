using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodsLab
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintBlankReceipt();
		}

		private static void PrintBlankReceipt()
		{
			PrintHeader();
			PrintBody();
			PrintFooter();
		}

		private static void PrintFooter()
		{
			string c = "\u00A9";
			Console.WriteLine("------------------------------");
			Console.WriteLine($"{c} SoftUni");
		}

		private static void PrintBody()
		{
			Console.WriteLine("Charged to____________________");
			Console.WriteLine("Received by___________________");
		}

		private static void PrintHeader()
		{
			Console.WriteLine("CASH RECEIPT");
			Console.WriteLine("------------------------------");
		}
	}
}
