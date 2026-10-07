using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Percent
    {
        int _number = 0;
        int _percent = 0;
        public Percent (int number, int percent)
        {
            _number = number;
            if (Check(percent))
            {
                while (Check(percent))
                {
                    Console.WriteLine("Percent must be between 1 and 100. Enter num: ");
                    percent = int.Parse(Console.ReadLine());
                }
                _percent = percent;
            }
            else
            {
                _percent = percent;
            }
        }
        public void Calculate()
        {
            double temp = (_number * _percent) / 100.0;
            Console.WriteLine(temp);
        }
        bool Check(int a)
        {
            if (a >= 1 && a <= 100)
            {
                return false;
            }
            return true;
        }
    }
}
