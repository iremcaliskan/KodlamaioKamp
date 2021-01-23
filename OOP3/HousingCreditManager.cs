using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    { // Implement interface
        // Interface şablonu zorunlu olarak uygulandıktan sonra,
        // Interface'i kullanan her sınıf kendi kurallarını yazabilir.
        public void CalculateCredit()
        {
            // ............
            Console.WriteLine("Konut Kredisi Ödeme Planı Hazırlandı ve Bilgilendirme Yapıldı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
