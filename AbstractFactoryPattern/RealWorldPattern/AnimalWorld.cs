namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    internal class AnimalWorld
    {
        private Herbivorus _herbivorus;
        private Carnivorus _carnivorus;

        internal AnimalWorld(ContinentFactory factory)
        {
            _herbivorus = factory.CreateHerbivorus();
            _carnivorus = factory.CreateCarnivorus();
        }

        internal void RunFoodChain()
        {
            _carnivorus.Eat(_herbivorus);
        }
    }
}