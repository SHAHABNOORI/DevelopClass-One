namespace StrategyPattern.Pattern
{
    public class GoldCaculator : CalculateFinalPrice
    {
        public override int Calculate(int price) => price - (price / 100 * 30);
    }
}