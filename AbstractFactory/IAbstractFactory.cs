using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;
using AbstractFactory.Services;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProduct CreateProduct();
        IAbstractService CreateService();
    }
}
