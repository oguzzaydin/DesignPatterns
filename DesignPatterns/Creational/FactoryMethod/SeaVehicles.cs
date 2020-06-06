namespace DesignPatterns.Creational.FactoryMethod
{
    public class SeaVehicles : VehicleCreator
    {
        protected override void CreateVehicle()
        {
            Vehicles.Add(new Ship());
        }
    }
}