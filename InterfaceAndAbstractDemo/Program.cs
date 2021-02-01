using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kahve Dükkanları için müşteri yönetimi yapan bir sistem yazılması isteniyor,
             * Starbucks ve Nero Firması için çalışıyoruz.
             * İki firmada müşterilierini veri tabanınana kaydetmek istiyor.
             * Starbucks müşterileri kaydederken, mutlaka Mernis doğrulaması istiyor.
             * Nero müşterileri kaydederken böyle bir istek yoktur.
             * Starbucks müşteriler için kahve alımında yıldız kazandırmak istiyor.
             */
            // https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?op=TCKimlikNoDogrula

            //BaseCustomerManager baseCustomerManager = new BaseCustomerManager();
            // Abstract Sınıflar newlenemez!
            BaseCustomerManager neroCustomerManager = new NeroCustomerManager();
            neroCustomerManager.SaveToDatabase(new Customer() { 
                CustomerId = 1, FirstName = "İrem", LastName = "Çalışkan",
                DateOfBirth = new DateTime(1997,1,5), NationalityId = 12345678912
            });

            BaseCustomerManager starbucksCustomerManager = new StarbucksCutomerManager(new MernisServiceAdapter());
            starbucksCustomerManager.SaveToDatabase(new Customer()
            {
                CustomerId = 1,
                FirstName = "İrem",
                LastName = "Çalışkan",
                DateOfBirth = new DateTime(1997, 1, 5),
                NationalityId = 12345678912 // Doğru verince ekledi
            });

            Console.ReadLine();

        }
    }
}
