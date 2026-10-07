using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Tempriture
    {
        int choice = 0;
        double _tempriture = 0;
        public Tempriture()
        {
            Console.WriteLine("Farenheit: - 1, cel - 2");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tempriture");
            _tempriture = double.Parse(Console.ReadLine());
            
        }
        public double Get_temp()
        {
            if (choice == 1)
            {
                return (_tempriture - 32) * 0.556;
            }
            return _tempriture * 1.8 + 32;
        }

    }
}
