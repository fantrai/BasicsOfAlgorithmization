using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_19_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 19;

        public override int NumProgram => 3;

        public override string Date => "1 февраля 2024";

        public override string TextTask => "Используя рекурсивную функцию, " +
            "вычислить сумму 1!+2!+3!+...+n! при n <=15.";

        public override void Program()
        {
            Console.WriteLine("Введите количество складываемых факториалов: ");
            int count = 0;
            ServiceMetods.InputValue(out count, 0, 16);
            Console.WriteLine("Сумма равна: " + SumFact(count));
        }

        static int SumFact(int countSum)
        {
            if (countSum != 0)
            {
                int sum = 1;
                for (int i = 1; i <= countSum; i++)
                {
                    sum *= i;
                }

                sum += SumFact(countSum - 1);
                return sum;
            }

            return 0;
        }
    }
}
