using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    internal class PW_23_1 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 23;

        public override int NumProgram => 1;

        public override string Date => "20 февраля 2024";

        public override string TextTask => "Создать класс, содержащий динамический массив и " +
            "количество элементов в нем. Добавить конструктор, который " +
            "выделяет память под заданное количество элементов, и деструктор. " +
            "Добавить методы, позволяющие заполнять массив случайными " +
            "числами, переставлять в данном массиве элементы в случайном " +
            "порядке, находить количество различных элементов в массиве, " +
            "выводить массив на экран.";

        public override void Program()
        {
            CrutchArray array = new CrutchArray(10);
            array.PrintArray();
            array.RandomArray();
            array.PrintArray();
            array.ShakeArray();
            array.PrintArray();
            Console.WriteLine(array.CountVariousElements());
        }

        class CrutchArray
        {
            public CrutchArray(int countElementsInArray)
            {
                array = new int[countElementsInArray];
            }

            CrutchArray()
            {
                Console.WriteLine("Это деструктор");
            }

            int[] array;

            public void RandomArray(int minVal = 0, int maxVal = 100)
            {
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(minVal, maxVal);
                }
            }

            public void ShakeArray()
            {
                List<int> list = array.ToList();
                int[] result = new int[list.Count];
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    int num = rand.Next(0, list.Count);
                    result[i] = list[num];
                    list.RemoveAt(num);
                }

                array = result;
            }

            public int CountVariousElements()
            {
                List<int> list = array.ToList();
                int result = 0;

                while (list.Count > 0)
                {
                    list.RemoveAll(x => x == list[0]);
                    result++;
                }

                return result;
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{ i }: { array[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
