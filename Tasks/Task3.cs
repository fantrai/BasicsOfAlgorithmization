using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Task3 : AbstractProgram
    {
        public override string NameTask => "Домашнее задание по конструкциям ветвления";

        public override string Date => "23 сентября 2023";

        public override string TextTask => "Пусть элементами круга являются 1 - радиус, 2 - диаметр, 3 - длинна окружности. По заданному номеру элемента выполнить запрос соответствующего значения и вычислить площадь круга";

        public override void StartProgram()
        {
            base.StartProgram();

            Console.WriteLine("Выберите элемент круга, по которому будет рассчитываться площадь\n1 - радиус\n2 - диаметр\n3 - длинна окружности");
            int numberCircleElement;
            InputValue(out numberCircleElement, 1, 3);

            Console.WriteLine("Введите значение");
            float enterCicrcleElement;
            InputValue(out enterCicrcleElement);

            float result = 0;

            switch (numberCircleElement) 
            {
                case 1:
                    result = (float)Math.PI * enterCicrcleElement * enterCicrcleElement;
                    break;
                
                case 2:
                    result = (1 / 4.0f) * (float)Math.PI * enterCicrcleElement * enterCicrcleElement;
                    break;

                case 3:
                    result = (enterCicrcleElement * enterCicrcleElement) / (4 * (float)Math.PI);
                    break;
            }

            Console.WriteLine("Площадь круга составляет  " + result);

            ServiceMetods.TapToContinue();
        }

        /// <summary>
        /// считывает ввод от пользователя с учетом ошибок
        /// </summary>
        /// <returns></returns>
        void InputValue(out float returnValue, float minValue = float.MinValue, float maxValue = float.MaxValue)
        {
            bool parse = false;
            do
            {
                parse = float.TryParse(Console.ReadLine(), out returnValue);
                if (!parse)
                    Console.WriteLine("Введено некорректное значение! Попробуйте снова!");
                if (!(returnValue >= minValue && returnValue <= maxValue))
                {
                    parse = false;
                    Console.WriteLine("Выход за пределы допустимого значения! Попробуйте снова!");
                }
            } while (!parse);
        }
        void InputValue(out int returnValue, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            bool parse = false;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out returnValue);
                if (!parse)
                    Console.WriteLine("Введено некорректное значение! Попробуйте снова!");
                if (!(returnValue >= minValue && returnValue <= maxValue))
                {
                    parse = false;
                    Console.WriteLine("Выход за пределы допустимого значения! Попробуйте снова!");
                }
            } while (!parse);
        }
    }
}
