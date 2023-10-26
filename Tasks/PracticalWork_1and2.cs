using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_1_1 : AbstractPracticalWork
    {
        public override string Date => "20 сентября 2023";

        public override string TextTask => "Программа должна решать выражение X - (X^3)/3 + (X^5)/5, где X - вводимое с клавиатуры число, и выводить результат на экран. В программе не должны использоваться циклы или ветвления";

        public override int NumPracticalWork => 1;

        public override int NumProgram => 1;

        public override void Program()
        {
            Console.WriteLine("Введите используемое в формуле число");
            float inputValue = float.Parse(Console.ReadLine());
            double result = inputValue - Math.Pow(inputValue, 5) / 3 + Math.Pow(inputValue, 5) / 5;
            Console.WriteLine("Результат вычисления: " + result);
        }
    }
}
