namespace FactoryPattern
{
    public class SaipaFactory : IAbstractFactory
    {
        public ICar Luxury() => new PrideZehdar();

        public ICar Cross() => new Pride111();

        public ICar Sedan() => new Pride();
    }
}