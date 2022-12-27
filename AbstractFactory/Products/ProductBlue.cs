using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    internal class ProductBlue : IAbstractProduct
    {
        public ProductBlue()
        {
            Console.WriteLine("New blue product!!");
        }

        public string SomeProductFunction()
        {
            return "Some ** blue ** product";
        }
    }
}
