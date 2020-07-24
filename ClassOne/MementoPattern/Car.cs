namespace MementoPattern
{
    public class Car
    {
        private int _fule;
        private int _speed;

        public Car()
        {

        }

        public void AddFule(int value) => _fule += value;

        public void IncreaseSpeed() => _speed += 10;

        public void DecreaseSpeed() => _speed -= 10;

        public CarState GetCarState() => new CarState { Fule = _fule, Speed = _speed };
    }
}