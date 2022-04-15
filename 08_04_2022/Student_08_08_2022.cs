using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_2022
{
    public struct Student
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Distance { get; set; }

        public Student(string fullName, string address, int distance)
        {
            FullName = fullName;
            Address = address;
            Distance = distance;
        }

        public static Student InputStudent()
        {
            Console.WriteLine("Введите ФИО:");
            string fullName = ParseString();
            Console.WriteLine("Введите адресс:");
            string address = Console.ReadLine();
            Console.WriteLine("Введите расстоянтие до Краснодара(м):");
            int distance = CheckedValueInt();
            return new Student(fullName, address, distance);
        }

        public int GetDistance()
        {
            return Distance;
        }

        public override string ToString()
        {
            return $"ФИО: {FullName} ; Адресс: {Address} ; Расстояние до Краснодара: {GetDistance()}м";
        }

        public static int CheckedValueInt()
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
        public static string ParseString()
        {
            while (true)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out int value))
                {
                    Console.WriteLine("Введено неверное значение. Повторите попытку");
                }
                else
                {
                    return text;
                }
            }
        }
    }
}
