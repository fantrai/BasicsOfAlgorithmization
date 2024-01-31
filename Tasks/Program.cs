using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static List<InterfaceTask> programs = new List<InterfaceTask>()
        {
                new Task1(),
                new Task2(),
                new PracticalWork_1_1(),
                new PracticalWork_1_2(),
                new Task3(),
                new PracticalWork_2_1(),
                new PracticalWork_2_2(),
                new PracticalWork_3_1(),
                new PracticalWork_3_2(),
                new PracticalWork_4_1(),
                new PracticalWork_4_2(),
                new PracticalWork_4_3(),
                new PracticalWork_4_4(),
                new PracticalWork_5_1(),
                new PracticalWork_5_2(),
                new PracticalWork_6(),
                new Task4(),
                new PracticalWork_7_1(),
                new PracticalWork_7_2(),
                new PracticalWork_8_1(),
                new PracticalWork_8_2(),
                new PracticalWork_9(),
                new PracticalWork_10(),
                new Task5(),
                new PracticalWork_16_1(),
                new PracticalWork_16_2(),
                new PracticalWork_16_3(),
                new PracticalWork_16_4(),
                new PracticalWork_17_1(),
                new PracticalWork_17_2(),
                new PracticalWork_17_3(),
                new PracticalWork_18_1(),
                new PracticalWork_18_2(),
                new PracticalWork_18_3(),
                new PracticalWork_19_1(),
                new PracticalWork_19_2(),
                new PracticalWork_19_3(),
        };

        static void Main()
        {
            Hello();
            StartMainMenu();
        }

        /// <summary>
        /// просто стартовое приветствие
        /// </summary>
        static void Hello()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Добро пожаловать!\n\nЗдесь собраны все работы студента\nгруппы 66-Д9-2ИНС\nНоскова Владимира");
            Console.ResetColor();
            ServiceMetods.TapToContinue();
        }

        /// <summary>
        /// интерфейс главного меню
        /// </summary>
        static void StartMainMenu()
        {
            int posCursor = 0;

            do
            {
                UpdateMainMenu(posCursor);
                InputInMainMenu(ref posCursor);
            } while (true);
        }

        /// <summary>
        /// обновляет текст главного меню
        /// </summary>
        /// <param name="posCursor"></param>
        static void UpdateMainMenu(int posCursor)
        {
            string cursor = "--> ";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Выберите интересующую вас работу из списка ниже.");
            Console.WriteLine("Используйте стрелочки вверх и вниз для передвижения курсора. Нажмите Enter чтобы посмотреть работу.");
            Console.ResetColor();

            for (int i = 0; i < programs.Count; i++)
            {
                if (i == posCursor)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(cursor);
                }

                Console.WriteLine($"{i+1}) {programs[i].Date}: {programs[i].NameTask}");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// управление в рамках главного меню
        /// </summary>
        /// <param name="posCursor"></param>
        static void InputInMainMenu(ref int posCursor)
        {
            ConsoleKey downKey = Console.ReadKey().Key;

            switch (downKey)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    programs[posCursor].StartProgram();
                    break;

                case ConsoleKey.UpArrow:
                    if (posCursor > 0)
                        posCursor--;
                    else
                        posCursor = programs.Count - 1;
                    break;

                case ConsoleKey.DownArrow:
                    if (posCursor < programs.Count - 1) 
                        posCursor++;
                    else
                        posCursor = 0;
                    break;
            }

            UpdateMainMenu(posCursor);
        }
    }
}
