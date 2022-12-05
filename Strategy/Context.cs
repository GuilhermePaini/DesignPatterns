namespace Strategy
{
    internal class Context
    {
        private IStrategy _strategy;

        public Context()
        {
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GetStockQuantity(long itemId)
        {
            var result = _strategy.GetStock(itemId);
            Console.WriteLine($"Item: {itemId} | Quantity: {result.Quantity}");
        }
    }
}
