using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car run implemantation");
        }
    }
}