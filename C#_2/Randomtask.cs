using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Randomtask
    {
        int first = 0;
        int second = 0;
        public Randomtask()
        {
            Console.WriteLine("Enter first num: ");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            second = int.Parse(Console.ReadLine());
            if (second < first)
            {
                int temp = first;
                first = second;
                second = temp;
            }
        }
        public void Get_Nums()
        {
            for (int i = first; i <= second; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
    }
}
