using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(VehicleTypeEnum vehicleType)
        {
            switch(vehicleType)
            {
                case VehicleTypeEnum.Car: 
                    return new Car();
                case VehicleTypeEnum.MotorBike: 
                    return new MotorBike();
                default:
                    throw new ArgumentException($"Vehicle cannot be created.");
            }
        }
    }
}
