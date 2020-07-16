namespace DecoratorPattern
{
    public class SmalIceCream : IceCreame
    {
        public override int GetPrice() => 100;

        public override string GetName() => "Small IceCreame";
    }
}