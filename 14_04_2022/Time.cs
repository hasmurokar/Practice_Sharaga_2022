using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_2022
{
    internal class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public void EditHour(int hour)
        {
            for (int i = 0; i < hour; i++)
            {
                Hour++;
                if (Hour > 23)
                {
                    Hour = 0;
                }
            }
        }

        public void EditMinute(int minute)
        {
            if (minute > 0)
            {
                for (int i = 0; i < minute; i++)
                {
                    Minute++;
                    if (Minute == 60)
                    {
                        Minute = 0;
                        Hour++;
                    }
                }
            }
        }
        public void EditSecond(int second)
        {
            if (second > 0)
            {
                for (int i = 0; i < second; i++)
                {
                    Second++;
                    if (Second > 59)
                    {
                        Second = 0;
                        Minute++;
                        if (Minute > 59)
                        {
                            Minute = 0;
                            Hour++;
                        }
                    }
                }
            }
        }

        public static Time InputTime(int hour, int minute, int second)
        {
            if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
            {
                return new Time(hour, minute, second);
            }
            else
            {
                throw new Exception("Введено неверное значение");
            }
        }

        public string Output()
        {
            return $"{ConvertForOutput(Hour)}:{ConvertForOutput(Minute)}:{ConvertForOutput(Second)}";
        }
        private string ConvertForOutput(int number)
        {
            return number >= 0 && number < 10 ? "0" + number.ToString() : number.ToString();
        }
}
}
