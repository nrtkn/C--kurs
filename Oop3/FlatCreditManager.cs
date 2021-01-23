using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class FlatCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
