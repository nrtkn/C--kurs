using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
