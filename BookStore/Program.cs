using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Book actionBook = new Book("The House of Spies", "Daniel Silva", new DateTime(2016, 12, 11), 19.95m);

            decimal price = actionBook.CalculateBookStorePrice();

            Console.WriteLine($"Title: {actionBook.Title}");
            Console.WriteLine($"Author: {actionBook.Author}");
            Console.WriteLine($"Published On: {actionBook.PublishDate}");
            Console.WriteLine($"Price: {price:C}");
            Console.ReadLine();
        }
    }
}
