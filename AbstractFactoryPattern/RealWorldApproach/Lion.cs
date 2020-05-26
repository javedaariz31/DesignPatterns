using System;

namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    internal class Lion : Carnivorus
    {
        public override void Eat(Herbivorus h)
        {
            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }
}