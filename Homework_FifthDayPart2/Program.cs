using System;

namespace Homework_FifthDayPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacePart2();
            /* Polymorphisim(çok biçimlilik), bir nesneyi farklı amaçlarla implement edip,
             * o implementationların belirli bir kısmına veya tamamına ulaşmaktır.
             */
            // Polymorphisim:
            ICustomerDAL[] customerDALs = new ICustomerDAL[] 
            { 
                new SqlServerCustomerDAL(),
                new OracleCustomerDAL(),
                new MySqlCustomerDAL()
            };

            foreach (var customerDAL in customerDALs)
            {
                customerDAL.Add(); // Veritabanları gezilip, herbiri için Add() çağırılır.
            }
            // Yeni bir veritabanı desteği eklenmek istenirse, kodlara dokunulmadan yeni kısımlar eklenir.
        }
    }

    interface IPerson
    { //I: interface
        // Kullanım amacı:
        // Temel operasyon, nesne oluşturup bütün nesneleri ondan implemente etmektir.
        // IPerson soyut nesnedir, Customer ve Student somut nesnelerdir.
        // Interfaceler yazılırken tamamıyla imza kullanılır!
        // Interface'e ait her özellik veya metot kullanan sınıflar tarafından implement edilmek zorundadır.
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }

    class Customer : IPerson
    { //Her iki implementte olur ama ilki daha temiz.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CustomerNumber { get; set; } // Özel özelliği
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; } // Özel özelliği
    }

    class PersonManager
    {
        public void Add(IPerson person) // IPerson verilirse, IPerson'ı implemente eden her sınıf parametre olabilir.
        {
            Console.WriteLine("Veritabanına {0} {1} eklendi.", person.Name, person.Surname);
        }
    }
}
