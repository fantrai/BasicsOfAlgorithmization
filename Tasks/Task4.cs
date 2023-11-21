using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tasks
{
    internal class Task4 : AbstractProgram
    {
        public override string NameTask => "домащнее задание по двумерным массивам";

        public override string Date => "20 ноября 2023";

        public override string TextTask => "Дана матрица B[m,n]. Нйти в каждой строке наибольший и наименьший элемент. вывести индексы этих элементов на экран";
         
        public override void Program()
        {
            int[,] B =
            {
                {10, 15, 2, 5, 7, 87, 899,43,57, 10}, 
                {34, 56, 84, 24, 6,987, 4, 6, 9, 90 },
                {234, 6, 9, 4, 6, 8, 345, 74, 07, 23 },
                {35, 756, 32, 56, 89, 64, 3, 7, 0, 1 },
                {435, 6, 7, 43, 2, 5, 8, 0, 4, 2 }
            };
            for (int i = 0; i < B.GetLongLength(0); i++)
            {
                Vector indexMin = new Vector(0,0);
                Vector indexMax = new Vector(0,0);
                int minVal = int.MaxValue;
                int maxVal = int.MinValue;

                for (int j = 0; j < B.GetLongLength(1); j++) 
                {
                    if (B[i,j] < minVal)
                    {
                        minVal = B[i, j];
                        indexMin = new Vector(i, j);
                    }
                    if (B[i,j] > maxVal)
                    {
                        maxVal = B[i, j];
                        indexMax = new Vector(i, j);
                    }
                }

                Console.WriteLine($"Строка {i+1}: максимальный элемент {B[(int)indexMax.X, (int)indexMax.Y]} с индексом {(int)indexMax.X}:{(int)indexMax.Y}");
                Console.WriteLine($"\t  минимальный элемент {B[(int)indexMin.X, (int)indexMin.Y]} с индексом {(int)indexMin.X}:{(int)indexMin.Y}\n");
            }
        }
    }
}
