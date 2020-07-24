namespace StrategyPattern.Pattern
{
    public class SilverCalculator:CalculateFinalPrice
    {
        public override int Calculate(int price) => price - (price / 100 * 20);
    }
}