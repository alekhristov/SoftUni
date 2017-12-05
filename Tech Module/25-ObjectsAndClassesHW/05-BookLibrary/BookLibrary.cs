using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class AuthorInfo
{
    public string Author { get; set; }
    public double Sales { get; set; }
}
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Isbn { get; set; }
    public double Price { get; set; }
}
public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
namespace _05_BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var library = new Library
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Isbn = input[4],
                    Price = double.Parse(input[5])
                };
                library.Books.Add(book);
            }
            var authors = library.Books
                .Select(a => a.Author)
                .Distinct()
                .ToArray();

            var authorSales = new List<AuthorInfo>();

            foreach (var author in authors)
            {
                var authorBooks = library.Books
                    .Where(a => a.Author == author)
                    .Sum(a => a.Price);

                AuthorInfo authorInfo = new AuthorInfo
                {
                    Author = author,
                    Sales = authorBooks
                };
                authorSales.Add
                    (authorInfo);
            }
            authorSales = authorSales
                .OrderByDescending(x => x.Sales)
                .ThenBy(a => a.Author)
                .ToList();

            foreach (var authorSale in authorSales)
            {
                var author = authorSale.Author;
                var sales = authorSale.Sales;

                Console.WriteLine($"{author} -> {sales:F2}");
            }
        }
    }
}
