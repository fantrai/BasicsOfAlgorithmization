using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_5_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 5;

        public override int NumProgram => 2;

        public override int NumOption => 2;

        public override string Date => "27 октября 2023";

        public override string TextTask => "Даны целые положительные числа а1, а2,..., аn. Найти среди них те, которые являются квадратами некоторого числа m. ";

        public override void Program()
        {
            Console.WriteLine("Введите длинну последовательности, которую хотите заполнить");
            ServiceMetods.InputValue(out int size, 1);
            int[] sequence = new int[size];
            ServiceMetods.InputMassiv(ref sequence, 1); //заполняет массив вводимыми элементами >= 1

            Console.WriteLine("Введите m");
            ServiceMetods.InputValue(out int m);

            bool result = false;
            foreach (var item in sequence)
            {
                if (item * item == m)
                {
                    Console.WriteLine($"{item} подходит под условие!");
                    result = true;
                }
            }

            if (!result)
                Console.WriteLine("В последовательности нет нужных чисел!");
        }
    }
}
