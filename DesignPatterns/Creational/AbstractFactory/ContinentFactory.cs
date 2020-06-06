namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    public abstract class Herbivore
    {
    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}