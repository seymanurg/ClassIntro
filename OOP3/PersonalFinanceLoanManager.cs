using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planın hesaplandı...");
        }

        public void JustDo()
        {
            throw new NotImplementedException();
        }
    }
}
