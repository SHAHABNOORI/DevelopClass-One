namespace SingletonPattern
{
    public class SiteSetting
    {
        private static SiteSetting _instance = new SiteSetting();
       
        public static SiteSetting GetInstance()
        {
            return _instance;
        }

        public string SiteName { get; set; } = "Hello World";

        private SiteSetting()
        {

        }
    }
}