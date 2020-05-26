namespace DesignPatterns.AbstractFactoryPattern
{
    internal class ConcreateFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}