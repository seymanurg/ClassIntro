using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Elbise";
            product1.ProductPrice = 85;

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Etek";
            product2.ProductPrice = 45.6;

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Pantolon";
            product3.ProductPrice = 62.3;

            Product product4 = new Product();
            product4.ProductId = 4;
            product4.ProductName = "Gömlek";
            product4.ProductPrice = 51.7;

            Product product5 = new Product();
            product5.ProductId = 5;
            product5.ProductName = "Kazak";
            product5.ProductPrice = 35;


            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            foreach (var pro in products)
            {
                Console.WriteLine(pro.ProductId + "     " + pro.ProductName + " : " + pro.ProductPrice);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Foreach bitti...");
            Console.WriteLine(" ");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId + "     " + products[i].ProductName + " : " + products[i].ProductPrice);
            }

            Console.WriteLine(" ");
            Console.WriteLine("For bitti...");
            Console.WriteLine(" ");

            int j = 0;

            while (j < products.Length)
            {
                Console.WriteLine(products[j].ProductId + "     " + products[j].ProductName + " : " + products[j].ProductPrice);
                j++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("While bitti...");
            Console.WriteLine(" ");

        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
