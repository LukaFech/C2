using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace C__2
{
    internal class Sixnums
    {
        int[] numbers = new int[6];
        int _first = 0;
        int _second = 0;
        public Sixnums(int first, int second)
        {
            for(int i = 0; i < 6; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                while (temp < 0 || temp > 9)
                {
                    Console.WriteLine("Enter num betwwen 0 and 9");
                    temp = int.Parse(Console.ReadLine());
                }
                numbers[i] = temp;
            }
            while (first <= 0 || first > 6 || second <= 0 || second > 6)
            {
                first = int.Parse(Console.ReadLine());
                second = int.Parse(Console.ReadLine());
            }
            _first = first;
            _second = second;
            int temp1 = numbers[_first - 1];
            numbers[_first - 1] = numbers[_second - 1];
            numbers[_second-1] = temp1;
        }
        public int GetNum()
        {
            int temp = 0;
            int tempnum = 100000;
            for (int i = 0; i < 6; i++)
            {
                temp += numbers[i] * tempnum;
                tempnum /= 10;
            }
            return temp;
        }
    }
}
