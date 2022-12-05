using Decorator;

internal class Program
{
    private static void Main(string[] args)
    {
        Pinscher pinscher = new Pinscher();

        Console.WriteLine(pinscher.Bark());

        Affenpinscher affenpinscher = new Affenpinscher(pinscher);

        Console.WriteLine(affenpinscher.Bark());
    }
}