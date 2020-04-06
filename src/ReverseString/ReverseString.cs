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
            Array.Reverse(inputToCharacters);
            return new string(inputToCharacters);
        }
    }
}
