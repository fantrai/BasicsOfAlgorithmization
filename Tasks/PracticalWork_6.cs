using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_6 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 6;

        public override int NumProgram => 1;

        public override string Date => "1 ноября 2023";

        public override string TextTask => "Задан целочисленный массив размерности N. Есть ли среди элементов массива простые числа? Если да, то вывести номера этих элементов.\r\n";

        public override void Program()
        {
            Console.WriteLine("Заполните массив");
            int[] arr = new int[5];
            ServiceMetods.InputArray(ref arr, 0);
            for (int i = 0; i < arr.Length; i++) 
            {
                bool easyVal = true;

                for (int j = 2; j < arr[i]; j++) 
                {
                    if (arr[i] % j == 0)
                    {
                        easyVal = false;
                        break;
                    }
                }

                if (easyVal)
                    Console.WriteLine($"Элемент {i} - простое число");
            }
        }
    }
}
