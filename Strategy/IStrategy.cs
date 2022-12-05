namespace Strategy
{
    internal interface IStrategy
    {
        StockPositionModel GetStock(long itemId);
    }
}
