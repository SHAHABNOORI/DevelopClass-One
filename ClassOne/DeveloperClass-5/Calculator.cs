using System;

namespace DeveloperClass_5
{
    public class Calculator
    {
        public int NumberOne;

        private int _numberTwo;

        public int NumberTwoGetter()
        {
            return _numberTwo;
        }

        public bool NumberTwoSetter(int numberTwo)
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Addad dovom nabayad sefr bashad");
                return false;
            }

            _numberTwo = numberTwo;
            return true;
        }

        public int Add()
        {
            var result = NumberOne + _numberTwo;
            return result;
        }

        public int Sub()
        {
            var result = NumberOne - _numberTwo;
            return result;
        }

        public int Div()
        {
            var result = NumberOne / _numberTwo;
            return result;
        }

        public int Mul()
        {
            var result = NumberOne * _numberTwo;
            return result;
        }

    }
}