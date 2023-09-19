using System;

namespace Tasks
{
    static class ServiceMetods
    {
        public static void TapToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
