﻿using System;
using FacadePatternSample.ExternalServices;

namespace FacadePatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingFacadePattern();
        }

        private static void UsingFacadePattern()
        {
            var tempFacade = new TempFacade();
            var tempByTempFacade = tempFacade.GetTemp("12455623");
            Console.WriteLine("Temp By Facade Pattern :: " + tempByTempFacade);
        }

        private static void WithoutUsingFacadePattern()
        {
            var zoneFinder = new ZoneFinder();
            var zone = zoneFinder.GetZone("12455623");
            var tempratureService = new TempratureService();
            var tempf = tempratureService.GetTemp(zone);
            var tempConvertor = new TempConvertor();
            var finalTemp = tempConvertor.GetS(tempf);
            Console.WriteLine("Final Temp : " + finalTemp);
        }
    }
}
