using System;

namespace Tasks
{
    internal class Task1 : AbstractProgram
    {
        public override string NameTask { get => "Решение линейного уравнения"; }
        public override string Date { get => "18 сентября 2023"; }
        public override string TextTask => "Программа должна решать выражение X - (X^3)/3 + (X^5)/5, где X - вводимое с клавиатуры число, и выводить результат на экран";

        public override void Program()
        {
            Console.WriteLine("Введите используемое в формуле число");
            float inputValue;
            bool parse = false;

            do
            {
                parse = float.TryParse(Console.ReadLine(), out inputValue);
                if (!parse)
                {
                    Console.WriteLine("Введено некорректное значение! Используйте снова!");
                }
            } while (!parse);

            double result = inputValue - Math.Pow(inputValue, 5)/3 + Math.Pow(inputValue, 5)/5;

            Console.WriteLine("Результат вычисления: " + result);
        }
    }
}
