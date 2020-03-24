using System;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Structural.Composite;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new BubbleSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            Console.ReadKey();
        }
    }
}