using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    public abstract class Book
    {
        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(int isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }


        static string AddUp (Book book1, Book book2 )
        {


            return "";
        }

    }
}
