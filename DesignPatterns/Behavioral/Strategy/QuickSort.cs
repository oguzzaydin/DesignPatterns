using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSort implementation");
        }
    }
}