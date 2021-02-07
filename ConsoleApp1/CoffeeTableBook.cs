namespace Book
{
    internal class CoffeeTableBook : Book
    {
        private double _price;

        public override double Price
        {
            get { return _price; }
            set
            {
                if (value > 35.00 && value < 100)
                {
                    _price = value;
                }
            }
        }

        public CoffeeTableBook(int isbn, string title, string author, double price) : base(isbn, title, author, price)
        {
        }
    }
}