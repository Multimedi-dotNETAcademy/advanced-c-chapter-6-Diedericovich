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

        public virtual double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(int isbn, string title, string author, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }

        static public string AddUp()
        {
            foreach (var item in listbooks)
            {
                string isbn = item.ISBN.ToString();
                string title = item.Title.ToString();
                string author = item.Author.ToString();
                string price = item.Price.ToString();                              

            }


            return $"Omnibus van  ";
        }   
       


        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }

    }
}
