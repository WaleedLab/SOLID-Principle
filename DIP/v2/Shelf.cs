namespace DIP.v2
{
    internal class Shelf
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            Console.WriteLine($"Put {product.ProductType} on the shelf: {product.Name}. Price: {product.Price}");
            products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            return products.Sum(p => p.Price);
        }
    }
}
