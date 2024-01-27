using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_16_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 16;

        public override int NumProgram => 2;

        public override string Date => "27 января 2024";

        public override string TextTask => "Напишите функцию, которая по введенным числам будет выводить значение их кубов.";

        public override void Program()
        {
            Console.WriteLine("Введите число ");
            float val = 0;
            ServiceMetods.InputValue(out val);
            Console.WriteLine("Квадрат числа равен " + Square(val));
        }

        public static float Square(float val)
        {
            return val * val;
        }
    }
}
