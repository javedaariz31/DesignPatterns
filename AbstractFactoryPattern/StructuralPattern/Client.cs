namespace DesignPatterns.AbstractFactoryPattern
{
    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;


        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }


        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }



    }
}