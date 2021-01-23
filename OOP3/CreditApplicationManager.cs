using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditApplicationManager
    { // Başvuru
        // Dependency Injection
        // Method injection yapılıyor.
        // Apply metodunun kullanacağı KrediManager'ını yani hangi kredi türü olacağını,
        // ve Hangi LoggerService olacağını enjekte ediyoruz.
        // Apply metodunda hangi kredi ve loglayıcı olduğuna dair bilgi yok,
        // Sadece soyut halleri var, somut hallerini enjekte ediyoruz.

        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerService) //BaşvuruYap, ne başvurusu yapayım?
        { // Parametre tipi olarak ICreditManager kullanılırsa, her krediye erişebiliriz.

            //Başvuran bilgilerinideğerlendir
            //....... 
            creditManager.CalculateCredit(); // Hangi kredi gelirse ona göre hesaplanacak!
            //Bu metodu loglamak istiyorsak:
            //loggerService.Log(); // Hangi LoggerService gönderilmişse, onu logla.
            // Genelde çoklu loglamalar yapılır!
            // List yollamamız gerekir çoklu loglamalar için.

            foreach (var logger in loggerService)
            {
                logger.Log(); //Herbir logger'ı dön, çalıştır!
            }

            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.CalculateCredit();
            // Tüm başvurular Konut Kredisi üzerinden yapılır, ona bağımlı hale gelir!
            
            // Parametreyi ICreditManager tipiyle ayarladığımız için kredi bağımsız hale gelir.
        }

        public void CreditPriorInfo(List<ICreditManager> credits) //Kredi Ön Bilgilendirmesi Yap
        { // Bilgilendirme için birden fazla kredi seçilebilir.
            // Listenin türü ICreditManager
            // Listedeki elemanları dolaşmak için
            foreach (var credi in credits)
            {
                credi.CalculateCredit(); // Listenin her elemanı için Kredi Hesapla
            }

            for (int i = 0; i < credits.Count; i++) // For ile yazılması
            {
                credits[i].CalculateCredit();
            }
        }
    }
}
