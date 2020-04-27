using System;

namespace CountWords
{
    public class CountWords
    {
        public int Count(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            var subStrings = s.Split(new char[] {' ', ','});
            var newStrings = subStrings.Length;
            return newStrings;
        }
    }
}