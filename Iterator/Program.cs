using Iterator;

internal class Program
{
    private static void Main(string[] args)
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate.Add("Marcelin");
        aggregate.Add("Bacaxi");
        aggregate.Add("Melãozin");
        aggregate.Add("Beijamin");

        InterfaceIterator iterator = aggregate.CreateIterator();

        while (iterator.Next())
        {
            string? item = iterator.Current as string;
            Console.WriteLine(item);
        }
    }
}