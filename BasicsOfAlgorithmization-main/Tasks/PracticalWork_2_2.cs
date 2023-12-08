using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_2_2 : AbstractProgram
    {
        public override string NameTask => "Практическая работа 2. Вариант 1 (программа 2)";

        public override string Date => "2 октября 2023";

        public override string TextTask => "Создайте программу, которая может определить существование\r\nтреугольника и его тип.";

        public override void StartProgram()
        {
            base.StartProgram();

            float[] sides = new float[3];

            //заполняем массив сторонами
            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write("Введите сторону " + (i+1) + ": ");
                sides[i] = InputValue();
                if (sides[i] <= 0)
                {
                    Console.WriteLine("Сторона должна быть больше 0!");
                    i--;
                    continue;
                }
            }

            //сортируем элементы в порядке возрастания
            for (int i = 0; i < sides.Length-1; i++)
            {
                for (int j = 0; j < sides.Length-1; j++)
                {
                    if (sides[j] > sides[j+1])
                    {
                        float boof = sides[j + 1];
                        sides[j+1] = sides[j];
                        sides[j] = boof;
                    }
                }
            }

            if (sides[0] + sides[1] <= sides[2])
            {
                Console.WriteLine("Такого треугольника не существует!");
            }
            else if (sides[0] == sides[1] && sides[1] == sides[2])
            {
                Console.WriteLine("Это же равносторонний треугольник!");
            }
            else if (sides[0] == sides[1] || sides[1] == sides[2])
            {
                Console.WriteLine("Это же равнобедренный треугольник!");
            }
            else
            {
                Console.WriteLine("Это же разносторонний треугольник!");
            }

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
