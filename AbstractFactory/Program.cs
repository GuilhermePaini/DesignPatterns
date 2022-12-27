using AbstractFactory;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing blue factory...");
        FactoryTest(new FactoryBlue());
        Console.WriteLine();

        Console.WriteLine("Testing red factory...");
        FactoryTest(new FactoryRed());
        Console.WriteLine();
    }

    public static void FactoryTest(IAbstractFactory factory)
    {
        var product = factory.CreateProduct();
        var service = factory.CreateService();

        Console.WriteLine(product.SomeProductFunction());
        Console.WriteLine(service.SomeServiceFunction());
    }
}