using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Check(int i)
        {
            if (IsDivisibleBy(i, 15))
            {
                return "FizzBuzz";
            }
            if (IsDivisibleBy(i, 3))
            {
                return "Fizz";
            }
            if (IsDivisibleBy(i, 5))
            {
                return "Buzz";
            }
            return i.ToString();
        }

        private bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
