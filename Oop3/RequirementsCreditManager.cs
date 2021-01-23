using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class RequirementsCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
