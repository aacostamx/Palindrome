# How to check if a string is palindrome in c#

One of the most common C# questions for an exam is how to check if a string is a palindrome.

Here is a simple and elegant solution

    public static bool IsPalindrom(string text)
    {
        text = text.ToLower();
    
        char[] array = text.ToCharArray();
        Array.Reverse(array);
    
        return text.Equals(new string(array));
    }
