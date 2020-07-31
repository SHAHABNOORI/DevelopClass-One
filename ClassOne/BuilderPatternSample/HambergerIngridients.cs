namespace BuilderPatternSample
{
    public class HambergerIngridients : SandwichIngridients
    {
        public override void SetBread() => Sandwich.BreadType = BreadType.Hamberger;

        public override void SetMeat() => Sandwich.MeatType = MeatType.Berger;

        public override void SetCheeze() => Sandwich.CheezType = CheezType.Mazarella;
    }
}