using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplemationPolymorphism
{
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is getting work");
        }
    }
}
