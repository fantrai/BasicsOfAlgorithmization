using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_5_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 5;

        public override int NumProgram => 1;

        public override int NumOption => 2;

        public override string Date => "27 октября 2023";

        public override string TextTask => "Дана последовательность целых положительных чисел. Найти произведение только тех из них, которые больше заданного числа М. Если таких чисел нет, то выдать сообщение об этом.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну последовательности, которую хотите заполнить");
            ServiceMetods.InputValue(out int size, 1);
            int[] sequence = new int[size];
            ServiceMetods.InputMassiv(ref sequence, 1); //заполняет массив вводимыми элементами >= 1

            Console.WriteLine("Введите М");
            ServiceMetods.InputValue(out int m);

            int resultValue = 1;
            foreach (var item in sequence)
            {
                if (item > m)
                {
                    resultValue *= item;
                }
            }

            Console.WriteLine("Произведение соответствующих элементов равна: " + resultValue);
        }
    }
}
