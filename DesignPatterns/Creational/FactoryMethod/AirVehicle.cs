namespace DesignPatterns.Creational.FactoryMethod
{
    public class AirVehicle : VehicleCreator
    {
        protected override void CreateVehicle()
        {
            Vehicles.Add(new AirPlane());
        }
    }
}