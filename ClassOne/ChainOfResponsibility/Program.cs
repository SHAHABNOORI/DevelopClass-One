using System;
using ChainOfResponsibility.Models;
using ChainOfResponsibility.Pattern;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            var from = new Customer()
            {
                AccountValue = 10000,
                Password = "1234",
                Active = false,
                MaxDateValue = 200
            };

            var to = new Customer()
            {
                AccountValue = 20000,
                Password = "1234",
                Active = true,
                MaxDateValue = 2000
            };

            var transferPathOne =
                new CheckPassword(new CheckBallance(new CheckCustomerActiveState(new FinalizeTransfer(null))));

            var result = transferPathOne.Execute(new RequestContext()
            {
                From = from,
                Value = 10,
                Password = "1234",
                To = to
            });

            Console.WriteLine($"Result :: {result.Message}");

        }
    }
}
