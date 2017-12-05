using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ManipulateArray
{
	class ManipulateArray
	{
		static void Main(string[] args)
		{
			string[] array = Console.ReadLine().Split().ToArray();
			int lines = int.Parse(Console.ReadLine());

			for (int i = 0; i < lines; i++)
			{
				string[] command = Console.ReadLine().Split().ToArray();

				if (command[0] == "Distinct")
				{
					array = array.Distinct().ToArray();
				}
				else if (command[0] == "Replace")
				{
					int index = int.Parse(command[1]);
					array = array.Select(s => s.Replace(array[index], command[2])).ToArray();
				}
				else if (command[0] == "Reverse")
				{
					Array.Reverse(array);
				}
			}
			Console.WriteLine(string.Join(", ", array));
		}


	}
}
