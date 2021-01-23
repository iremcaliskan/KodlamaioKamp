using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Oriented Programming (Nesne Yönelimli Programlama)
            // Inheritance* - Interface - Abstract Class
            // Bug Free - Hatasız kodlama

            // Gerçek Müşteri
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.ClientNumber = "895476";
            individual1.Name = "İrem";
            individual1.Surname = "Çalışkan";
            individual1.TcNo = "12345678912";

            // Tüzel Müşteri
            Corporate corporate1 = new Corporate();
            corporate1.Id = 2;
            corporate1.ClientNumber = "856123";
            corporate1.CompanyName = "Kodlama.io";
            corporate1.taxId = "1234567890";

            // Gerçek Müşteri - Tüzel Müşteri : Bunlar farklı müşterilerdir.
            // ClientType = 1(gerçek) / 0(Tüzel) girişi de yanlıştır!
            // SOLID'in L'si

            Client client1 = new Individual();
            Client client2 = new Corporate();
            // Müşteri Gerçek ve Tüzel Müşteri'yi tutabilir.
            // Müşteri Class'ı hem Gerçek Müşterinin hemde Tüzel Müşterinin referansını tutabilir.
            // Müşteri Manager'a temel sınıfın tüm miras alanlarını gönderebiliriz.
            // Base Class tüm miras alanlarının referanslarını tutabilir.
            ClientManager clientManager = new ClientManager();
            clientManager.Add(individual1);
            clientManager.Add(corporate1);
            clientManager.Add(client1);
            clientManager.Add(client2);
            // Buradaki olay:
            /* Base sınıfın, yani temel sınıfın onu inherit eden 
             * sınıflarının referansını tutabilmesidir.
             */
        }
    }
}
