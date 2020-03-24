using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSort sort implementation");
        }
    }
}