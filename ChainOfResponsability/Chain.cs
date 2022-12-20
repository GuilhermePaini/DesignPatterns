namespace ChainOfResponsability
{
    public class Chain
    {
        private Processor chain;

        public Chain() => chain = new NegativeProcessor(new PositiveProcessor(new ZeroProcessor()));

        public void Process(Number request) => chain.Process(request);
    }
}
