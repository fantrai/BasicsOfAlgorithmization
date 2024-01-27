using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_7_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 7;

        public override int NumProgram => 1;

        public override string Date => "21 ноября 2021";

        public override string TextTask => "Необходимо создать матрицу A[N,M]  и посчитать сумму элементов отдельно в каждой строке и определить номер строки,  в которой эта сумма максимальна";

        public override void Program()
        {
            int[,] A = new int[10, 5];
            ServiceMetods.RandomValForMatrix(ref A, 0, 100, true);

            int maxSum = int.MinValue;
            int countStrMaxSum = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sumInStr = 0;

                for (int j = 0; j < A.GetLength(1); j++)
                    sumInStr += A[i, j];

                if (sumInStr > maxSum)
                {
                    maxSum = sumInStr;
                    countStrMaxSum = i;
                }

                Console.WriteLine($"Сумма строки {i}:  {sumInStr}");
            }

            Console.WriteLine($"\nНаибольшая сумма в строке {countStrMaxSum}:  {maxSum}");
        }
    }
}
