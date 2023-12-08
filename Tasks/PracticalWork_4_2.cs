using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_4_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 4;

        public override int NumProgram => 2;

        public override string Date => "26 октября 2023";

        public override string TextTask => "Дана последовательность целых чисел а1 а2,..., аn. Выяснить, какое число встречается раньше — положительное или отрицательное.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну последовательности, которую хотите ввести");
            ServiceMetods.InputValue(out int size, 1);
            int[] sequence = new int[size];
            ServiceMetods.InputArray(ref sequence);

            bool result = false;

            foreach (var item in sequence) 
            {
                if (item == 0)
                    continue;
                else if (item > 0)
                {
                    Console.WriteLine("Раньше встречается положительное число");
                    result = true;
                    break;
                }
                else if (item < 0)
                {
                    Console.WriteLine("Раньше встречается отрицательное число");
                    result = true;
                    break;
                }
            }

            if (!result)
                Console.WriteLine("В последовательности нули!");
        }
    }
}
