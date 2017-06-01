using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Flower
    {

        public string Name { get; set; }
        public int Price { get; set; }

        public virtual int PriceLichnosti()
        {
            return 0;
        }
        public virtual void InfoFlower()
        {
            Console.WriteLine("Цветок " + Name);
            Console.WriteLine("Цена в букете " + Price);
        }
    }
}
