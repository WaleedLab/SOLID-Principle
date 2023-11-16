namespace DIP.v2
{
    internal interface IProduct
    {
        decimal Price { get; }
        string Name { get; }
        string ProductType { get; }
    }
}