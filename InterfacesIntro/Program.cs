using System;

namespace InterfacesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPerson person = new IPerson(); //Interfaceler newlenemez.
            Customer customer1 = new Customer();
            customer1.Id = 0;
            customer1.Name = "İrem";
            customer1.Surname = "Çalışkan";
            customer1.CustomerNumber = "123456";

            Student student1 = new Student();
            student1.Id = 0;
            student1.Name = "Ceren";
            student1.Surname = "Yıldız";
            student1.Department = "Engineering";

            PersonManager personManager = new PersonManager();
            // Add'in içerisine IPerson olan her kişiyi yollamak için Add'e IPerson tipli parametre yazmamız gerekir.
            // Customer veya Student yazarsak IPerson sınıfını implemente ediyor olsa dahi parametre geçilemez.
            personManager.Add(customer1);
            personManager.Add(student1);
            personManager.Add(new Customer() { Id = 1, Name = "Engin", Surname = "Demiroğ", CustomerNumber = "123457" });
            personManager.Add(new Student() { Id = 1, Name = "Kerem", Surname = "Osmanoğlu", Department = "Computer Science" });
            // interface'ler inheritance gibi kullanılır ama inharitance değillerdir.

            // Bir interface newlenemez. Tek başına bir anlamı yoktur, şablon tutar.
            //IPerson person = new IPerson(); //Cannot create an instance of the abstract type or interface.

            IPerson person = new Customer(); // Person olan her sınıfın instance'ı oluşturulabilir.
                                             // Soyut nesneleri interface ve abstracları newlemek mümkündeğildir.
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
