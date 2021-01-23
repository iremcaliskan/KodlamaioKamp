using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanCreditManager : ICreditManager
    {
        public void CalculateCredit()
        { // Sadece yeni bir class ekleyerek yeni bir kredi oluşturuldu!
            // Kodlar içinde boğulmadık.
            Console.WriteLine("Esnaf Kredisi Hesaplandı ve Bilgilendirme Yapıldı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
