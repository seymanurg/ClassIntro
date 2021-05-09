using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planın hesaplandı...");
        }

        public void JustDo()
        {
            throw new NotImplementedException();
        }
    }
}
