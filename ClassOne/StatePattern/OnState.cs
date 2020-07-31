using System;

namespace StatePattern
{
    public class OnState:IState
    {
        public bool ChangeState()
        {
            Console.WriteLine("Turn it Off");
            return false;
        }
    }
}