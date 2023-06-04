using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplemationPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker manager = new Manager();
            IWorker worker = new Worker();
            IWorker robot = new Robot();
            List<IWorker> workers = new List<IWorker>() {manager, worker, robot };
            List<IWorker> eaters = new List<IWorker>() {manager, worker };
            List<IWorker> getSalary = new List<IWorker>() { manager, worker };

            foreach (var workerss in workers)
            {
                workerss.Work();
            }
            
        }
    }
}
