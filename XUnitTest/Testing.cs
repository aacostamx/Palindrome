using Palindrome;
using System;
using Xunit;

namespace XUnitTest
{
    public class Testing
    {
        [Fact]
        public void Is_Palindrome()
        {
            string text = "Madam";

            bool result = Program.IsPalindrom(text);

            Assert.True(result);
        }

        [Fact]
        public void Is_not_Palindrome()
        {
            string text = "AACOSTA";

            bool result = Program.IsPalindrom(text);

            Assert.False(result);
        }
    }
}
