using FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        VehicleFactory factory = new ConcreteVehicleFactory();

        IFactory car = factory.GetVehicle(VehicleTypeEnum.Car);
        car.Drive(20);

        IFactory motorbike = factory.GetVehicle(VehicleTypeEnum.MotorBike);
        motorbike.Drive(10);
    }
}
