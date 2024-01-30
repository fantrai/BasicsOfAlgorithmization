using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_17_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 17;

        public override int NumProgram => 1;

        public override string Date => "27 января 2024";

        public override string TextTask => "Даны два неотрицательных числа a и b. Найти их среднее геометрическое, воспользовавшись методом.";

        public override void Program()
        {
            Console.Write("Введите A: ");
            float valA = 0;
            ServiceMetods.InputValue(out valA, 0);
            Console.Write("Введите B: ");
            float valB = 0;
            ServiceMetods.InputValue(out valB, 0);

            Console.WriteLine("Среднее геометрическое равно: " + AverageGeometric(valA, valB));
        }

        static double AverageGeometric(params float[] vals)
        {
            float mult = 1;
            foreach (var val in vals)
                mult *= val;
            return Math.Sqrt(mult);
        }
    }
}
