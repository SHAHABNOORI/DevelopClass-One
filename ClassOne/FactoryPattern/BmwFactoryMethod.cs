namespace FactoryPattern
{
    public class BmwFactoryMethod : ICarFactoryMethod
    {
        public ICar CreateInstance() => new Bmw();
    }
}