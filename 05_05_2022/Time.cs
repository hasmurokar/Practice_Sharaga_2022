using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_2022
{
    public class Time
    {
        private int Hour { get; set; }
        private int Minute { get; set; }
        private int Second { get; set; }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public void EditHour()
        {
            Console.WriteLine("Введите кол-во часов, которые вы хотите добавить");
            int value = CheckedValueInt();
            if (value > 0)
            {
                for (int i = 0; i < value; i++)
                {
                    Hour++;
                    if (Hour > 23)
                    {
                        Hour = 0;
                    }
                }
                Output();
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели отрицательное число");
            }
        }

        public void EditMinute()
        {
            Console.WriteLine("Введите кол-во минут, которые вы хотите добавить");
            int value = CheckedValueInt();
            if (value > 0)
            {
                for (int i = 0; i < value; i++)
                {
                    Minute++;
                    if (Minute == 60)
                    {
                        Minute = 0;
                        Hour++;
                    }
                }
                Output();
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели отрицательное число");
            }
        }
        public void EditSecond()
        {
            Console.WriteLine("Введите кол-во секунд, которые хотите добавить");
            int value = CheckedValueInt();
            if (value > 0)
            {
                for (int i = 0; i < value; i++)
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
                Output();
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели отрицательное число");
            }
            
        }

        public static Time InputTime()
        {
            while (true)
            {
                Console.WriteLine("Введите часы: ");
                var hour = CheckedValueInt();
                Console.WriteLine("Введите минуты: ");
                var minute = CheckedValueInt();
                Console.WriteLine("Введите секунды: ");
                var second = CheckedValueInt();
                if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
                {
                    return new Time(hour, minute, second);
                }
                Console.WriteLine("Не верный формат времени. Повторите попытку...");
            }
        }

        public void Output()
        {
            Console.WriteLine($"Время: {ConvertForOutput(Hour)}:{ConvertForOutput(Minute)}:{ConvertForOutput(Second)}");
        }
        private string ConvertForOutput(int number)
        {
            return number >= 0 && number < 10 ? "0" + number.ToString() : number.ToString();
        }
        private static int CheckedValueInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    return val;
                }
                else
                {
                    Console.WriteLine("Неверный формат. Повторите попытку.");
                }
            }
        }
    }
}

