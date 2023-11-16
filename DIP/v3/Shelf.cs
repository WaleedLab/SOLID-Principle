namespace DIP.v3
{
    internal class Shelf
    {
        private List<IProduct> products;
        public Shelf()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public decimal GetPrice()
        {
            //LINQ
            //return products
            //    .Select(product => product.Price)
            //    .Sum();

            return products.Sum(product => product.Price);
        }
    }
}
