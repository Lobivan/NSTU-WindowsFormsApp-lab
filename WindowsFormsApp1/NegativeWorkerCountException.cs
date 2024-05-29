using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class NegativeWorkerCountException : Exception
    {
        public NegativeWorkerCountException()
        {
        }

        public NegativeWorkerCountException(string message)
            : base(message)
        {
        }

        public NegativeWorkerCountException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
