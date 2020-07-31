namespace FactoryPattern
{
    public class BmwSimpleFactory : CarSimpleFactory
    {
        public override ICar CreateCar() => new Bmw();
    }
}