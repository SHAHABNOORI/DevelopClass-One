namespace FactoryPattern
{
    public class PrideFactoryMethod : ICarFactoryMethod
    {
        public ICar CreateInstance() => new Pride();
    }
}