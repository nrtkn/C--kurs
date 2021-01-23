using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
