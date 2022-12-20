namespace ChainOfResponsability
{
    public class ZeroProcessor : Processor
    {
        public ZeroProcessor(Processor? next = null) : base(next)
        {
        }

        public override void Process(Number request)
        {
            if (request.getNumber() == 0)
                Console.WriteLine($"ZeroProcessor: {request.getNumber()}");
            else
                base.Process(request);
        }
    }
}
