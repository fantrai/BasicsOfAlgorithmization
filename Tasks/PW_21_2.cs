using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_21_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 21;

        public override int NumProgram => 2;

        public override string Date => "7 февраля 2024";

        public override string TextTask => "Перевести заданное натуральное число в p-ичную систему счисления(2<= p <=9).";

        public override void Program()
        {
            Console.WriteLine("Введите преобразуемое число");
            int value = 0;
            ServiceMetods.InputValue(out value);
            Console.WriteLine("Систему счисления");
            int counterSistem = 0;
            ServiceMetods.InputValue(out counterSistem, 2, 9);

            Console.WriteLine($"Число {value} " +
                $"в {counterSistem} системе счисления: " +
                $"{ ConvertValue(value, counterSistem) }");
        }

        static string ConvertValue(int value, int countesSistem)
        {
            string result = string.Empty;

            do
            {
                result += value % countesSistem;
                value /= countesSistem;
            } while (value > 0);

            char[] chars = result.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
