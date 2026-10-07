using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace C__2
{
    internal class Perfecto
    {
        int num;
        int checknum;
        public Perfecto()
        {
            Console.WriteLine("Enter you num pls: ");
            num = int.Parse(Console.ReadLine());
        }
        public void Check()
        {
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    checknum += i;
                }
            }
            if (checknum == num)
            {
                Console.WriteLine("THis is perfect num");
            }
            else
            {
                Console.WriteLine("This is not perfect num");
            }
        }
    }
}
