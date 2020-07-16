namespace DecoratorPattern
{
    public class LargeIceCream : IceCreame
    {
        public override int GetPrice() => 200;

        public override string GetName() => "Large IceCreame";
    }
}