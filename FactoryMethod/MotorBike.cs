using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class MotorBike : IFactory
    {
        public void Drive(int Kms)
        {
            Console.WriteLine($"The motorbike drive for: {Kms} km's");
        }
    }
}
