using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Bouquet
    {
        public Bouquet(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        private List<Flower> Flowers { get; set; } = new List<Flower>();

        private int Price { get; set; }

       

        public void AddFlowers(List<Flower> flowers)
        {
            Flowers = flowers;
            foreach (var f in Flowers)
            {
                Price += f.Price;  
                
                
            }
        }
        public void RemoveFlower(int index)
        {
            if (Flowers.Count - 1 >= index)
            {
                InfoPriceBouquetRemoveFlower(Flowers[index]);
                Flowers.Remove(Flowers[index]);
                Console.WriteLine();
                InfoBouquet();
            }
            else
            {
                Console.WriteLine("Вы указали индекс вышедший из пределы ");
            }
        }

        private void InfoPriceBouquetRemoveFlower(Flower flower)
        {
            Console.WriteLine("Цена букета: " + Price);
            Console.WriteLine("После удаление цветка: " + flower.Name);
            
            Price -= flower.PriceLichnosti();
            Console.WriteLine("Цена букета будет равана: " + Price);
            if (Price < 0)
            {
                Console.WriteLine("Цена букета отрицательна :(");
            }
            else
            {
                if (Price == 0)
                {
                    Console.WriteLine("Цена букета равна нулю :|");
                }
                else
                {
                    Console.WriteLine("Цена букета положительна :)");
                }
            }
        }

        public void InfoBouquet()
        {
            Console.WriteLine(Name + " состоит:");
            foreach (var f in Flowers)
            {
                Console.WriteLine("\t{" + Flowers.IndexOf(f) + "} " + f.Name);
            }
            Console.WriteLine("Цена букета " + Price);
        }
    }
}
