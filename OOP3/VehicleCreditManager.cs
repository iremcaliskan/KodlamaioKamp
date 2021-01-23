using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    { 
        public void CalculateCredit()
        {
            //..........
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hazırlandı ve Bilgilendirme Yapıldı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
