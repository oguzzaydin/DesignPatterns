using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Ship : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Ship run implementation");
        }
    }
}