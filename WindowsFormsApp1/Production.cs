using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    abstract class Production
    {
        public string Name { get; set; }
        private int workerCount;
        public int WorkerCount { 
            get 
            { 
                return workerCount;
            } 
            set
            {
                if (value < 0)
                {
                    throw new NegativeWorkerCountException("Amount of workers must be >= 0");
                }
                workerCount = value;
            }
        }

        public Production(string name, int workerCount) 
        { 
            Name = name;
            WorkerCount = workerCount;
        }
    }
}
