using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Rose: Flower
    {
        public Rose()
        {

        }
        public Rose(string name, int price, int pricebuket)
        {
            Name = name;
            Price = price;
            base.Price = pricebuket;
        }
        public new int Price { get; set; }
        public override int PriceLichnosti()
        {
            return Price;
        }

        public override void InfoFlower()
        {
            base.InfoFlower();
            Console.WriteLine("Цена отдельно от букета " + Price);
        }
    }
}
