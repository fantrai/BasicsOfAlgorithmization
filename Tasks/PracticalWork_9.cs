using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_9 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 9;

        public override int NumProgram => 1;

        public override string Date => "1 декабря 2023";

        public override int NumOption => 4;

        public override string TextTask => "Напишите программу, которая принимает с клавиатуры число N, " +
            "создает матрицу размера N на N, у которой на главной и побочной диагоналях расположены случайные числа," +
            " а остальные элементы равны нулю. Затем выведите матрицу на экран.";

        public override void Program()
        {
            Console.WriteLine("Введите размер матрицы");
            int sizeMatrix = 0;
            ServiceMetods.InputValue(out sizeMatrix, 1);

            int[,] matrix = new int[sizeMatrix, sizeMatrix];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = random.Next(1, 100);
                matrix[i, matrix.GetLength(1) - 1 - i] = random.Next(1, 100);
            }

            ServiceMetods.PrintMatrix(matrix);
        }
    }
}
