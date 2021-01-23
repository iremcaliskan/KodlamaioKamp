using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface***
            // Kredilerin instancelarını oluştuşma
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.CalculateCredit();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.CalculateCredit();

            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.CalculateCredit();

            //---------------------------------------
            // Interface'lerde interface'i implement eden sınıfların referans numarasını tutabilir.
            // Inheritance'taki gibi.

            // Ekran seçimleri olarak düşün.
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.CalculateCredit();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.CalculateCredit();

            ICreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.CalculateCredit();

            //Başvuru yapma:
            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            // Bir KrediManager istiyor. 
            //creditApplicationManager.Apply(housingCreditManager);
            //Hata verdi, logger eksik!
            // İki yol:
            //creditApplicationManager.Apply(housingCreditManager, new FileLoggerService())
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //creditApplicationManager.Apply(housingCreditManager, fileLoggerService);
            // Başvuru yap konut kredisine göre ve loglamayı dosyaya yapacak şekilde demektir.
            // Bu yazılımda sürdürülebilirliği sağlar!

            Console.WriteLine("------------------------------------------------");
            // ICreditManager bir interface, new'lenemez, verilemez!
            /* ICreditManager'ı implemente eden Ev,Taşıt,İhtiyaç KrediManagerlarından 
             * hangisi istenirse gönderebiliriz.
             * Gönderilen KrediManager'a göre de başvur metodunda bulunan hesaplama 
             * operasyonu KrediManager'ın kendi hesaplama operasyonuna denk gelir.
             */
            // housingCreditManager seçildiği için Ev Kredisi'nin Hesapla kuralı, metodu çalışır.

            // Some kind of Mülakat Question :))))

            /* Kredi çekmek isteyen Müşteri için uygun kredileri seçip,
             * Parametre olarak bir Liste yollanır. Listeyi alan metot
             * listeyi dönerek bilgilendirme yapar.
             */

            //Bilgilendirme için kredi seçimi/kredi listesi seçimi ve bilgilendirme yapılması:
            List<ICreditManager> credits = new List<ICreditManager>() 
            {personalFinanceCreditManager, vehicleCreditManager };
            creditApplicationManager.CreditPriorInfo(credits);

            // SOLID'in O'su: Open for extension, Close for modification.
            // Yeni bir özellik eklenirse mevcut kodlar bozulmaz!

            // Esnaf Kredisi ekleyelim.
            Console.WriteLine("---------------------------------");
            ICreditManager tradesmanCreditManager = new TradesmanCreditManager();
            creditApplicationManager.Apply(tradesmanCreditManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });
            //Liste yapıpta yollayabilirdik ama yukarıdaki gibide yollanabilir.

            Console.WriteLine("---------------------------------");
            // Yeni bir Loglama yöntemi eklenilmesi istensin.
            // Sms Loglaması ekleyelim.
            //creditApplicationManager.Apply(tradesmanCreditManager, new SmsLoggerService());
            ILoggerService smsLoggerService = new SmsLoggerService();
            //creditApplicationManager.Apply(tradesmanCreditManager, smsLoggerService);
            creditApplicationManager.Apply(tradesmanCreditManager, new List<ILoggerService> { new SmsLoggerService() });
            // Yapılanların hepsi polymorphism örneğidir.

            Console.WriteLine("---------------------------------");
            List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService() };
            creditApplicationManager.Apply(housingCreditManager, loggerServices);
        }
    }
}
