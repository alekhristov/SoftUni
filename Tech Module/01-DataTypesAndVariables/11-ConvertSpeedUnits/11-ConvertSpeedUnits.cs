using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ConvertSpeedUnits
{
	class Program
	{
		static void Main(string[] args)
		{
			float distance = float.Parse(Console.ReadLine());
			float hours = float.Parse(Console.ReadLine());
			float minutes = float.Parse(Console.ReadLine());
			float seconds = float.Parse(Console.ReadLine());

			float totalSeconds = hours * 3600 + minutes * 60 + seconds;
			float metersPerSecond = distance / totalSeconds;

			float totalHours = (hours + minutes / 60 + seconds / 3600);
			float kilometers = distance / 1000;
			float kilometersPerHour = kilometers / totalHours;

			float milesPerHour = (kilometers / 1.609f) / totalHours;

			Console.WriteLine(metersPerSecond);
			Console.WriteLine(kilometersPerHour);
			Console.WriteLine(milesPerHour);

		}
	}
}
