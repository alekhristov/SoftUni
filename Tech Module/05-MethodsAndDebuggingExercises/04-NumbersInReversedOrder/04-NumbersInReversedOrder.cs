using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumbersInReversedOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal number = decimal.Parse(Console.ReadLine());

			PrintReversedNum(number);
		}

		private static void PrintReversedNum(decimal number)
		{
			string numStr = number.ToString();
			string reversedNum = string.Empty;

			for (int i = numStr.Length-1; i >= 0; i--)
			{
				reversedNum += numStr[i];
			}
			Console.WriteLine(reversedNum);
		}
	}
}
