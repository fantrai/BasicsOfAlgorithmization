using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_10 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 10;

        public override int NumProgram => 1;

        public override string Date => "8 декабря 2023";

        public override string TextTask => "Сортировка выбором. Дана последовательность чисел а1 а2, ..., аn. Требуется переставить элементы так, чтобы они были расположены по убыванию." +
            " Для этого в массиве, начиная с первого, выбирается наибольший элемент и ставится на первое место, а первый — на место наибольшего. " +
            "Затем, начиная со второго, эта процедура повторяется. Написать алгоритм сортировки выбором.";

        public override void Program()
        {
            Console.Write("Введите размер сортируемого массива: ");
            ServiceMetods.InputValue(out int size, 1);
            int[] array = new int[size];

            ServiceMetods.RandomValForArray(ref array, -100, 100, true);

            for (int i = 0; i < array.Length; i++) 
            {
                int maxIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex]) maxIndex = j;
                }
                var boof = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = boof;
            }

            Console.WriteLine("Массив отсортирован: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
