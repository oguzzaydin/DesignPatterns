using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class SortedList
    {
        private SortStrategy SortStrategy { get; set; }
        private List<string> _list = new List<string>();

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            SortStrategy.Sort(_list);

            foreach (string name in _list) Console.WriteLine(" " + name);
            Console.WriteLine();
        }
    }
}