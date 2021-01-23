using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager rCredit = new RequirementsCreditManager();
            ICreditManager vCredit = new VehicleCreditManager();
            ICreditManager fCredit = new FlatCreditManager();
            // Interfacelerde inherit edildiği classın referansını tutar.
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(fCredit, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() { rCredit, vCredit, fCredit} ;

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
