using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_17_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 17;

        public override int NumProgram => 2;

        public override string Date => "27 января 2024";

        public override string TextTask => "Найти (в радианах, в градусах) все углы треугольника со сторонами a, b, c.";

        public override void Program()
        {
            Triangle triangle = InputTriangle();
            Console.WriteLine($"Угол A = {triangle.AngleA} градусов или {triangle.RadAngleA} радиан");
            Console.WriteLine($"Угол B = {triangle.AngleB} градусов или {triangle.RadAngleB} радиан");
            Console.WriteLine($"Угол C = {triangle.AngleC} градусов или {triangle.RadAngleC} радиан");
        }

        static Triangle InputTriangle() 
        {
            float[] sides = new float[3];
            bool triangleIsCreated = false;

            do
            {
                for (int i = 0; i < sides.Length; i++)
                {
                    Console.Write("Введите сторону " + (i + 1) + ": ");
                    ServiceMetods.InputValue(out sides[i], 0);
                }

                Array.Sort(sides);

                if (sides[0] + sides[1] <= sides[2])
                    Console.WriteLine("Треугольник с такими сторонами не существует, попробуйте снова!");
                else triangleIsCreated = true;

            } while (!triangleIsCreated);

            return new Triangle(sides[0], sides[1], sides[2]);
        }
    }

    class Triangle
    {
        public Triangle(float sideA, float sideB, float sideC)
        {
            A = sideA; 
            B = sideB;
            C = sideC;

            RadAngleA = Math.Acos((B * B + C * C - A * A) / (2 * B * C));
            RadAngleB = Math.Acos((A * A + C * C - B * B) / (2 * A * C));
            RadAngleC = Math.Acos((A * A + B * B - C * C) / (2 * A * B));
            Console.WriteLine("aaa");
        }

        public float A { get; private set; }
        public float B { get; private set; }
        public float C { get; private set; }

        public double RadAngleA { get; private set; }
        public double RadAngleB { get; private set; }
        public double RadAngleC { get; private set; }

        public double AngleA { get { return RadAngleA * 57.3; }}
        public double AngleB { get { return RadAngleB * 57.3; }}
        public double AngleC { get { return RadAngleC * 57.3; }}
    }
}
