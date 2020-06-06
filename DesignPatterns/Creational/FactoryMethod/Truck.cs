using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck run implemantation");
        }
    }
}