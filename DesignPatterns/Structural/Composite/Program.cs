namespace DesignPatterns.Structural.Composite
{
    public class Program
    {
        public Program()
        {
            var car = new RootCategory("car");
            car.Add(new ChildCategory("hybrit"));
            car.Add(new ChildCategory("diesel"));

            var gasoline = new RootCategory("gasoline");
            gasoline.Add(new ChildCategory("manual"));
            gasoline.Add(new ChildCategory("automatic"));

            car.Add(gasoline);

            car.Display(1);
        }
    }
}