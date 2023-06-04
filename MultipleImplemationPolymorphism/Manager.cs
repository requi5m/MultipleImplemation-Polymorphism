using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplemationPolymorphism
{
    class Manager : IWorker, IGetSalary, IEat
    {
        public void GetSalary()
        {
            Console.WriteLine("Manager getting salary");
        }

        public void IEat()
        {
            Console.WriteLine("Manager getting eat");
        }

        public void Work()
        {
            Console.WriteLine("Manager getting work");
        }
    }
}
