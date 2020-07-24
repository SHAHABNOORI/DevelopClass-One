using System;
using StrategyPattern.Models;
using StrategyPattern.Pattern;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //LegacyWay();
            Customer customerOne = new Customer
            {
                FullName = "Shahab Noori Goodarzi",
                Type = CustomerType.Iron
            };

            Order orderOne = new Order(50000, customerOne, new SilverCalculator());
            Console.WriteLine(orderOne.GetFinalUsingPattern());
            }

        private static void LegacyWay()
        {
            Customer customerOne = new Customer
            {
                FullName = "Shahab Noori Goodarzi",
                Type = CustomerType.Gold
            };

            Order orderOne = new Order(50000, customerOne);
            Console.WriteLine(orderOne.GetFinalInLegacyWay());
        }
    }
}
