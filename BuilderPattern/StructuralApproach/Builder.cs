using System;

namespace DesignPatterns.BuilderPattern.StructuralApproach
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public abstract Product GetResult();
    }
}