using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
	public string Name { get; set; }
	public string ID { get; set; }
	public int Age { get; set; }

}
namespace _01_OrderByAge
{
	class OrderByAge
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			var listOfPeople = new List<Person>();

			while (input[0] != "End")
			{
				string name = input[0];
				string idNumber = input[1];
				int age = int.Parse(input[2]);

				var person = new Person()
				{
					Name = name,
					ID = idNumber,
					Age = age
				};

				listOfPeople.Add(person);

				input = Console.ReadLine().Split();
			}
			var resultList = listOfPeople.OrderBy(o => o.Age).ToList();

			foreach (var person in resultList)
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}


		}
	}
}
