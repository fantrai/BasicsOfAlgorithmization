using System;
using System.Data;
using System.Windows;

namespace Tasks
{
    static class ServiceMetods
    {
        /// <summary>
        /// программа будет ожидать нажатие клавиши с клавиатуры
        /// </summary>
        public static void TapToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// считывает ввод от пользователя с учетом ошибок
        /// </summary>
        /// <returns></returns>
        public static void InputValue(out float returnValue, float minValue = float.MinValue, float maxValue = float.MaxValue)
        {
            bool parse = false;
            do
            {
                parse = float.TryParse(Console.ReadLine(), out returnValue);
                if (!parse)
                {
                    Console.WriteLine("Введено некорректное значение! Попробуйте снова!");
                    continue;
                }
                if (!(returnValue >= minValue && returnValue <= maxValue))
                {
                    parse = false;
                    if (returnValue <= minValue) Console.WriteLine($"Введенное число должно быть больше {minValue}! Попробуйте снова!");
                    else Console.WriteLine($"Введенное число должно быть меньше {maxValue}! Попробуйте снова!");
                    continue;
                }
            } while (!parse);
        }
        public static void InputValue(out int returnValue, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            bool parse = false;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out returnValue);
                if (!parse)
                {
                    Console.WriteLine("Введено некорректное значение! Попробуйте снова!");
                    continue;
                }
                if (!(returnValue >= minValue && returnValue <= maxValue))
                {
                    parse = false;
                    if (returnValue <= minValue) Console.WriteLine($"Ваше число должно быть больше {minValue}! Попробуйте снова!");
                    else Console.WriteLine($"Ваше число должно быть меньше {maxValue}! Попробуйте снова!");
                    continue;
                }
            } while (!parse);
        }

        /// <summary>
        /// заполняет массив вводом пользователя с учетом ошибок
        /// </summary>
        /// <param name="returnMassiv"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public static void InputArray(ref int[] returnMassiv, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            for (int i = 0; i < returnMassiv.Length; i++)
            {
                Console.Write($"Введите элемент {i +1}: ");
                InputValue(out returnMassiv[i]);
            }
        }
        public static void InputArray(ref float[] returnMassiv, float minValue = float.MinValue, float maxValue = float.MaxValue)
        {
            for (int i = 0; i < returnMassiv.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                InputValue(out returnMassiv[i]);
            }
        }

        /// <summary>
        /// заполняет массив случайными значениями
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minRandValue"></param>
        /// <param name="maxRandValue"></param>
        /// <param name="writeToConcole"></param>
        public static void RandomValForArray(ref int[] array, int minRandValue = int.MinValue, int maxRandValue = int.MaxValue, bool writeToConcole = false)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Random random = new Random();

            if (writeToConcole) Console.WriteLine("\nСоздание случайного массива...");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandValue, maxRandValue);
                if (writeToConcole) Console.Write(array[i] + "  ");
            }

            if (writeToConcole) Console.WriteLine("\nВаш массив готов!\n");

            Console.ForegroundColor = consoleColor;
        }

        /// <summary>
        /// заполняет матрицу случайными значениями
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="minRandValue"></param>
        /// <param name="maxRandValue"></param>
        public static void RandomValForMatrix(ref int[,] matrix, int minRandValue = int.MinValue, int maxRandValue = int.MaxValue, bool writeToConcole = false)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Random rand = new Random();
            if (writeToConcole) Console.WriteLine("Создание случайной матрицы...");
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++) 
                {
                    matrix[i,j] = rand.Next(minRandValue, maxRandValue);
                    if(writeToConcole) Console.Write(matrix[i, j] + "\t");
                }
                if (writeToConcole) Console.WriteLine();
            }
            if (writeToConcole) Console.WriteLine("Ваша матрица готова!\n");

            Console.ForegroundColor = consoleColor;
        }
        public static void RandomValForMatrix(ref float[,] matrix, float minRandValue = float.MinValue, float maxRandValue = float.MaxValue, bool writeToConcole = false)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Random rand = new Random();
            if (writeToConcole) Console.WriteLine("Создание случайной матрицы...");
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++) 
                {
                    matrix[i,j] = (float)rand.NextDouble() * (maxRandValue - minRandValue) + minRandValue;
                    if (writeToConcole) Console.Write(matrix[i, j] + "\t");
                }
                if (writeToConcole) Console.WriteLine();
            }
            if (writeToConcole) Console.WriteLine("Ваша матрица готова!\n");

            Console.ForegroundColor = consoleColor;
        }

        /// <summary>
        /// выводит матрицу на экран
        /// </summary>
        /// <param name="matrix"></param>
        public static void PrintMatrix(in int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// возвращает введенный с клавиатуры вектор
        /// </summary>
        /// <returns></returns>
        public static Vector InputVector()
        {
            Vector vector = new Vector();
            Console.Write("X = ");
            float x;
            InputValue(out x);
            Console.Write("Y = ");
            float y;
            InputValue(out y);
            vector.X = x;
            vector.Y = y;
            return vector;
        }
    }
}
