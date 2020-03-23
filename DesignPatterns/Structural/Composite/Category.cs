namespace DesignPatterns.Structural.Composite
{
    public abstract class Category
    {
        private readonly string _name;

        protected Category(string name)
        {
            _name = name;
        }

        public abstract void Add(Category category);
        public abstract void Remove(Category category);
        public abstract void Display(int depth);
    }
}
