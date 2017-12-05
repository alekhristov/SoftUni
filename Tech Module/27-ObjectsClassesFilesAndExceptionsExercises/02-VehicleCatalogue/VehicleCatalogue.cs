using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VehicleCatalogue
{
	class VehicleCatalogue
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			var listofCars = new List<Car>();
			var listofTrucks = new List<Truck>();

			while (input[0] != "End")
			{
				var vehicle = input[0].ToLower();
				var model = input[1];
				var color = input[2];
				var horsePower = input[3];

				if (vehicle == "car")
				{
					var car = new Car
					{
						Model = model,
						Color = color,
						HorsePower = horsePower
					};
					listofCars.Add(car);
				}
				else if (vehicle == "truck")
				{
					var truck = new Truck
					{
						Model = model,
						Color = color,
						HorsePower = horsePower
					};
					listofTrucks.Add(truck);

				}

				input = Console.ReadLine().Split();
			}

			double carsHP = 0;
			double trucksHP = 0;

			while (input[0] != "Close")
			{
				carsHP = 0;
				trucksHP = 0;

				var printVehicle = input[0];

				foreach (var car in listofCars)
				{
					if (car.Model.Contains(printVehicle))
					{
						Console.WriteLine($"Type: Car\nModel: {car.Model}\nColor: {car.Color}\nHorsepower: {car.HorsePower}");
					}
					carsHP += double.Parse(car.HorsePower);
				}

				foreach (var truck in listofTrucks)
				{
					if (truck.Model.Contains(printVehicle))
					{
						Console.WriteLine($"Type: Truck\nModel: {truck.Model}\nColor: {truck.Color}\nHorsepower: {truck.HorsePower}");
					}
					trucksHP += double.Parse(truck.HorsePower);
				}

				input = Console.ReadLine().Split();
			}
			var averageCarsHP = carsHP / listofCars.Count;
			var averageTrucksHP = trucksHP / listofTrucks.Count;

			if (trucksHP == 0)
			{
				averageTrucksHP = 0;
			}
			if (carsHP == 0)
			{
				averageCarsHP = 0;
			}

			Console.WriteLine($"Cars have average horsepower of: {averageCarsHP:f2}.");
			Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:f2}.");

		}
	}
}
