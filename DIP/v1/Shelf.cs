namespace DIP.v1
{
    internal class Shelf
    {
        private List<DVD> list = new List<DVD>();
       
        public void Put(DVD dvd)
        {
            Console.WriteLine("Put DVD on the shelf...");
            list.Add(dvd);
        }

        public int GetProductCount()
        {
            return list.Count();
        }

        public decimal GetProductsPrice()
        {
            decimal price = 0;

            foreach (DVD dvd in list)
            {
                price += dvd.GetPrice();
            }

            return price;
        }
    }
}
