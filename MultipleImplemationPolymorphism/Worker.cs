using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplemationPolymorphism
{
    class Worker : IWorker, IEat, IGetSalary
    {
        public void GetSalary()
        {
            Console.WriteLine("Worker getting salary");
        }

        public void IEat()
        {
            Console.WriteLine("Worker getting eat");
        }

        public void Work()
        {
            Console.WriteLine("Worker getting work");
        }
    }
}
