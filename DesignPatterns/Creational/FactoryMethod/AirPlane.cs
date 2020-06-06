using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class AirPlane : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Airplane run impl");
        }
    }
}