namespace Strategy
{
    internal class PhysicalStock : IStrategy
    {
        public StockPositionModel GetStock(long itemId)
        {
            var result = new StockPositionModel { ItemId = itemId };

            if (itemId > 0)
                result.Quantity = 10; // 

            return result;
        }
    }
}
