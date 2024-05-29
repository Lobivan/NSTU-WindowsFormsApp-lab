using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Product(string name, int iD)
        {
            Name = name;
            ID = iD;
        }
        public override string ToString()
        {
            return Name + " " + ID;
        }
    }
}
