using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tasks
{
    internal class Task5 : AbstractProgram
    {
        public override string NameTask => "Работа с функциями";

        public override string Date => "19 января 2024";

        public override string TextTask => "Написать программу, вычисляющую выражение, выбранное пользователем";


        static List<string> equation = new List<string>()
            {
                "(1 + sin√(x + 1)) / cos(12y - 4)",
                "x - 10sin(x) + |x^4 - x^5|",
                "(cos^2(x) / sin(x)) - xyz + ((ax^2 + bx + c) / (dx^3 - f))",
            };

        public override void Program()
        {
            int cursorPos = 0;
            float? result = null;

            do
            {
                UpdateMenu(cursorPos);
                ConsoleKey inpitKey = Console.ReadKey().Key;

                switch (inpitKey)
                {
                    case ConsoleKey.UpArrow:
                        if (cursorPos > 0) cursorPos--;
                        else cursorPos = equation.Count - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursorPos < equation.Count - 1) cursorPos++;
                        else cursorPos = 0;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine("Выбранное уравнение: \n" + equation[cursorPos] + "\n");
                        switch (cursorPos)
                        {
                            case 0: result = Equation1(); break;
                            case 1: result = Equation2(); break;
                            case 2: result = Equation3(); break;
                        }
                        break;
                }
            } while (result == null);

            Console.WriteLine($"\nРезультат выражения: {result}");
        }

        static void UpdateMenu(int cursorPos)
        {
            Console.Clear();
            string cursor = "--> ";
            ConsoleColor standartColor = Console.ForegroundColor;

            Console.WriteLine("Выберите пример из списка:");
            for (int i = 0; i < equation.Count; i++)
            {
                if (cursorPos == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(cursor);
                }
                Console.WriteLine(equation[i]);
                Console.ForegroundColor = standartColor;
            }
        }

        static float Equation1()
        {
            float x = 0, y = 0;
            Console.Write("x = ");
            ServiceMetods.InputValue(out x);
            Console.Write("y = ");
            ServiceMetods.InputValue(out y);
            float result = (float)((1 + Math.Sin(Math.Sqrt(x + 1))) / Math.Cos(12*y - 4));
            return result;
        }

        static float Equation2()
        {
            float x = 0;
            Console.Write("x = ");
            ServiceMetods.InputValue(out x);
            float result = (float)(x - 10*Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5)));
            return result;
        }

        static float Equation3()
        {
            float x = 0, y = 0, z = 0, a = 0, b = 0, c = 0, d = 0, f = 0;
            Console.Write("x = ");
            ServiceMetods.InputValue(out x);
            Console.Write("y = ");
            ServiceMetods.InputValue(out y);
            Console.Write("z = ");
            ServiceMetods.InputValue(out z);
            Console.Write("a = ");
            ServiceMetods.InputValue(out a);
            Console.Write("b = ");
            ServiceMetods.InputValue(out b);
            Console.Write("s = ");
            ServiceMetods.InputValue(out c);
            Console.Write("d = ");
            ServiceMetods.InputValue(out d);
            Console.Write("f = ");
            ServiceMetods.InputValue(out f);

            float result = (float)(Math.Pow(Math.Cos(x), 2) / Math.Sin(x)
                - (x * y * z)
                + ((a * Math.Pow(x, 2) + b * x + c)) / (d * Math.Pow(x, 3) - f));
            return result;
        }
    }
}
