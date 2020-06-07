using System;

namespace DesignPatterns.Structural.Decorator
{
    public class TextBox : Property
    {
        public string Placeholder { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Label} -{Value} - {Placeholder}");
        }
    }
}