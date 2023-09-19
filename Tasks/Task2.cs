using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Task2 : AbstractProgram
    {
        public override string NameTask { get => "Решение линейного уравнения"; }
        public override string Date { get => "18 сентября 2023"; }
        public override string TextTask => "Программа должна решать выражение (X+Y)/(Y+1) - (XY -12)/(34+X), где X и Y - вводимое с клавиатуры число, и выводить результат на экран";

        public override void StartProgram()
        {
            base.StartProgram();

            Console.WriteLine("Введите первое используемое в формуле число");
            float val1 = InputValue();
            Console.WriteLine("Введите второе используемое в формуле число");
            float val2 = InputValue();

            double result = (val1+val2)/(val2+1) - (val1*val2 - 12)/(34+val1);

            Console.WriteLine("Результат вычисления: " + result);

            ServiceMetods.TapToContinue();
        }

        /// <summary>
        /// считывает ввод от пользователя с учетом ошибок
        /// </summary>
        /// <returns></returns>
        float InputValue ()
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
