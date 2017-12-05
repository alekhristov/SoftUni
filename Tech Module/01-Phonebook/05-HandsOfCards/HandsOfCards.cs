using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dictOfCards = new Dictionary<string, List<int>>();

            while (input != "JOKER")
            {
                var tokens = input.Split(':');
                var name = tokens[0];
                var cards = tokens[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => CalculateCardValue(a))
                    .ToArray();

                if (!dictOfCards.ContainsKey(name))
                {
                    dictOfCards[name] = new List<int>();
                }
                dictOfCards[name].AddRange(cards);

                input = Console.ReadLine();
            }
            foreach (var item in dictOfCards)
            {
                var name = item.Key;
                var cards = item.Value;

                var totalCardSum = cards.Distinct().Sum();
                Console.WriteLine($"{name}: {totalCardSum}");
            }
        }

        public static int CalculateCardValue(string card)
        {
            var cardPowers = new Dictionary<string, int>();
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }

            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;


            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);
            var value = cardPowers[power] * cardTypes[type];

            return value;

        }
    }
}
