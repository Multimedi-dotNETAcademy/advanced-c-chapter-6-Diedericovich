using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class OmnibusBook : Book
    {
        public string OmniAuthors { get; set; }

        private double _price;

        public override double Price
        {
            get { return _price; }
            set { _price = value; }
        }



        public OmnibusBook(int isbn, string title, string author, double price, string omniAuthors) : base(isbn, title, author, price)
        {
            OmniAuthors = omniAuthors;
        }


     

    }
}
