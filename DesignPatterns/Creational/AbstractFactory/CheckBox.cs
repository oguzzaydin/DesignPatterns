using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class CheckBox : IRender
    {
        public void Render()
        {
            Console.WriteLine("Checkbox render");
        }
    }
}