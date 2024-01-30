using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_18_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 18;

        public override int NumProgram => 3;

        public override string Date => "27 января 2024";

        public override string TextTask => "Дан массив А[N], где N – четное число. Сформировать массив В[М], элементами которого являются средние арифметические соседних пар рядом стоящих в массиве А чисел. " +
            "Например, если массив А состоит из элементов 1,3,5,-2,0,4,0,3, элементами массива В будут числа 2, 1.5, 2, 1.5.";

        public override void Program()
        {
            int size = 2;

            Console.WriteLine("Введите размер массива (требуется четное число)");
            do
            {
                ServiceMetods.InputValue(out size, 2);
                if (size % 2 != 0) Console.WriteLine("Требуется четное число!");
            } while (size % 2 != 0);

            int[] array = new int[size];
            ServiceMetods.RandomValForArray(ref array, 0, 100, true);

            int[] newArray = FormigNewArray(array);

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < newArray.Length; i++)
                Console.Write(newArray[i] + "  ");
        }

        static int[] FormigNewArray(in int[] array)
        {
            int[] newArray = new int[array.Length / 2];

            for (int i = 0, j = 0; i < array.Length; i += 2, j++)
                newArray[j] = (array[i] + array[i + 1]) / 2;

            return newArray;
        }
    }
}
