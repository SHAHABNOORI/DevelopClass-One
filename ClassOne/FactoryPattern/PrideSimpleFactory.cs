namespace FactoryPattern
{
    public class PrideSimpleFactory : CarSimpleFactory
    {
        public override ICar CreateCar() => new Pride();

    }
}