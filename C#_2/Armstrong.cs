using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Armstrong
    {
        int num;
        int count;
        public Armstrong()
        {
            Console.WriteLine("Enter a num");
            count = int.Parse(Console.ReadLine());
            int temp = 6;
            int temp1 = 10;
            while (temp != count)
            {
                temp = count % temp1;
                temp1 *= 10;
                num++;
            }
            Console.WriteLine(num);
        }
        public void Check()
        {
            int sum = 0;
            int checknum = count;
            for (int i = 0; i < num; i++)
            {
                int temp5 = checknum % 10;
                int temp6 = checknum % 10;
                for (int y = 0; y < num-1; y++)
                {
                    temp6 *= temp5;
                }
                sum += temp6;
                checknum /= 10;
            }
            if (sum == count)
            {
                Console.WriteLine("THis is armstrong num");
            }
            else
            {
                Console.WriteLine("Nah");
            }
        }
    }
}
