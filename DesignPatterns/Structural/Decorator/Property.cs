namespace DesignPatterns.Structural.Decorator
{
    public interface IProperty
    {
        string Label { get; set; }
        string Value { get; set; }
    }

    public abstract class Property : IProperty
    {
        public virtual string Label { get; set; }
        public virtual string Value { get; set; }

        public abstract void Display();
    }
}