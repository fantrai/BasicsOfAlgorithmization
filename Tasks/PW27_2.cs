using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW27_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 27;

        public override int NumProgram => 2;

        public override string Date => "30 марта 2024";

        public override string TextTask => "Удалить часть символьной строки, заключенной в скобки (вместе со скобками).";

        public override int NumOption => 14;

        public override void Program()
        {
            Console.WriteLine("Введите строку, из которой следует убрать скобки: ");
            Console.WriteLine(PW27_4(Console.ReadLine()));
        }

        static string PW27_4(string str)
        {
            string resultStr = str;
            do
            {
                int startIndex = resultStr.IndexOf('(');
                if (startIndex == -1)
                {
                    return resultStr;
                }
                int endIndex = resultStr.IndexOf(')', startIndex);
                if (endIndex == -1)
                {
                    return resultStr;
                }
                resultStr = resultStr.Remove(startIndex, endIndex - startIndex + 1);
            } while (true);
        }
    }
}
