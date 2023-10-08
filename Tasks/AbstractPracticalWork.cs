using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    abstract class AbstractPracticalWork : AbstractProgram
    {
        public abstract int NumPracticalWork { get; }

        public int NumOption = 1;

        public abstract int NumProgram { get; }

        public override string NameTask => $"Практическая работа {NumPracticalWork}. Вариант {NumOption} (программа {NumProgram})";
    }
}
