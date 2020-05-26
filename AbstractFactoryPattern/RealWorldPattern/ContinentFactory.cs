namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    abstract class ContinentFactory
    {
        public abstract Herbivorus CreateHerbivorus();
        public abstract Carnivorus CreateCarnivorus();

    }
}