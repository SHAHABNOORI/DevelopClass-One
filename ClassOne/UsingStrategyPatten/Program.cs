using System;
using StrategyPattern.Models;
using StrategyPattern.Pattern;
using UsingStrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        Customer customerOne = new Customer
        {
            FullName = "Shahab Noori Goodarzi",
            Type = CustomerType.Iron
        };

        Order orderOne = new Order(50000, customerOne, new PlatCalculator());
        Console.WriteLine(orderOne.GetFinalUsingPattern());
    }
}
