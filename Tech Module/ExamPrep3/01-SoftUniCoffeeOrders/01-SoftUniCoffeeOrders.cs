using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            var result = new List<decimal>();

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine();
                DateTime myDate = DateTime.ParseExact(orderDate, $"d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(myDate.Year, myDate.Month);

                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
                result.Add(price);

            }
            decimal total = 0;
            foreach (var order in result)
            {
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
                total += order;

            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
