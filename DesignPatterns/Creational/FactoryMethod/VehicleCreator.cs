using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class VehicleCreator
    {
        public List<Vehicle> Vehicles { get; set; }

        protected VehicleCreator()
        {
            CreateVehicle();
        }

        //Factory method
        protected abstract void CreateVehicle();
    }
}