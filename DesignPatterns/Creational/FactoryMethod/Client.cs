using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public Client()
        {
            var vehicles = new List<VehicleCreator>
            {
                new AirVehicle(),
                new LandVehicle(),
                new SeaVehicles()
            };
        }
    }
}