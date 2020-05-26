namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    internal class AmericaFactory : ContinentFactory
    {
        public override Carnivorus CreateCarnivorus()
        {
            return new Wolf();
        }

        public override Herbivorus CreateHerbivorus()
        {
            return new Bison();
        }
    }
}