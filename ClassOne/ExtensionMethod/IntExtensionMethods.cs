namespace ExtensionMethod
{
    public static class IntExtensionMethods
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsEqualTo(this string str, string value)
        {
            return str == value;
        }
    }
}
