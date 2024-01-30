using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_18_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 18;

        public override int NumProgram => 1;

        public override string Date => "27 января 2024";

        public override string TextTask => "Вычислить площадь правильного шестиугольника со стороной A, используя метод для вычисления площади треугольника.";

        public override void Program()
        {
            Console.WriteLine("Введите длинну стороны: ");
            float sides = 0;
            ServiceMetods.InputValue(out sides, 0);
            Console.WriteLine("Прощадь шестиугольника = " + 6 * TriangleSquare(sides));
        }

        static double TriangleSquare(float side)
        {
            return (side * side * Math.Pow(side, -3))/4;
        }
    }
}
