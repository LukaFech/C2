using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Digitnums
    {
        int _first = 0;
        int _second = 0;
        int _third = 0;
        int _fourth = 0;

        public Digitnums(int first, int second, int third, int fourth)
        {
            if (first <= 0 || second < 0 || third < 0 || fourth < 0)
            {
                Console.WriteLine("All nums must be +");
                while(first <= 0 || second < 0 || third < 0 || fourth < 0)
                {
                    Console.WriteLine("Write 4 nums");
                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());
                    third = int.Parse(Console.ReadLine());
                    fourth = int.Parse(Console.ReadLine());
                }
                _first = first;
                _second = second;
                _third = third;
                _fourth = fourth;
            }
            else
            {
                _first = first;
                _second = second;
                _third = third;
                _fourth = fourth;
            }
        }
        public int GetNum()
        {
            return _first * 1000 + _second * 100 + _third * 10 + _fourth;
        }
    }
}
