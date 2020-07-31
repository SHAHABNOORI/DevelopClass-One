using System;

namespace StatePattern
{
    public class Tv
    {
        private bool _isOn = false;

        private IState _state;

        public bool IsOn
        {
            get => _isOn;
            set
            {
                _isOn = value;
                _state = IsOn ? (IState)new OnState() : new OffState();
            }
        }

        public Tv()
        {
            _state = new OffState();
        }

        public void OnOffPush()
        {
            IsOn = _state.ChangeState();
        }


        //public bool PushOn()
        //{
        //    Console.WriteLine("Turned it off");
        //    return false;
        //}

        //public  bool PushOff()
        //{
        //    Console.WriteLine("Turned it On");
        //    return true;
        //}
    }
}