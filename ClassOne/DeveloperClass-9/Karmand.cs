using System;

namespace DeveloperClass_9
{
    public abstract class Karmand
    {
        public Guid KarmandId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected string Age { get; set; }
    }
}