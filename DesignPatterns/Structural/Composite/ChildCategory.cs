using System;

namespace DesignPatterns.Structural.Composite
{
    public class ChildCategory : Category
    {
        private readonly string _name;

        public ChildCategory(string name) : base(name)
        {
            _name = name;
        }

        public override void Add(Category category)
        {
            Console.WriteLine("Add to children");
        }

        public override void Remove(Category category)
        {
            Console.WriteLine("Remove to children");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }
    }
}