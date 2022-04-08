using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _08_04_2022
{
    class Program
    {
        private static List<Student> Students = new List<Student>();
        private static List<Student> Loader = new List<Student>();
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            GenerateStudents();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите операцию: Q - Добавить студента A - Показать список студентов Z - Выделить места в общежитии \nЗагрузить данные в файл - S Загрузить данные из файла - X\nW - Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        AddStudent();
                        Exit();
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Список студентов:");
                        ShowStudents(Students, Students.Count);
                        Exit();
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        SetPlaces();
                        Exit();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine();
                        SaveFile();
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine();
                        ReadFile();
                        break;
                    case ConsoleKey.W:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную кнопку");
                        Exit();
                        break;

                }
            }
        }
        public static void SaveFile()
        {
            if (Students == null)
            {
                Console.WriteLine("Нет объектов для сохранения");
                return;
            }
            File.WriteAllText("Task.json", JsonConvert.SerializeObject(Students));
            Console.WriteLine("Файл создан");
        }
        public static bool ReadFile()
        {
            try
            {
                Students.Clear();
                Students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText("Task.json"));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Файл не найден. Ошибка: {ex.Message}");
                return false;
            }
        }

        private static void GenerateStudents()
        {
            for (int i = 1; i <= 25; i++)
            {
                var fullName = $"Иванов Иван Иванович {i}";
                var Address = $"г. Москва ул. Пушкина д. {rnd.Next(10, 200)} кв. {rnd.Next(1, 100)}";
                var distance = rnd.Next(500, 5000);
                Students.Add(new Student(fullName, Address, distance));
            }
        }

        private static void AddStudent()
        {
            Students.Add(Student.InputStudent());
        }

        private static void ShowStudents(IEnumerable<Student> students, int count)
        {
            var array = students.ToArray();
            if (array.Length == 0 || count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            if (count > array.Length) count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array.ToArray()[i]);
            }
        }

        private static void SetPlaces()
        {
            Console.WriteLine("Введите количество мест в общежитии:");
            var places = Student.CheckedValueInt();
            var students = Students.OrderBy(x => x.GetDistance()).ToList();
            var queueStudents = new Queue<Student>(students);
            Console.WriteLine("Очередь студентов:");
            ShowStudents(queueStudents, places);
        }

        private static void Exit()
        {
            Console.WriteLine("Нажмите для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
