namespace Strategy
{
    internal class OrderedStock : IStrategy
    {
        public StockPositionModel GetStock(long itemId)
        {
            var result = new StockPositionModel { ItemId = itemId };

            if (itemId > 0)
                result.Quantity = 10000;

            return result;
        }
    }
}
