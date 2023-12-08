using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_4_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 4;

        public override int NumProgram => 3;

        public override string Date => "26 октября 2023";

        public override string TextTask => "В массив A[N] занесены натуральные числа. Найти сумму тех элементов, которые кратны данному К.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну массива, который хотите заполнить");
            ServiceMetods.InputValue(out int size, 1);
            int[] sequence = new int[size];
            ServiceMetods.InputArray(ref sequence, 1); //заполняет массив вводимыми элементами >= 1

            Console.WriteLine("Введите К");
            ServiceMetods.InputValue(out int k);

            int resultValue = 0;
            foreach (var item in sequence)
            {
                if (item % k == 0)
                {
                    resultValue += item;
                }
            }

            Console.WriteLine("Сумма соответствующих элементов равна: " + resultValue);
        }
    }
}
