using System;

namespace DesignPatterns.BuilderPattern.StructuralApproach
{
    internal class Director
    {
        internal void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();

        }
    }
}