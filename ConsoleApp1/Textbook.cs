using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Textbook : Book
    {

        public int GradeLevel { get; set; }

        private double _price;

        public override double Price
        {
            get { return _price; }
            set
            {
                if (value > 20.00 && value < 80)
                {
                    _price = value;
                }
                
            }
        }

        public Textbook(int isbn, string title, string author,double price, int gradeLevel) : base(isbn, title, author, price)
        {
            GradeLevel = gradeLevel;
        }

        public override string ToString()
        {
            string add = $"\n Gradelevel: {GradeLevel}";
            return base.ToString() + add;
        }

    }
}
