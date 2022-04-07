using _06_06_2022;
using System;
using System.Collections.Generic;

namespace _06_04_2022
{
    class Program
    {
        private static Random rnd = new Random();
        public static List<Airplane> airplanes = new List<Airplane>();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                var destination = RandomDestination();
                var departureTime = RandomDateTime();
                var freePlaces = rnd.Next(0, 10);
                airplanes.Add(new Airplane(destination, departureTime, freePlaces));
            }
            Console.WriteLine("Cписок всех билетов");
            foreach (var item in airplanes)
            {
                Console.WriteLine(item);
            }
            if (airplanes.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
        }
        public static string RandomDestination()
        {
            var array = new string[7];
            array[0] = "Китай, Пекин";
            array[1] = "Россия, СПб";
            array[2] = "Молдова, Кишинёв";
            array[3] = "Украина, Киев";
            array[4] = "Румыния, Бухарест";
            array[5] = "Англия, Лондон";
            array[6] = "Германия, Берлин";
            string result = array[rnd.Next(0, array.Length - 1)];
            return result;
        }

        public static DateTime RandomDateTime(DateTime? min = null, DateTime? max = null)
        {
            min = min ?? new DateTime(2022, 04, 07);
            max = max ?? new DateTime(2022, 04, 14);

            var range = max.Value - min.Value;
            var randomUpperBound = (Int32)range.TotalMinutes;
            if (randomUpperBound <= 0)
                randomUpperBound = rnd.Next(1, Int32.MaxValue);

            var randTimeSpan = TimeSpan.FromMinutes((Int64)(range.TotalMinutes - rnd.Next(0, randomUpperBound)));
            return min.Value.Add(randTimeSpan);
        }
    }
}
