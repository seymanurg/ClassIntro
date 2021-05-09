using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        //syntax
        public void Add(Product pro)
        {
            Console.WriteLine("Sepete eklendi: " + pro.Name);
        }

        public void Add2(string proName, string proExp, double cost, int stock)
        {
            Console.WriteLine("Sepete eklendi: " + proName);
        }
    }
}
