using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW27_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 27;

        public override int NumProgram => 3;

        public override string Date => "30 марта 2024";

        public override string TextTask => "Дана строка, содержащая текст. Найти длину самого короткого слова и самого длинного слова.";

        public override int NumOption => 14;

        public override void Program()
        {
            Console.WriteLine("Введите строку, в которой следует посчитать длинну слов ");
            PW27_6(Console.ReadLine());
        }

        static void PW27_6(string str)
        {
            string boof = str;
            int? minLength = null;
            int? maxLength = null;

            while (boof.Length > 0)
            {
                if (boof.First() == ' ')
                {
                    boof = boof.Trim();
                    continue;
                }

                int firstSpase = boof.IndexOf(' ');
                if (firstSpase == -1) firstSpase = boof.Length;

                if (maxLength == null || firstSpase > maxLength) maxLength = firstSpase;
                if (minLength == null || firstSpase < minLength && firstSpase != 0) minLength = firstSpase;

                boof = boof.Remove(0, firstSpase);
            }

            Console.WriteLine(maxLength == null ? "В строке отсутствуют слова!" :
                $"Самое длинное слово - {maxLength} символов\n" +
                $"Самое короткое - {minLength} символов");
        }
    }
}
