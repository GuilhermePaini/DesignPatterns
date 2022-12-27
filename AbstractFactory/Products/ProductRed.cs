namespace AbstractFactory.Products
{
    internal class ProductRed : IAbstractProduct
    {
        public ProductRed()
        {
            Console.WriteLine("New red product!!");
        }

        public string SomeProductFunction()
        {
            return "Some ** red ** product";
        }
    }
}
