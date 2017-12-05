using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RotateAndSum
{
	class RotateAndSum
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rotate = int.Parse(Console.ReadLine());
			int[] sum = new int[array.Length];

			for (int k = 0; k < rotate; k++)
			{
				int temp = array[array.Length - 1];

				for (int i = array.Length - 1; i >= 1; i--)
				{

					array[i] = array[i - 1];
					sum[i] += array[i];
				}
				array[0] = temp;
				sum[0] += temp;

			}
			Console.WriteLine(string.Join(" ", sum));

		}
	}
}
