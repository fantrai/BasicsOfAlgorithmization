using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_3_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 3;

        public override int NumProgram => 1;

        public override string Date => "5 октября 2023";

        public override string TextTask => "Напишите программу, которая подсчитывает количество положительных чисел среди 10 введённых с клавиатуры чисел.";

        public override void Program()
        {
            float[] nums = new float[10];
            Console.WriteLine($"Вам потребуется ввести {nums.Length} числел:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                ServiceMetods.InputValue(out nums[i]); //метод получает значение с клавиатуры с учетом всех проверок (расположен в соседнем скрипте)
            }

            int count = 0;

            for (int i = 0;i < nums.Length;i++) 
            {
                if (nums[i] > 0)
                    count++;
            }

            Console.WriteLine($"Введено {count} чисел больше нуля!");
        }
    }
}
