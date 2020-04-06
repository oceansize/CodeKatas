using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Check(int i)
        {
            if (IsDivisibleByFifteen(i))
            {
                return "FizzBuzz";
            }
            if (IsDivisibleByThree(i))
            {
                return "Fizz";
            }
            if (IsDivisibleByFive(i))
            {
                return "Buzz";
            }
            return i.ToString();
        }

        private bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
        private bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
        private bool IsDivisibleByFifteen(int number)
        {
            return number % 15 == 0;
        }
    }
}
