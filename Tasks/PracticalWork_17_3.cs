using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_17_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 17;

        public override int NumProgram => 3;

        public override string Date => "27 января 2024";

        public override string TextTask => "Найдите сумму 1+ 1/2 + 1/3 + 1/4 + ... + 1/n. Выполненные вычисления прописать в отдельно созданном методе.";

        public override void Program()
        {
            Console.WriteLine("Введите максимальный делитель: ");
            int maxDivider = 1;
            ServiceMetods.InputValue(out maxDivider, 1);
            Console.WriteLine("Результат: " + ManyDivision(maxDivider));
        }

        static float ManyDivision(in int countDivision)
        {
            float result = 0;

            for (int i = 1; i <= countDivision; i++)
                result += 1f / i;

            return result;
        }
    }
}
