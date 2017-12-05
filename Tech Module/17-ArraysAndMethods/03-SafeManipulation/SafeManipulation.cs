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
			/*string[] array = Console.ReadLine().Split().ToArray();
			string[] distinct = new string[] { };
			int counter = 0;
			int invalidInput = 0;

			string command = Console.ReadLine();

			while (command != "END")
			{

				if (command == "Reverse")
				{
						if (counter == 0)
					{
						Array.Reverse(array);
					}
					else if (counter > 0)
					{
						Array.Reverse(distinct);
					}
				}
				else if (command == "Distinct")
				{
					if (counter == 0)
					{
						distinct = array.Distinct().ToArray();
						counter++;
					}

					else if (counter > 0)
					{
						distinct = distinct.Distinct().ToArray();
					}

				}
				else
				{
					string[] replace = (command).Split().ToArray();
					int number = int.Parse(replace[1]);

					if (replace[0] != "Replace")
					{
						invalidInput++;
					}
					else
					{

						try
						{
							if (counter > 0)
							{
								distinct = distinct.Select(s => s.Replace(distinct[number], replace[2])).ToArray();
							}
							else if (counter == 0)
							{
								array = array.Select(s => s.Replace(array[number], replace[2])).ToArray();
							}
						}

						catch (IndexOutOfRangeException)
						{
							invalidInput++;
						}
					}
				}
				command = Console.ReadLine();
			}

			for (int i = 0; i < invalidInput; i++)
			{
				Console.WriteLine("Invalid input!");
			}
			if (counter == 0)
			{
				Console.WriteLine(string.Join(", ", array));
			}
			else
			{
				Console.WriteLine(string.Join(", ", distinct));
			}
		*/

			string[] array = Console.ReadLine().Split().ToArray();
			string[] command = Console.ReadLine().Split().ToArray();
			int counter = 0;

			while (command[0] != "END")
			{
				if (command[0] == "Distinct")
				{
					array = array.Distinct().ToArray();
				}
				else if (command[0] == "Replace")
					try
					{
						int index = int.Parse(command[1]);
						array = array.Select(s => s.Replace(array[index], command[2])).ToArray();

					}
					catch (Exception)
					{
						Console.WriteLine("Invalid input!");
					}


				else if (command[0] == "Reverse")
				{
					Array.Reverse(array);
				}
				else
				{
					Console.WriteLine("Invalid input!");
				}
				command = Console.ReadLine().Split().ToArray();
			}
			Console.WriteLine(string.Join(", ", array));
		}


	}
}
