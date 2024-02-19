using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_20_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 20;

        public override int NumProgram => 1;

        public override string Date => "2 февраля 2024";

        public override string TextTask => "Найти все натуральные n-значные числа, цифры в которых образуют строго возрастающую последовательность.Например: 1,2,3,4,5,6,7,8,9.";

        public override void Program()
        {
            Console.WriteLine("Введите количество знаков в числе");
            int count = 0;
            ServiceMetods.InputValue(out count, 2, 9);
            GrawVal(count);
        }

        static void GrawVal(int countNum, int number = 0, int thisCount = 1)
        {
            if (thisCount <= countNum)
            {
                for (int i = (number % 10) + 1; i < 10 - (countNum - thisCount); i++)
                {
                    int newNum = number * 10 + i;
                    GrawVal(countNum, newNum, thisCount + 1);
                    if (thisCount == countNum) Console.Write(newNum + "; ");
                }
            }
        }
    }
}
