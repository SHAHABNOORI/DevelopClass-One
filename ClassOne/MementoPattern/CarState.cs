namespace MementoPattern
{
    public class CarState
    {
        public int Fule { get; set; }

        public int Speed { get; set; }
        
        public override string ToString() => $"Fule : {Fule} , Speed : {Speed}";
    }
}