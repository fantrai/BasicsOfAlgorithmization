using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ariphmetics;

namespace Tasks
{
    internal class PW_31 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 31;

        public override int NumProgram => 1;

        public override string Date => "13 may 2024";

        public override string TextTask => "Реализовать в виде библиотеки набор подпрограмм для выполнения следующих операций:" +
            "\r\nсложения; " +
            "\r\nвычитания; " +
            "\r\nумножения;" +
            "\r\nделения;" +
            "\r\nвозведение в степень" +
            "\r\nВ основной части программы подключить необходимую библиотеку и воспользоваться данными подпрограммами";

        public override void Program()
        {
            int a = 20, b = 2;
            Console.WriteLine($"Сумма: {a} и {b} = {Operations.Sum(a, b)}");
            Console.WriteLine($"Разница: {a} и {b} = {Operations.Sub(a, b)}");
            Console.WriteLine($"Произведение: {a} и {b} = {Operations.Mult(a, b)}");
            Console.WriteLine($"Частное: {a} и {b} = {Operations.Div(a, b)}");
            Console.WriteLine($"{a} в степени {b} = {Operations.Exp(a, b)}");
        }
    }
}
