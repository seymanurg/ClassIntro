using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();
            pro1.Name = "Elma";
            pro1.Cost = 15;
            pro1.Explanation = "Amasya Elması";

            Product pro2 = new Product();
            pro2.Name = "Karpuz";
            pro2.Cost = 80;
            pro2.Explanation = "Diyarbakır Karpuzu";

            Product pro3 = new Product();
            pro3.Name = "Kayısı";
            pro3.Cost = 4;
            pro3.Explanation = "Malatya Kayısısı";


            Product[] products = new Product[] { pro1, pro2, pro3 };

            //Type safe --- tip güvenliği

            foreach (Product pro in products)
            {
                Console.WriteLine("Ürünün adı: " + pro.Name);
                Console.WriteLine("Ürünün fiyatı: " + pro.Cost);
                Console.WriteLine("Ürünün açıklaması: " + pro.Explanation);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("---------------Metodlar---------------");

            //instance - örnek
            //encapsulation

            CartManager cartManager = new CartManager();
            cartManager.Add(pro1);
            cartManager.Add(pro2);
            cartManager.Add(pro3);

            cartManager.Add2("Armut", "Yeşil Armut", 12, 15);
            cartManager.Add2("Vişne", "Ekşi Vişne", 16, 44);
            cartManager.Add2("Üzüm", "Çekirdeksiz Üzüm", 8, 22);

        }
    }
}



//do not repeat yourself   -  DRY  - Clean Code   -   Best Practice
