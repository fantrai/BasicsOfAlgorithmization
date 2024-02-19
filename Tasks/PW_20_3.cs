using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_20_3 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 20;

        public override int NumProgram => 3;

        public override string Date => "5 февраля 2024";

        public override string TextTask => "Имеется часть катушки с автобусными билетами. Номер билета шестизначный. " +
            "Определить количество счастливых билетов на катушке, если меньший номер билета – N, а больший – M." +
            "(Билет является счастливым, если сумма трех первых его цифр равна сумме трех последних цифр).";

        public override void Program()
        {
            Console.WriteLine("Введите начало интервала");
            int minVal = 0;
            ServiceMetods.InputValue(out minVal, 0);
            Console.WriteLine("Введите конец интервала");
            int maxVal = 0;
            ServiceMetods.InputValue(out maxVal, minVal, 999999);

            int[] luckyTickets = LuckyTickets(minVal, maxVal);

            Console.WriteLine("Количество счастливых билетов:" + luckyTickets.Length);
            foreach (var item in luckyTickets)
            {
                Console.Write(item.ToString("000000") + "; ");
            }
        }

        static int[] LuckyTickets(int minVal, int maxVal)
        {
            List<int> luckyTicks = new List<int>();

            for (int i = minVal; i <= maxVal && i < 1000000; i++)
            {
                int startSum = 0;
                int endSum = 0;

                startSum += i / 1000;
                endSum += i % 1000;

                if (startSum == endSum)
                    luckyTicks.Add(i);
            }

            return luckyTicks.ToArray();
        }
    }
}
