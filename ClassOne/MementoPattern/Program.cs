using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.AddFule(50);
            //Console.WriteLine(car.GetCarState());
            //car.IncreaseSpeed();
            //car.IncreaseSpeed();
            //Console.WriteLine(car.GetCarState());
            //car.IncreaseSpeed();

            CarState carState = new CarState()
            {
                Speed = 100,
                Fule = 60
            };

            var result = carState.ToString();
            Console.WriteLine(result);
        }
    }
}
