namespace DesignPatterns.Creational.FactoryMethod
{
    public class LandVehicle : VehicleCreator
    {
        protected override void CreateVehicle()
        {
            Vehicles.Add(new Car());
            Vehicles.Add(new Truck());
        }
    }
}