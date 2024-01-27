using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork16;

namespace Tasks
{
    internal class PracticalWork_16_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 16;

        public override int NumProgram => 1;

        public override string Date => "27 января 2024";

        public override string TextTask => "Напишите функцию min(a, b), вычисляющую минимум двух чисел. " +
            "Затем напишите функцию min4(a, b, c, d), вычисляющую минимум 4 чисел с помощью рекурсивной функции min. " +
            "Введите четыре целых числа и выведите их минимум.";

        public override void Program()
        {
            /* Технически, невозможно написать программу, где функция min(a, b) будет находить минимум двух чисел и будет рекурсивной, 
             т.к. функция min(a, b) не совершает никаких собственных вычислений, а следовательно никакие новые данные она не производит,
             следовательно более одной итерации не имеет никакого смысла! Кроме того, непонятно, какой магией эта мистическая
            рекурсивная функция min(a, b) должна считать минимум 4х чисел благодаря методу min4(a, b, c, d). Всвязи с этим, предлагаю 
            следующие варианты решения: 
            1) сделать один метод min(params val) и просто сделать перебор массива (ну или банальное array.min),
            2) сделать перегруженный метод min принимающий два или четыре параметра,
            3) сделать метод min(a, b) и метод min4(a, b, c, d), который будет просто трижды вызывать метод min(a, b), но это странно.
            Т.к. обратную связь получить сейчас я не могу, потому будет реализовано все 3 вариации.*/

            Console.WriteLine("Введите числа ");
            float val1 = 0;
            ServiceMetods.InputValue(out val1);
            float val2 = 0;
            ServiceMetods.InputValue(out val2);
            float val3 = 0;
            ServiceMetods.InputValue(out val3);
            float val4 = 0;
            ServiceMetods.InputValue(out val4);

            Console.WriteLine("Метод 1:");
            Console.WriteLine("Минимум первых двух чисел равен " + Metod1.Min(val1, val2));
            Console.WriteLine("Минимум четырех чисел равен " + Metod1.Min(val1, val2, val3, val4));

            Console.WriteLine("Метод 2:");
            Console.WriteLine("Минимум первых двух чисел равен " + Metod2.Min(val1, val2));
            Console.WriteLine("Минимум четырех чисел равен " + Metod2.Min(val1, val2, val3, val4));

            Console.WriteLine("Метод 3:");
            Console.WriteLine("Минимум первых двух чисел равен " + Metod3.Min(val1, val2));
            Console.WriteLine("Минимум четырех чисел равен " + Metod3.Min4(val1, val2, val3, val4));
        }
    }
}

namespace PracticalWork16
{
    static class Metod1
    {
        public static T Min<T>(params T[] vals)
        {
            return vals.Min();
        }
    }

    static class Metod2
    {
        public static float Min(float val1, float val2)
        {
            return Math.Min(val1, val2);
        }
        public static float Min(float val1, float val2, float val3, float val4)
        {
            float[] vals = { val1, val2, val3, val4 };
            return vals.Min();
        }
    }

    static class Metod3
    {
        public static float Min(float val1, float val2)
        {
            return Math.Min(val1, val2);
        }

        public static float Min4(float val1, float val2, float val3, float val4)
        {
            return Min(Min(val1, val2), Min(val3, val4));
        }
    }
}
