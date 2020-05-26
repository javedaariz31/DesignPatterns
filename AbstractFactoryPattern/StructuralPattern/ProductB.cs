using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class ProductB : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}