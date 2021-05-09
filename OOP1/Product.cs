using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Properties
    class Product     //Entity 
    {
        public int Id { get; set; }  //snippet -> double tab
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
