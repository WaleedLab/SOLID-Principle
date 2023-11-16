namespace DIP.v2
{
    internal class DVD : IProduct
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string ProductType => "DVD";
    }
}
