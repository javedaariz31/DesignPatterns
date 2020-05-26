namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    internal class AfricaFactory : ContinentFactory
    {
        public override Carnivorus CreateCarnivorus()
        {
            return new Lion();
        }

        public override Herbivorus CreateHerbivorus()
        {
            return new WildBeast();
        }
    }
}