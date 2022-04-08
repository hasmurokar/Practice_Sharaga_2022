using _06_06_2022;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_04_2022
{
    class Program
    {
        private static Random rnd = new Random();
        public static List<Airplane> Airplanes = new List<Airplane>();
        static void Main(string[] args)
        {
            GenerateAirplanes();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите операцию:  Q - Создать самолет  W - Показать самолеты  E - Купить билеты  R - Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        CreateAirplane();
                        Exit();
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        ShowAirplanes(Airplanes);
                        Exit();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        BuyTicket();
                        Exit();
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Вы ввели неверную кнопку");
                        Exit();
                        break;
                }
            }
        }

        private static void BuyTicket()
        {
            Console.WriteLine("Введите количество билетов");
            var count = Airplane.CheckedValueInt();
            Airplane.ShowPlaces();
            Console.WriteLine("Введите город");
            var city = Console.ReadLine();
            var airplanes = Airplanes.Where(item => item.CheckAvailable(city, count)).ToList();
            ShowAirplanes(airplanes);
        }

        private static void CreateAirplane()
        {
            Airplanes.Add(Airplane.InputData());
        }

        private static void ShowAirplanes(List<Airplane> airplanes)
        {
            Console.WriteLine("Cписок билетов");
            foreach (var item in airplanes)
            {
                Console.WriteLine(item);
            }
            if (airplanes.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
        }

        private static void GenerateAirplanes()
        {
            Airplanes = new List<Airplane>();
            for (int i = 1; i <= 25; i++)
            {
                var destination = Airplane.RandomDestination();
                var departureTime = RandomDateTime();
                var freePlaces = rnd.Next(0, 10);
                Airplanes.Add(new Airplane(destination, departureTime, freePlaces));
            }
        }

        private static DateTime RandomDateTime(DateTime? min = null, DateTime? max = null)
        {
            min = min ?? new DateTime(2022, 04, 08);
            max = max ?? new DateTime(2022, 04, 12);

            var range = max.Value - min.Value;
            var randomUpperBound = (int)range.TotalMinutes;
            if (randomUpperBound <= 0)
                randomUpperBound = rnd.Next(1, int.MaxValue);

            var randTimeSpan = TimeSpan.FromMinutes((long)(range.TotalMinutes - rnd.Next(0, randomUpperBound)));
            return min.Value.Add(randTimeSpan);
        }
        private static void Exit()
        {
            Console.WriteLine("Нажмите для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
