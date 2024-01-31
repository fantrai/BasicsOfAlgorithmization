using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_19_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 19;

        public override int NumProgram => 2;

        public override string Date => "1 февраля 2024";

        public override string TextTask => "Используя рекурсивную функцию, " +
            "найти число, которое образуется при записи цифр заданного натурального числа в обратном порядке. Например: для заданного числа 1234 – это число 4321.";

        public override void Program()
        {
            Console.WriteLine("Введите число, которое требуется развернуть");
            int val = 0;
            ServiceMetods.InputValue(out val);
            Console.WriteLine("Развернутое число: " + ReverseVal(val));
        }

        static int ReverseVal(int val)
        {
            int result = 0;

            int end = val % 10;

            for (int i = val; i >= 10; i /= 10) 
                end *= 10;

            result += end;

            if (val <= 0) return result;

            return end += ReverseVal(val / 10);
        }
    }
}
