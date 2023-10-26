using System;

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
                    Console.WriteLine("Выход за пределы допустимого значения! Попробуйте снова!");
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
                    Console.WriteLine("Выход за пределы допустимого значения! Попробуйте снова!");
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
        public static void InputMassiv(ref int[] returnMassiv, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            for (int i = 0; i < returnMassiv.Length; i++)
            {
                Console.Write($"Введите элемент {i +1}: ");
                InputValue(out returnMassiv[i]);
            }
        }
        public static void InputMassiv(ref float[] returnMassiv, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            for (int i = 0; i < returnMassiv.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                InputValue(out returnMassiv[i]);
            }
        }
    }
}
