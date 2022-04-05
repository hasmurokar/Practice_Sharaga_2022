using System;

namespace _04_04_2002
{
    class Program
    {
        private static int[,] matrix;
        private static int[,] rotatedMatrix;
        private static int matrixSize;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите размерность матрицы(не больше 12 и не меньше 2):");
                matrixSize = int.Parse(Console.ReadLine());
                if (matrixSize <= 12 && matrixSize >= 2)
                {
                    break;
                }
                Console.WriteLine("Неверная размеронсть матрицы");
            }
            matrix = new int[matrixSize, matrixSize];
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите операцию:\nЗаполнить вручную(A) или автоматически(B)\nПовернуть матрицу(С)\nВыход(Е)");
                var inputValue = Console.ReadKey();
                switch (inputValue.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        SetArrayByHand();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        SetArrayRnd();
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        RotateArray();
                        break;
                    case ConsoleKey.E:
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

        private static void RotateArray()
        
        {
            int[,] array = null;
            if (rotatedMatrix != null)
            {
                array = rotatedMatrix;
                rotatedMatrix = new int[matrixSize, matrixSize];
            }
            else
            {
                array = matrix;
                rotatedMatrix = new int[matrixSize, matrixSize];
            }
            for (int i = rotatedMatrix.GetLength(0) - 1; i >= 0; --i)
            {
                for (int j = 0; j < rotatedMatrix.GetLength(1); ++j)
                {
                    rotatedMatrix[j, (rotatedMatrix.GetLength(0) - 1) - i] = array[i, j];
                }
            }

            Console.WriteLine("Исходная матрицы");
            OutputArray(matrix);
            Console.WriteLine("Развернутая матрица");
            OutputArray(rotatedMatrix);
            Exit();
        }

        private static void SetArrayRnd()
        {
            var rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 99);
                }
            }
            Console.WriteLine("Матрица заполнена случайными числами");
            OutputArray(matrix);
            Exit();
        }

        private static void SetArrayByHand()
        {
            Console.WriteLine("Введите числа от 1 до 99");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = CheckValue();
                }
            }
            Console.WriteLine("Матрица введена с клавиатуры");
            OutputArray(matrix);
            Exit();
        }
        private static void OutputArray(int[,] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {

                Console.WriteLine("Массив пуст");
            }
        }
        private static int CheckValue()
        {
            int value;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                value = Convert.ToInt32(Console.ReadLine());
                if (value <= 99 && value >= 1)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Число больше 99 или меньше 1");
                }
            }

        }
        private static void Exit()
        {
            Console.WriteLine("Нажмите чтоб начать ввод данных");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
