using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Bubble sort implementation");
        }
    }
}