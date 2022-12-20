namespace ChainOfResponsability;

public class NegativeProcessor : Processor
{
    public NegativeProcessor(Processor? next = null) : base(next)
    {
    }

    public override void Process(Number request) {
        if(request.getNumber() < 0)
            Console.WriteLine($"NegativeProcessor: {request.getNumber()}");
        else
            base.Process(request);
    }
}