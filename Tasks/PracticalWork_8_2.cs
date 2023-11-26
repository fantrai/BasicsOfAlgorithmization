using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_8_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 8;

        public override int NumProgram => 2;

        public override string Date => "27 ноября 2023";

        public override string TextTask => "Напишите программу, которая сможет поменять местами выбранные пользователем столбцы.";

        public override void Program()
        {
            int[,] arr = new int[8, 10];
            ServiceMetods.RandomValForMatrix(ref arr, -100, 100, false);
            int cursorCol1 = 0;
            int cursorCol2 = 0;
            ConsoleColor defoaltColor = Console.ForegroundColor;
            bool columnSelected = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Используйте стрелки влево и вправо для выбора столбца, который следует заменить. Нажмите Enter для выбора");
                Console.ForegroundColor = defoaltColor;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (cursorCol1 == j) Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arr[i, j] + "\t");
                        Console.ForegroundColor = defoaltColor;
                    }
                    Console.WriteLine();
                }

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.Enter:
                        columnSelected = true;
                        break;
                    case ConsoleKey.RightArrow:
                        if (cursorCol1 < arr.GetLength(1) - 1)
                            cursorCol1++;
                        else
                            cursorCol1 = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (cursorCol1 > 0)
                            cursorCol1--;
                        else
                            cursorCol1 = arr.GetLength(1) - 1;
                        break;
                }
            } while (!columnSelected);
            columnSelected = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Используйте стрелки влево и вправо для выбора столбца, которыv следует заменить столбец," +
                    " выбранный ранее. Нажмите Enter для выбора");
                Console.ForegroundColor = defoaltColor;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (cursorCol1 == j) Console.ForegroundColor = ConsoleColor.Cyan;
                        if (cursorCol2 == j) Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arr[i, j] + "\t");
                        Console.ForegroundColor = defoaltColor;
                    }
                    Console.WriteLine();
                }

                ConsoleKey input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.Enter:
                        columnSelected = true;
                        break;
                    case ConsoleKey.RightArrow:
                        if (cursorCol2 < arr.GetLength(1) - 1)
                            cursorCol2++;
                        else
                            cursorCol2 = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (cursorCol2 > 0)
                            cursorCol2--;
                        else
                            cursorCol2 = arr.GetLength(1) - 1;
                        break;
                }
            } while (!columnSelected);

            int[] column1 = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
                column1[i] = arr[i, cursorCol1];

            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i, cursorCol1] = arr[i, cursorCol2];

            for (int i = 0;i < arr.GetLength(0); i++)
                arr[i, cursorCol2] = column1[i];

            Console.WriteLine("\nРезультат:\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (cursorCol1 == j || cursorCol2 == j) Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(arr[i, j] + "\t");
                    Console.ForegroundColor = defoaltColor;
                }
                Console.WriteLine();
            }
        }
    }
}
