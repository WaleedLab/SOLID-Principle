namespace DIP.v2
{
    internal class Book : IProduct
    {
        public Book(decimal price)
        {
            Price = price;
        }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string ProductType => "Book";
    }
}
