using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(VehicleTypeEnum vehicleType);
    }
}
