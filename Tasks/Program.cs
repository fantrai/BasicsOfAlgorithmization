using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static List<InterfaceTask> programs;

        static void Main()
        {
            Hello();
            ProgramList();
            StartMainMenu();
        }

        /// <summary>
        /// здесь записываются все созданные программы в лист, чтобы иметь возможность в дальнейшем их запускать
        /// </summary>
        /// <returns></returns>
        static void ProgramList()
        {
            programs = new List<InterfaceTask>
            {
                new Task1(),
                new Task2()
            };
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
                    break;

                case ConsoleKey.DownArrow:
                    if (posCursor < programs.Count - 1) posCursor++;
                    break;
            }

            UpdateMainMenu(posCursor);
        }
    }
}
