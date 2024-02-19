using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_20_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 20;

        public override int NumProgram => 2;

        public override string Date => "5 февраля 2024";

        public override string TextTask => "Найти числа из интервала [M, N], имеющие наибольшее количество делителей";

        public override void Program()
        {
            Console.WriteLine("Введите начало интервала");
            int startVal = 0;
            ServiceMetods.InputValue(out startVal, 1);
            Console.WriteLine("Введите конец интервала");
            int endVal = 0;
            ServiceMetods.InputValue(out endVal, startVal);

            Console.WriteLine("Числа с наибольшим числом делитетелей:");
            foreach (var item in ValsWithMaxDivisionInDiapazon(startVal, endVal))
            {
                Console.Write(item + "; ");
            }
        }

        static int[] ValsWithMaxDivisionInDiapazon(int startVal, int endVal)
        {
            List<int> list = new List<int>();

            int maxCountDivision = 0;

            for (int i = startVal; i <= endVal; i++)
            {
                int countDivision = 0;

                for (int j = 1; j <= i; j++)
                    if (i % j == 0) countDivision++;

                if (countDivision > maxCountDivision)
                {
                    list.Clear();
                    maxCountDivision = countDivision;
                    list.Add(i);
                }
                else if (countDivision == maxCountDivision) list.Add(i);
            }

            return list.ToArray();
        }
    }
}
