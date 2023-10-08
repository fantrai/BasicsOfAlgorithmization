using System;

namespace Tasks
{
    abstract class AbstractProgram : InterfaceTask
    {
        public abstract string NameTask { get; }
        public abstract string Date { get; }
        public abstract string TextTask { get; }

        virtual public void StartProgram()
        {
            PreviewProgram();
            Program();
            ServiceMetods.TapToContinue();
        }
        abstract public void Program();

        void PreviewProgram() 
        {
            Console.WriteLine($"Задание от {Date}\n\nТекст задания:\n{TextTask}");
            ServiceMetods.TapToContinue();
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}
