using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var shoppingCart = new Dictionary<string, Dictionary<double, double>>();
            var totalAmount = 0.0;

            while (input != "stocked")
            {
                var tokens = input.Split();
                var product = tokens[0];
                var price = double.Parse(tokens[1]);
                var quantity = double.Parse(tokens[2]);

                if (!shoppingCart.ContainsKey(product))
                {
                    shoppingCart[product] = new Dictionary<double, double>();
                }
                if (!shoppingCart[product].ContainsKey(price))
                {

                    shoppingCart[product][price] = 0;
                }
                shoppingCart[product][price] += quantity;

                input = Console.ReadLine();
            }

            foreach (var product in shoppingCart)
            {
                var priceProduct = product.Value.Keys.Last();
                var quantityProductTotal = product.Value.Values.Sum();
                var total = priceProduct * quantityProductTotal;
                totalAmount += total;

                Console.WriteLine($"{product.Key}: ${priceProduct:f2} * {quantityProductTotal} = ${total:f2}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
}
