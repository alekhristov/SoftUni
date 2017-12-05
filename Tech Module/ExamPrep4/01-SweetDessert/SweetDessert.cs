using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());
            long numberOfSets = 0;

            if (numberOfGuests % 6 == 0)
            {
                numberOfSets = numberOfGuests / 6;
            }
            else
            {
                numberOfSets = (numberOfGuests / 6) + 1;
            }

            decimal totalPrice = numberOfSets * (2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice);

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice-cash:f2}lv more.");
            }

        }
    }
}
