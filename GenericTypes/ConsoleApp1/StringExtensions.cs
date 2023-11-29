namespace ConsoleApp1
{
    public static class StringExtensions
    {
        public static string Invert(this string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
