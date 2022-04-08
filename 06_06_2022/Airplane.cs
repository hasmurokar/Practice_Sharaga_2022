using System;

namespace _06_06_2022
{
    public struct Airplane
    {
        private string Destination { get; set; }
        private DateTime DepartureTime { get; set; }
        private int FreePlaces { get; set; }
        private static string[] places = new string[] { "Китай, Пекин", "Россия, СПб", "Молдова, Кишинёв", "Украина, Киев", "Англия, Лондон", "Германия, Берлин" };

        public Airplane(string destination, DateTime departureTime, int freePlaces)
        {
            Destination = destination;
            DepartureTime = departureTime;
            FreePlaces = freePlaces;
        }
        public static string RandomDestination()
        {
            return places[new Random().Next(0, places.Length)];
        }
        public bool CheckAvailable(string destination, int freePlaces)
        {
            return CheckTime() && CheckDestination(destination) && CheckFreePlaces(freePlaces);
        }
        public static void ShowPlaces()
        {
            Console.WriteLine("Список мест, куда можно полететь:");
            foreach (var place in places)
            {
                Console.WriteLine(place);
            }
        }
        public static Airplane InputData()
        { 
            Console.WriteLine("Введите название пункта назначения:");
            string destination = ParseString();
            Console.WriteLine("Введите время отправления:");
            DateTime departureTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество свободных мест:");
            int freePlaces = CheckedValueInt();
            return new Airplane(destination, departureTime, freePlaces);
        }

        private bool CheckTime()
        {
            if (DepartureTime.Year == DateTime.Now.Year && DepartureTime.Month == DateTime.Now.Month && DepartureTime.Day == DateTime.Now.Day)
            {
                return DepartureTime.Hour < 12;
            }
            else
            {
                return false;
            }
        }
        private bool CheckDestination(string destination)
        {
            if (destination == Destination) return true;
            return false;
        }
        private bool CheckFreePlaces(int freePlaces)
        {
            return freePlaces <= FreePlaces;
        }
        public override string ToString()
        {
            return $"Пункт назначения: {Destination}  Время отправления: {DepartureTime} Свободные места: {FreePlaces}";
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
