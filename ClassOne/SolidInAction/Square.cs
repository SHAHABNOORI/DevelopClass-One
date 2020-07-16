namespace SolidInAction
{
    public class Square:ChaharZeli
    {
        public int ZelOne { get; set; }
        public int ZelTwo { get; set; }
        public int ZelThree { get; set; }
        public int ZelFour { get; set; }

        public int Mohit()
        {
            return ZelOne * 4;
        }


        public int Masahat()
        {
            return ZelOne * ZelOne;
        }
    }
}