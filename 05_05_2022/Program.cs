using _05_05_2022;
using System;

namespace _05_04_2022
{
    class Program
    {
        private static Time Time = null;
        static void Main(string[] args)
        {
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите операцию:\nЗаполнить вручную(Q)\nИзменить кол-во часов(A)\nИзменить кол-во минут(Z)\nИзменить кол-во секунд(W)\nПоказать время(S)\nВыход(X)");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        Time = Time.InputTime();
                        Exit();
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        Time.EditHour();
                        Exit();
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        Time.EditMinute();
                        Exit();
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        Time.EditSecond();
                        Exit();
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Time.Output();
                        Exit();
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        flag = false;
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную кнопку");
                        break;

                }
            }
        }
        private static void Exit()
        {
            Console.WriteLine("Нажмите для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
