namespace BuilderPatternSample
{
    public class SandwichBuilder
    {
        private SandwichIngridients _sandwichIngridients;

        public SandwichBuilder(SandwichIngridients sandwichIngridients)
        {
            _sandwichIngridients = sandwichIngridients;
            _sandwichIngridients.SetMeat();
            _sandwichIngridients.SetBread();
            _sandwichIngridients.SetCheeze();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichIngridients.Sandwich;
        }
    }
}