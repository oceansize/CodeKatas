using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            char[] inputToCharacters = s.ToCharArray();
            var totalCharacters = inputToCharacters.Length;
            var reversedList = new List<char>();

            for (var i = 1 ; i <= totalCharacters; i++)
            {
                var lastChar = totalCharacters - i;
                reversedList.Add(inputToCharacters[lastChar]);
            }

            return new string(reversedList.ToArray());
        }
    }
}
