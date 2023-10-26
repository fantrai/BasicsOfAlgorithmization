using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_4_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 4;

        public override int NumProgram => 1;

        public override string Date => "26 октября 2023";

        public override string TextTask => "Дана последовательность действительных чисел а1, а2 ..., аn. Выяснить, будет ли она возрастающей.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну последовательности, которую хотите ввести");
            ServiceMetods.InputValue(out int size, 2);
            float[] sequence = new float[size];
            ServiceMetods.InputMassiv(ref sequence); //заполняет массив вводимыми элементами

            bool result = true;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    result = false;
                    break;
                }
            }

            if (result)
                Console.WriteLine("Последовательность возрастающая");
            else 
                Console.WriteLine("Последовательность не возрастает");
        }
    }
}
