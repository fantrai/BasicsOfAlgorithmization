using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_27_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 27;

        public override int NumProgram => 1;

        public override string Date => "30 марта 2024";

        public override string TextTask => "Дана строка. Подсчитать в ней количество вхождений букв r, k, t.";

        public override int NumOption => 14;

        public override void Program()
        {
            Console.WriteLine(PW27_1("00000rr|||k_____   _tttt"));
        }

        static int PW27_1(string str)
        {
            int countR = str.Count(i => i == 'r' || i == 'k' || i == 't');
            return countR;
        }
    }
}
