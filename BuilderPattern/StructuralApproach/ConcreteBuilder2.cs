namespace DesignPatterns.BuilderPattern.StructuralApproach
{
    internal class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("partX");
        }

        public override void BuildPartB()
        {
            _product.Add("partY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}