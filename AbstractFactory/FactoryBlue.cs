using AbstractFactory.Products;
using AbstractFactory.Services;

namespace AbstractFactory
{
    internal class FactoryBlue : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
           return new ProductBlue();
        }

        public IAbstractService CreateService()
        {
            return new BlueService();
        }
    }
}
