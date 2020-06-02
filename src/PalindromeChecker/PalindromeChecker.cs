using System;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            if (s != null)
            {
                var originalString = s.ToCharArray();
                Array.Reverse(originalString);
                var reversedString = new String(originalString);
                return reversedString.Equals(s);
            }

            return true;
        }
    }
}
