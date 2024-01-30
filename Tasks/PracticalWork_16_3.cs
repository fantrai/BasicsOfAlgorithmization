using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Tasks
{
    internal class PracticalWork_16_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 16;

        public override int NumProgram => 3;

        public override string Date => "27 января 2024";

        public override string TextTask => "Создать проект с функцией для вычисления Евклидова расстояния между двумя точками на плоскости.";

        public override void Program()
        {
            Console.WriteLine("Введите координаты точек:");
            Console.WriteLine("A: ");
            Vector pointA = ServiceMetods.InputVector();
            Console.WriteLine("B: ");
            Vector pointB = ServiceMetods.InputVector();

            Console.WriteLine("Расстояние между точками:" + Distance(pointA, pointB));
        }

        static double Distance(in Vector pointA, in Vector pointB) 
        {
            return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
        }
    }
}
