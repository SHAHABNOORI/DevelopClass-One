namespace StrategyPattern.Pattern
{
    public class BoronzeCalculator : CalculateFinalPrice
    {
        public override int Calculate(int price) => price - (price / 100 * 10);
    }
}