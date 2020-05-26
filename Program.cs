using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.Singleton_Pattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Different Singleton patterns being called. 
            //SingletonPattern singletonPattern = new SingletonPattern();

            //Factory pattern Structural Approach.
            FactoryPatternStructuralApproach structuralApproach = new FactoryPatternStructuralApproach();

        }
    }
}
