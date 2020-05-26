using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.StructuralApproach
{
    class BuilderStructuralApproach
    {
        public BuilderStructuralApproach()
        {
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product P1 = b1.GetResult();
            P1.Show();

            director.Construct(b2);
            Product P2 = b2.GetResult();
            P2.Show();

            Console.ReadLine();
        }
    }
}
