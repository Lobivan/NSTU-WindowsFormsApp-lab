using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Workshop : Production, IPrinter
    {
        public string Boss { get; set; }
        public List<Product> Products;

        public Product this[int i]
        {
            get
            {
                if (i >= Products.Count)
                {
                    throw new NoProductException("Index out of bounds");
                }
                return Products[i];
            }
            set
            {
                if (i >= Products.Count)
                {
                    throw new NoProductException("Index out of bounds");
                }
                Products[i] = value;
            }
        }

        public Workshop(string name, int workerCount = 0, string boss = "N/A") : base (name, workerCount)
        {
            Boss = boss;
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return Name + " / Количество рабочих - " + WorkerCount + " / Начальник - " + Boss + " / Количество продуктов - " + Products.Count;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void FullPrint()
        {
            Console.WriteLine("Workshop Name - " + Name);
            Console.WriteLine("Boss Name - " + Boss);
            Console.WriteLine("Number of workers - " + WorkerCount);
            Console.WriteLine("Amount of products - " + Products.Count);
            Console.WriteLine("Products:");
            foreach (Product product in Products)
            {
                Console.WriteLine("  " + product.ToString());
            }
        }
    }
}
