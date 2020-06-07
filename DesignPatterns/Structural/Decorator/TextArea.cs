using System;

namespace DesignPatterns.Structural.Decorator
{
    public class TextArea : Property
    {
        public string Row { get; set; }
        public string Col { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Label} -{Value} - {Row} - {Col}");
        }
    }
}