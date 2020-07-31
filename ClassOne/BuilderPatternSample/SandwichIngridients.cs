namespace BuilderPatternSample
{
    public abstract class SandwichIngridients
    {
        public Sandwich Sandwich = new Sandwich();

        public abstract void SetBread();

        public abstract void SetMeat();

        public abstract void SetCheeze();
    }
}