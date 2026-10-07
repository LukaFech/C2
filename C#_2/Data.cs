using System;
using System.Collections.Generic;
using System.Text;

namespace C__2
{
    internal class Data
    {
        //if m< 3:
        //    m += 12        //знайшов формулу в гітхабі бо не міг зрозуміти як вона працює 
        //    year -= 1
        //K = year % 100
        //J = year // 100
        //h = (q + 13 * (m + 1) // 5 + K + K // 4 + J // 4 + 5 * J) % 7
        int _day = 0;
        int _mon = 0;
        int _year = 0;
        public Data()
        {
            Console.WriteLine("Enter day:");
            _day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mounth:");
            _mon = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            _year = int.Parse(Console.ReadLine());
        }
        public string GetDay()
        {
            string[] days = new string[7];
            days[0] = "Saturday";
            days[1] = "Sunday";
            days[2] = "Monday";
            days[3] = "Tuesday";
            days[4] = "Wednesday";
            days[5] = "Thursday";
            days[6] = "Friday";
            if (_mon < 3)
            {
                _mon += 12;
                _year -= 1;
            }
            int K = _year % 100;                                                           
            int J = _year / 100;
            int Numofday = (_day + 13 * (_mon + 1) / 5 + K + K / 4 + J / 4 + 5 * J) % 7;
            return days[Numofday];
        }
    }
}
