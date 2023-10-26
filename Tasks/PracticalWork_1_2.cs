using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_1_2 : AbstractPracticalWork
    {
        public override string Date => "20 сентября 2023";

        public override string TextTask => "Составить логическое выражение, печатающую значение true, если указанное высказывание является истинным, и false — в противном случае." +
            "\nX— отрицательное целое число, делящееся на К нацело. В программе не должны использоваться циклы или ветвления";

        public override int NumPracticalWork => 1;

        public override int NumProgram => 2;

        public override void Program()
        {
            Console.WriteLine("Введите число X");
            float inputX = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K");
            float inputK = float.Parse(Console.ReadLine());

            bool result = inputX < 0 && inputX % inputK == 0;

            Console.WriteLine("Результат вычисления: " + result);
        }
    }
}
