using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class RootCategory : Category
    {
        private readonly string _name;
        private List<Category> _children = new List<Category>();

        public RootCategory(string name) : base(name)
        {
            _name = name;
        }

        public override void Add(Category category)
        {
            _children.Add(category);
        }

        public override void Remove(Category category)
        {
            _children.Remove(category);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
            _children.ForEach(category => category.Display(depth + 2));
        }
    }
}
