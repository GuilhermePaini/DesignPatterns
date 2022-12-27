using AbstractFactory.Products;
using AbstractFactory.Services;

namespace AbstractFactory
{
    internal class FactoryRed : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
           return new ProductRed();
        }

        public IAbstractService CreateService()
        {
            return new RedService();
        }
    }
}
