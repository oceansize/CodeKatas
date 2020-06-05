using System;
using Microsoft.VisualBasic.CompilerServices;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            if (s != null)
            {
                var reversedString = ReverseString(s);
                return reversedString.Equals(s);
            }

            return true;
        }

        public string ReverseString(string toReverse)
        {
            var charactersToReverse = toReverse.ToCharArray();
            var characterCount = charactersToReverse.Length;
            char[] reversedCharacters = new char[characterCount];

            for (var i = characterCount - 1; i >= 0; i--)
            {
                var currentCount = characterCount - i - 1;
                var currentChar = charactersToReverse[i];
                reversedCharacters[currentCount] = currentChar;
            }

            return new String(reversedCharacters);
        }
    }
}
