using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseSimpleFactory();
            //UseAnotherSimpleFactory();
            //UseFactoryMethod();
            //UseAbstractFactory();
        }

        private static void UseAbstractFactory()
        {
            IAbstractFactory factory = new SaipaFactory();
            var car = factory.Luxury();
            car.Start();
            car.Stop();
        }

        private static void UseFactoryMethod()
        {
            ICarFactoryMethod carFactory = new PrideFactoryMethod();
            ICar car = carFactory.CreateInstance();
            car.Start();
            car.Stop();
        }

        private static void UseAnotherSimpleFactory()
        {
            ICar car = GetCar(new BmwSimpleFactory());
            car.Start();
            car.Stop();
        }

        private static void UseSimpleFactory()
        {
            ICar car = GetCar(CarName.Bmw);
            car.Start();
            car.Stop();
        }

        //Simple Factory
        static ICar GetCar(CarName carName)
        {
            ICar car = null;

            switch (carName)
            {
                case CarName.Pride:
                    car = new Pride();
                    break;

                case CarName.Bmw:
                    car = new Bmw();
                    break;
            }

            return car;
        }

        //Another Simple Factory
        static ICar GetCar(CarSimpleFactory factory) => factory.CreateCar();
    }
}
