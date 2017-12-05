using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayStatistics
{
	class ArrayStatistics
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			double max = double.MinValue;
			double min = int.MaxValue;
			double sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] < min)
				{
					min = numbers[i];
				}
				if (numbers[i] > max)
				{
					max = numbers[i];
				}
				sum += numbers[i];
			}
			double average = sum / numbers.Length;

			Console.WriteLine($"Min = {min}");
			Console.WriteLine($"Max = {max}");
			Console.WriteLine($"Sum = {sum}");
			Console.WriteLine($"Average = {average}");
		}
	}
}
