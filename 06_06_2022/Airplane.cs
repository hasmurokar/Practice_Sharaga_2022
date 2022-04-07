using System;

namespace _06_06_2022
{
    public struct Airplane
    {
        private string Destination { get; set; }
        private DateTime DepartureTime { get; set; }
        private int FreePlaces { get; set; }

        public Airplane(string destination, DateTime departureTime, int freePlaces)
        {
            Destination = destination;
            DepartureTime = departureTime;
            FreePlaces = freePlaces;
        }
        private static void CheckTime(DateTime time)
        {
            if (time )
            {

            }
        }
        private static void CheckDestination(string destination)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите пункт назначения:\nКитай, Пекин(С); Россия, Спб(R); Молдова, Кишинёв(M); Украина, Киев(U);\nРумыния, Бухарест(P); Англия, Лондон(E); Германия, Берлин(G)");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        if (destination.Contains("Китай"))
                        {
                            
                        }
                        break;
                    case ConsoleKey.R:

                        break;
                    case ConsoleKey.M:

                        break;
                    case ConsoleKey.U:

                        break;
                    case ConsoleKey.P:

                        break;
                    case ConsoleKey.E:

                        break;
                    case ConsoleKey.G:

                        break;
                    default:
                        Console.WriteLine("Неверная буква, повторите попытку");
                        break;
                }
            }
        }
        private static void CheckAvailable()
        {
            
        }
        public override string ToString()
        {
            return $"Пункт назначения: {Destination}  Время отправления: {DepartureTime} Свободные места: {FreePlaces}";
        }
    }
}
