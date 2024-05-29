using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class NoProductException : Exception
    {
        public NoProductException()
        {
        }

        public NoProductException(string message)
            : base(message)
        {
        }

        public NoProductException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
