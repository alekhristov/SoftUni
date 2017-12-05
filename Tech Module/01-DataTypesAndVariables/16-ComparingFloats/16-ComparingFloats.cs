using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ComparingFloats
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal a = decimal.Parse(Console.ReadLine());
			decimal b = decimal.Parse(Console.ReadLine());
			bool areEqual = false;
			

			if (Math.Abs(a - b) >= 0.000001m)
			{
				areEqual = false;
			}
			else
			{
				areEqual = true;
			}
			Console.WriteLine(areEqual);
		}
	}
}
