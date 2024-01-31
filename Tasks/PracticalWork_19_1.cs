using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_19_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 19;

        public override int NumProgram => 1;

        public override string Date => "1 февраля 2024";

        public override string TextTask => "Используя рекурсивную функцию, " +
            "вычислить наибольший общий делитель двух натуральных чисел.";

        public override void Program()
        {
            int val1 = 0, val2 = 0;
            Console.WriteLine("Введите числа, для которых требуется найти наибольший общий делитель");
            ServiceMetods.InputValue(out val1);
            ServiceMetods.InputValue(out val2);
            Console.WriteLine("Наибольший общий делитель: " + MaxCommonDivision(val1, val2));
        }

        static int MaxCommonDivision(int val1, int val2)
        {
            int division = 0;

            if (val1 < val2) division = val1; else division = val2;

            return CommonDivisionS(val1, val2, division);
        }

        static int CommonDivisionS(int val1, int val2, int division)
        {
            if (val1 % division == 0 && val2 % division == 0) 
            {
                return division;
            }
            division--;
            return CommonDivisionS(val1, val2, division);
        }
    }
}
