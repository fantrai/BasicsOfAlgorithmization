using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_16_4 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 16;

        public override int NumProgram => 4;

        public override string Date => "27 января 2024";

        public override string TextTask => "Напишите функцию по вычислению среднего арифметического объемов шаров с радиусом r1, r2, r3.";

        public override void Program()
        {
            double[] capacities = new double[3];
            for (int i = 0; i < capacities.Length; i++) 
            {
                float val = 0;
                Console.Write($"Введите радиус { i + 1 }: ");
                ServiceMetods.InputValue(out val, 0);
                capacities[i] = CapacitySphere(val);
            }
            Console.WriteLine("Среднее арифметическое объемов равно: " + Average(capacities));
        }

        static double CapacitySphere(float radius)
        {
            return 4/3 * Math.PI * radius * radius;
        }

        static double Average(params double[] values)
        {
            double sum = 0;
            foreach (var value in values) 
                sum += value;
            return sum / values.Length;
        }
    }
}
