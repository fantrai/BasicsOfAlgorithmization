using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PW_24 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 23;

        public override int NumProgram => 2;

        public override string Date => "20 февраля 2024";

        public override string TextTask => "Создать класс с указанными двумя полями " +
            "(Количество часов работы, Тариф оплаты за час работы) и тремя методами:" +
            "\r\n● функция присваивания значений;" +
            "\r\n● функция вывода значений на экран;" +
            "\r\n● функция по вычислению общей стоимость работы." +
            "\nЗатем для класса необходимо создать класс-потомок с дополнительным" +
            "полем(Число – подоходный налог в процентах). Реализовать в классе-потомке " +
            "функцию обработки данных по вычислению стоимости работы с вычетом подоходного налога.";

        public override int NumOption => 14; 

        public override void Program()
        {
            float countHours = 0, costHour = 0, tax = 0;
            Console.WriteLine("Введите количество рабочих часов");
            ServiceMetods.InputValue(out countHours);
            Console.WriteLine("Введите стоимость рабочего часа");
            ServiceMetods.InputValue(out costHour);
            Console.WriteLine("Введите налог в процентах");
            ServiceMetods.InputValue(out tax);

            WorkFromPW24 work = new WorkFromPW24();
            work.SetVals(countHours, costHour, tax);
            work.Print();
        }
    }

    class WorkFromPW24 : WorkFromPW22
    {
        public WorkFromPW24() { }
        public WorkFromPW24(float countHours, float costHour, float incomeTaxPerProcient)
            : base (countHours, costHour) 
        {
            IncomeTaxPerProcient = incomeTaxPerProcient;
        }

        float incomeTaxPerProcient = 0;
        public float IncomeTaxPerProcient
        {
            get { return incomeTaxPerProcient; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    incomeTaxPerProcient = value;
                }
            }
        }

        public float CostWorkWithTax { get { return CostWork * (1 - (IncomeTaxPerProcient / 100)); } }

        public override void Print()
        {
            Console.WriteLine(
                $"Количество часов: {CountHoursWork}\n" +
                $"Стоимость часа: {CostHourWork}\n" +
                $"Налог: {IncomeTaxPerProcient}%\n" +
                $"Стоимость работы: {CostWork}\n" +
                $"Итоговая стоимость работы: {CostWorkWithTax}");
        }

        public void SetVals(float countHours, float costHour, float incomeTaxPerProcient)
        {
            CountHoursWork = countHours;
            CostHourWork = costHour;
            IncomeTaxPerProcient = incomeTaxPerProcient;
        }
    }
}
