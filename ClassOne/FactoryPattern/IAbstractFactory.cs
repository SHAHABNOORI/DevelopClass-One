namespace FactoryPattern
{
    public interface IAbstractFactory
    {
        ICar Luxury();

        ICar Cross();

        ICar Sedan();
    }
}