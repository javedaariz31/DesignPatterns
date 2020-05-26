using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AbstractFactoryPattern.RealWorldPattern;
using DesignPatterns.BuilderPattern.StructuralApproach;
using DesignPatterns.Singleton_Pattern;
using DesignPatterns.Singleton_Pattern.RealWorldApproach;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Different Singleton patterns being called. 
            //SingletonPattern singletonPattern = new SingletonPattern();

            //RealWorld Singleton approach
            //RealWorldSingleton realWorldApproach = new RealWorldSingleton();


            //Factory pattern Structural Approach.
            //FactoryPatternStructuralApproach structuralApproach = new FactoryPatternStructuralApproach();


            //Factory Pattern with RealTime Eaxample
            //RealWorldApproach realWorld = new RealWorldApproach();

            //Builder pattern
            BuilderStructuralApproach builderStructuralApproach = new BuilderStructuralApproach();
        }
    }
}
