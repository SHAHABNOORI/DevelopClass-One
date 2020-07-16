namespace DecoratorPattern
{
    public class IceCreameDecorator : IceCreame
    {
        private IceCreame _iceCreame;

        public IceCreameDecorator(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override string GetName() => _iceCreame.GetName();

        public override int GetPrice() => _iceCreame.GetPrice();
    }
}