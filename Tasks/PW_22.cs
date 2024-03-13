using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_22 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 22;

        public override int NumProgram => 1;

        public override string Date => "19 февраля 2024";

        public override int NumOption => 14;

        public override string TextTask => "Задача 6. Создать класс с указанными двумя полями " +
            "(Количество часов работы, Тариф оплаты за час работы) и тремя методами:" +
            "\n1) функция присваивания значений;" +
            "\n2) функция вывода значений на экран;" +
            "\n3) функция по вычислению общей стоимость работы.";

        public override void Program()
        {
            float countHours = 0, costHour = 0;
            Console.WriteLine("Введите количество рабочих часов");
            ServiceMetods.InputValue(out countHours);
            Console.WriteLine("Введите стоимость рабочего часа");
            ServiceMetods.InputValue(out costHour);

            WorkFromPW22 work = new WorkFromPW22();
            work.SetVals(countHours, costHour);
            work.Print();
        }

    }

    public class WorkFromPW22
    {
        public WorkFromPW22() { }
        public WorkFromPW22(float countHours, float costHour)
        {
            CountHoursWork = countHoursWork;
            CostHourWork = costHourWork;
        }

        private float countHoursWork = 0;
        public float CountHoursWork
        {
            get { return countHoursWork; }
            set
            {
                if (value >= 0)
                    countHoursWork = value;
                else
                    countHoursWork = 0;
            }
        }

        private float costHourWork = 0;
        public float CostHourWork
        {
            get { return costHourWork; }
            set
            {
                if (value >= 0)
                    costHourWork = value;
                else
                    costHourWork = 0;
            }
        }

        public float CostWork
        {
            get { return countHoursWork * costHourWork; }
        }

        public virtual void Print()
        {
            Console.WriteLine(
                $"Количество часов: {CountHoursWork}\n" +
                $"Стоимость часа: {CostHourWork}\n" +
                $"Итоговая стоимость работы: {CostWork}");
        }

        public void SetVals(float countHours, float costHour)
        {
            CountHoursWork = countHours;
            CostHourWork = costHour;
        }
    }
}
