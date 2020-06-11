using System;

namespace DeveloperClass_7.Models
{
    public class ClassRoom
    {
        public ClassRoom(string building, int floor, int number)
        {
            Id = Guid.NewGuid();
            Building = building;
            Floor = floor;
            Number = number;
        }

        public Guid Id { get; }

        public string Building { get; set; }

        public int Floor { get; set; }

        public int Number { get; set; }

        public string Identity => $"Id : {Id} ; Building : {Building} ; Floor : {Floor} ; Number : {Number}";
    }
}