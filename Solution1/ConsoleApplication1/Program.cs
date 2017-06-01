using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose r1 = new Rose("Роза", 50, 10);
            Grass r2 = new Grass("Трава", 60, 15);
            Tulp r3 = new Tulp("Тульпан", 30, 5);
            Flower r4 = new Grass("Не правильная трава", 70, 60);
            
            List<Flower> list = new List<Flower> {r1,r2,r3,r4};

            Bouquet b = new Bouquet("Веник Нимбус 2000");
            b.AddFlowers(list);
            b.InfoBouquet();

            Console.WriteLine();

            b.RemoveFlower(3);

            Console.ReadKey();
        }
    }
}
