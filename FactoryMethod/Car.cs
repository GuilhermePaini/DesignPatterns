using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Car : IFactory
    {
        public void Drive(int Kms)
        {
            Console.WriteLine($"The car drive for: {Kms} km's");
        }
    }
}
