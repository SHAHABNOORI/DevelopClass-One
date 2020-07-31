using System;

namespace StatePattern
{
    public class OffState : IState
    {
        public bool ChangeState()
        {
            Console.WriteLine("Turned it On");
            return true;
        }
    }
}