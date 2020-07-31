namespace FactoryPattern
{
    public class BmwFactory : IAbstractFactory
    {
        public ICar Luxury() => new BmwS7();

        public ICar Cross() => new BmwX3();

        public ICar Sedan() => new Bmw();
    }
}