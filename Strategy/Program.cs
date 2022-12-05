using Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new Context();

        Console.WriteLine("Ordered Stock: ");
        context.SetStrategy(new OrderedStock());
        context.GetStockQuantity(itemId: 113084);

        Console.WriteLine("Physical Stock: ");
        context.SetStrategy(new PhysicalStock());
        context.GetStockQuantity(itemId: 113084);
    }
}