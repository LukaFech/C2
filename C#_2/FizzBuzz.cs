using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class FizzBuzz
    {
        int _num = 0;

        public FizzBuzz(int num)
        {
            if (Check(num))
            {
                while (Check(num))
                {
                    Console.WriteLine("Num must be between 1 and 100. Enter num: ");
                    num = int.Parse(Console.ReadLine());
                }
                _num = num;
            }
            else
            {
                _num = num;
            }
        }

        bool Check(int num)
        {
            if (num >= 1 && num <= 100)
            {
                return false;
            }
            return true;
        }

        public string GetFizzBuzz()
        {

            if (_num % 3 == 0)
            {
                if (_num % 5 == 0)
                {
                    return ("Fizz Buzz");
                }
                else
                {
                    return ("Fizz");
                }
            }
            else if (_num % 5 == 0)
            {
                return ("Buzz");
            }
            else
            {
                return ($"{_num}");
            }
        }
    }
}
