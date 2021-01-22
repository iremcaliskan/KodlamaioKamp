using System;

namespace Homework_FourthDayPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor = Yapıcı Blok
            /* Constructor ile amacımız bir sınıfın ilk oluşma anını kontrol etmektir.
             * Bir sınıfı new'lediğimiz zaman çalışan bloktur.
             * Bir class ilk kez oluştuğu zaman bu blok bir kere çalışır, bir daha çalışmaz!
             * Class'ı ilk kez yapılandırdığımızda çalışan bloktur.
             * Constructorların default hali değiştirilerek parametresiz veya parametreli olarak kullanılabilir.
             * Constructorlar overload edilerek hem parametresiz hem de parametreli olarak kullanılabilirler.
             */

            Customer customer = new Customer(); // Class'ı new'ledik, yani instance - örneğini oluşturduk.
            Customer customer1 = new Customer() { Id = 1, FirstName = "İrem", LastName = "Çalışkan", City = "İstanbul" }; // Default constructor parametresiz.
            // customer1 ve customer2 parametreli kullanımlar değildir.
            // () koymak zorunlu değildir! () parametre gönderilmezse genelde kullanılmaz!

            Customer customer2 = new Customer { Id = 2, FirstName = "İrem", LastName = "Çalışkan", City = "İstanbul" }; // Default constructor parametresiz.

            Customer customer3 = new Customer(3, "Han", "Solo", "Eskişehir"); // Metot mantığı, parametre alır demek.

            Method(66, "irem", "caliskan", "istanbul"); //Bu parametreleri metoda yollamak gibidir.

            Console.WriteLine(customer3.FirstName); // Özelliklere parametre ataması yapılınca bu kısım yazdırır.
        }

        static void Method(int id, string firstName, string lastName, string city) 
        { 

        }
    }

    class Customer // Özellik barındıran class türü
    {
        // Default Constructor ctor halidir.
        public Customer() // Her iki halide kullanmak istiyorsak overload yaparız.
        {
            //Parametre gelmeyen new'lemelerde burası çalışır!
            Console.WriteLine("Customer Sınıfı'nın Yapıcı Bloğu Çalıştı - Parametresiz!");
        }

        public Customer(int id, string firstName, string lastName, string city) // ctor
        {
            Console.WriteLine("Customer Sınıfı'nın Yapıcı Bloğu Çalıştı! - Parametreli!");
            // Breakpoint konulup değerlere bakılınca parametreler geliyor.
            // Ancak biz göremiyoruz.
            Id = id; // Id özelliğine parametre ile gelen id'yi atadık.
            FirstName = firstName; // Özelliklere parametreleri atadık.
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
