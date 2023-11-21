using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Tasks
{
    internal class PracticalWork_7_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 7;

        public override int NumProgram => 2;

        public override string Date => "21 ноября 2023";

        public override string TextTask => "Необходимо создать матрицу C[D,S] и найти произведение положительных элементов матрицы, стоящих после максимального элемента.";

        public override void Program()
        {
            int[,] C = new int[5, 3];
            ServiceMetods.RandomValForMatrix(ref C, -10, 10, true);
            
            ulong result = 1;
            Vector posMaxEl = new Vector();
            int valMaxEl = int.MinValue;

            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                    if (C[i,j] > valMaxEl)
                    {
                        valMaxEl = C[i,j];
                        posMaxEl = new Vector(i,j);
                    }

            for (int i = (int)posMaxEl.X ;i < C.GetLength(0); i++)
                for(int j = (int)posMaxEl.Y;j < C.GetLength(1); j++)
                    if (C[i,j] > 0)
                        result = result * (ulong)C[i,j];

            Console.WriteLine($"Произведение соответсвующих чисел: {result}");
        }
    }
}
