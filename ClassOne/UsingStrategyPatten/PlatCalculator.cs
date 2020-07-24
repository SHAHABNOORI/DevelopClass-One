using System.Text.RegularExpressions;
using StrategyPattern.Pattern;

namespace UsingStrategyPattern
{
    public class PlatCalculator : CalculateFinalPrice
    {
        public override int Calculate(int price) => price - (price / 100 * 50);
    }
}