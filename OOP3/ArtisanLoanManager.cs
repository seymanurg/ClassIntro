using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planın hesaplandı...");
        }

        public void JustDo()
        {
            throw new NotImplementedException();
        }
    }
}
