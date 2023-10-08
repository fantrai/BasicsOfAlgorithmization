using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class PracticalWork_3_2 : AbstractPracticalWork
    {
        public override int NumPracticalWork => 3;

        public override int NumProgram => 2;

        public override string Date => "5 октября 2023";

        public override string TextTask => "У царя было семь сыновей. В сундуке лежали изумруды. Пришел первый сын и взял половину того, что было. " +
            "Пришел второй сын и взял половину того, что осталось и т.д. Каждый из сыновей приходил и забирал половину того, что осталось. " +
            "Наконец, пришел последний седьмой сын и увидел почти пустой сундук -  с двумя изумрудами. Сколько изумрудов лежало в сундуке первоначально?";

        public override void Program()
        {
            int gemsCount = 2;

            for (int i = 0; i < 7; i++) 
                gemsCount *= 2;

            Console.WriteLine($"Изначально в сундуке лежало {gemsCount} изумрудов!");
        }
    }
}
