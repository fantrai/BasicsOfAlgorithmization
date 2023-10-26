using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_4_4 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 4;

        public override int NumProgram => 4;

        public override string Date => "26 октября 2023";

        public override string TextTask => "Дан массив действительных чисел, размерность которого N. Подсчитать, сколько в нем отрицательных, положительных и нулевых элементов.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну массива, который хотите заполнить");
            ServiceMetods.InputValue(out int size, 1);
            float[] sequence = new float[size];
            ServiceMetods.InputMassiv(ref sequence);

            int positiveCount = 0;
            int negativeCount = 0;
            int nullCount = 0;

            foreach (var item in sequence)
            {
                if (item == 0)
                    nullCount++;
                else if (item > 0)
                    positiveCount++;
                else negativeCount++;
            }

            Console.WriteLine($"Количество положительных чисел: {positiveCount}\n" +
                $"Количество отрицательных чисел: {negativeCount}\n" +
                $"Количество нулей: {nullCount}");
        }
    }
}
