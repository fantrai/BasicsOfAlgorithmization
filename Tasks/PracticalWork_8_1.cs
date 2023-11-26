using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Tasks
{
    internal class PracticalWork_8_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 8;

        public override int NumProgram => 1;

        public override string Date => "27 ноября 2023";

        public override string TextTask => "Напишите программу, которая реализует поиск максимального и минимального числа в квадратной матрице, а затем поменяет с помощью сортировки эти значения местами. Вывести на экран итоговый вариант матрицы.";

        public override void Program()
        {
            int[,] sqrMatrix = new int[ 5, 5];
            ServiceMetods.RandomValForMatrix(ref sqrMatrix, -100, 100, true);
            Vector maxValPos = new Vector();
            Vector minValPos = new Vector();

            int maxEl = int.MinValue;
            int minEl = int.MaxValue;
            for (int i = 0; i < sqrMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sqrMatrix.GetLength(1); j++) 
                {
                    if (sqrMatrix[i, j] > maxEl)
                    {
                        maxEl = sqrMatrix[i, j];
                        maxValPos = new Vector(i, j);
                    }
                    if (sqrMatrix[i, j] < minEl)
                    {
                        minEl = sqrMatrix[i, j];
                        minValPos = new Vector(i, j);
                    }
                }
            }

            int boof = sqrMatrix[(int)maxValPos.X, (int)maxValPos.Y];
            sqrMatrix[(int)maxValPos.X, (int)maxValPos.Y] = sqrMatrix[(int)minValPos.X, (int)minValPos.Y];
            sqrMatrix[(int)minValPos.X, (int)minValPos.Y] = boof;
            Console.WriteLine("Элементы заменены: ");
            for (int i = 0; i < sqrMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sqrMatrix.GetLength(1); j++)
                {
                    Console.Write(sqrMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
