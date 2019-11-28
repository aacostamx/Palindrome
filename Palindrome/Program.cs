using System;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "Madam";

            string result = IsPalindrom(text) ? $"{text} is a palidrom!" : $"{text} is not a palidrom!";

            Console.WriteLine(result);
        }

        public static bool IsPalindrom(string text)
        {
            text = text.ToLower();

            char[] array = text.ToCharArray();
            Array.Reverse(array);

            return text.Equals(new string(array));
        }
    }
}
