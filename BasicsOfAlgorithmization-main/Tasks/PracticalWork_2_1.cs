using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_2_1 : AbstractProgram
    {
        public override string NameTask => "Практическая работа 2. Вариант 1 (программа 1)";

        public override string Date => "2 октября 2023";

        public override string TextTask => "Вычислить значение функции в зависсимости от значения X:" +
            "\n\tесли X >= 3, то -X^2 +3X + 9" +
            "\n\tесли X < 3, то 1 / (X^3 + 6)";

        public override void StartProgram()
        {
            base.StartProgram();

            Console.WriteLine("Введите число X");
            float inputX = InputValue();
            float result = 0;

            if (inputX < 3) 
                result = 1f / ((float)Math.Pow(inputX, 3) + 6);
            else 
                result = -(inputX * inputX) + 3 * inputX + 9;

            Console.WriteLine("Результат вычисления: " + result);

            ServiceMetods.TapToContinue();
        }

        /// <summary>
        /// считывает ввод от пользователя с учетом ошибок
        /// </summary>
        /// <returns></returns>
        float InputValue()
        {
            bool parse = false;
            float inputValue;
            do
            {
                parse = float.TryParse(Console.ReadLine(), out inputValue);
                if (!parse)
                {
                    Console.WriteLine("Введено некорректное значение! Используйте снова!");
                }
            } while (!parse);
            return inputValue;
        }
    }
}
