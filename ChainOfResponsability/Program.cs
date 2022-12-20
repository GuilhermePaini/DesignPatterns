namespace ChainOfResponsability;

public class Program
{
    public static void Main(string[] args)
    {
        Chain chain = new Chain();

        chain.Process(new Number(90));
        chain.Process(new Number(-50));
        chain.Process(new Number(0));
        chain.Process(new Number(91));
    }
}