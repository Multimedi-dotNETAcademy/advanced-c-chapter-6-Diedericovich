using System;
using System.Collections.Generic;

namespace Book

{
    internal class Program
    {        

        private static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("      LIST OF BOOKS");

            List<Book> listbooks = new List<Book>()
            {
                new Textbook(97890282, "The Shining", "Stephen King",25.00, 5),
                new CoffeeTableBook(97890289, "It", "Stephen King", 20.00),
                new Textbook(97890282, "Het Verdriet van België", "Hugo Claus", 15.00, 4),
                new CoffeeTableBook(97890289, "De Geruchten", "Hugo Claus", 10.00)
            };
            foreach (var item in listbooks)
            {
                count++;
                Console.WriteLine();
                Console.WriteLine($" {count}. {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now select 2 books from the list above by number");
            Console.WriteLine();
            Console.WriteLine("Book 1: ");
            int book1 = Convert.ToInt32(Console.ReadLine());
            while (book1 != 1 && book1 != 2 && book1 != 3 && book1 != 4)
            {
                Console.WriteLine("Select one of the above options (1 - 4)");
                Console.WriteLine("Try again");
                book1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Book 2: ");
            int book2 = Convert.ToInt32(Console.ReadLine());
            while (book2 != 1 && book2 != 2 && book2 != 3 && book2 != 4)
            {
                Console.WriteLine("Select one of the above options (1 - 4)");
                Console.WriteLine("Try again");
                book2 = Convert.ToInt32(Console.ReadLine());
            }

            listbooks.AddUp();






        }
    }
}