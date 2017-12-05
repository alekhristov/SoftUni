using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CompareCharArrays
{
	class CompareCharArrays
	{
		static void Main(string[] args)
		{
			char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
			char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
			string firstWord = new string(array1);
			string secondWord = new string(array2);

			if (array1.Length < array2.Length)
			{
				Console.WriteLine(firstWord);
				Console.WriteLine(secondWord);
			}
			else if (array1.Length > array2.Length)
			{
				Console.WriteLine(secondWord);
				Console.WriteLine(firstWord);
			}
			else
			{
				for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
				{
					if (array1[i] < array2[i])
					{
						Console.WriteLine(firstWord);
						Console.WriteLine(secondWord);
						break; 
					}
					else if (array1[i] > array2[i])
					{
						Console.WriteLine(secondWord);
						Console.WriteLine(firstWord);
						break;
					}
					else
					{
						Console.WriteLine(firstWord);
						Console.WriteLine(secondWord);
						break;
					}
				}

			}

		}
	}
}
