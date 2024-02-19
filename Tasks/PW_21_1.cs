using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_21_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 21;

        public override int NumProgram => 1;

        public override string Date => "7 февраля 2024";

        public override string TextTask => "Два простых числа называются близнецами, если они отличаются друг от друга на два." +
            "Например, 41 и 43. Напечатать все пары близнецов из интервала [n; 2n], где n – заданное натуральное число больше двух.";

        public override void Program()
        {
            Console.WriteLine("Введите начало интервала");
            int startInterval = 0;
            ServiceMetods.InputValue(out startInterval, 2);
            PrintTwinsVal(startInterval, startInterval * 2);
        }

        static void PrintTwinsVal(int startInterval, int endInterval)
        {
            List<int> easyVals = new List<int>();

            for (int i = startInterval; i <= endInterval; i++)
            {
                int divisions = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0) divisions++;
                }
                if(divisions == 2) easyVals.Add(i);
            }

            bool trueTwins = false;
            for(int i = 0; i <= easyVals.Count - 2; i++)
            {
                if (easyVals[i] + 2 == easyVals[i + 1]) 
                {
                    Console.WriteLine($"Пара: {easyVals[i]} и {easyVals[i + 1]}");
                    trueTwins = true;
                }
            }
            if (!trueTwins) Console.WriteLine("Нет чисел-близнецов!");
        }
    }
}
