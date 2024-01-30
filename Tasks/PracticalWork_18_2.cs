using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_18_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 18;

        public override int NumProgram => 2;

        public override string Date => "27 января 2024";

        public override string TextTask => "В массиве А[N] найти второе по значению число (т.е вывести на печать число, которое меньше максимального элемента массива, но больше всех других элементов).";

        public override void Program()
        {
            Console.WriteLine("На сколько элементов сгенерировать массив: ");
            int size = 0;
            ServiceMetods.InputValue(out size, 2);
            int[] array = new int[size];
            ServiceMetods.RandomValForArray(ref array, 0, 100, true);
            Console.WriteLine("Второе по размеру число: " + SecondMaxEl(array));
        }

        static int SecondMaxEl(int[] array)
        {
            int maxVal = array[0];
            int result = maxVal;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
                else if (array[i] > result && result < maxVal)
                    result = array[i];
            }

            if (result == maxVal) 
            {
                Console.WriteLine("Нет второго по величине элемента!");
                return maxVal;
            }
            return result;
        }
    }
}
