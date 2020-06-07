using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Button : IRender
    {
        public void Render()
        {
            Console.WriteLine("Button render");
        }
    }
}