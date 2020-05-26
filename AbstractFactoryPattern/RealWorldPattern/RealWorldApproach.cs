using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern.RealWorldPattern
{
    class RealWorldApproach
    {

        public RealWorldApproach()
        {
            //Create and run the african animal Factory 
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            AnimalWorld world1 = new AnimalWorld(america);
            world1.RunFoodChain();

            Console.ReadKey();
        }
    }
}
