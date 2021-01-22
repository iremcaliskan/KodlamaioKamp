using System;

namespace Homework_FourthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değer tipleri: int, decimal, float, enum, boolean...
            int num1 = 10;
            int num2 = 20;

            num1 = num2; //num1'in değeri = num2'nin değeri
            num2 = 100;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            // Değer tipleri stackte tutulur. Bu tiplerde değer ile ilgilenilir.
            // num1=10, num2=20
            // num1 = num2 -> num1'in değeri eşittir num2'nin değerine, 20 oldu!
            // num2'nin değeri 100 atandı.

            //Referans Tipleri: array, class, abstrac class, interface...
            // Diziler new gerektirir!
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 6, 7, 8 };

            nums1 = nums2;

            nums2[0] = 100;
            Console.WriteLine(nums1[0]);
            // Stack ------new----- Heap
            // nums1 -------------- 1 2 3 -100.Adres
            // nums2 -------------- 6 7 8 -101.Adres
            // nums1=nums2 ---> nums1'in referans adresi nums2'nin referans adresine eşittir.
            // nums1\_           
            // nums2--------------- 6 7 8 -101.
            // nums2[0] = 100 nums2'nin 0.indisine 100 atanıyor, 100 7 8 değerleri oluyor.
            // Böylelikle aynı adresi tutan elemanlara dönüşüyorlar!

            Person person1 = new Person();
            person1.FirstName = "İrem";

            Person person2 = new Person();
            person2 = person1; // Adress eşitlemesi

            person1.FirstName = "Ceren"; // Adreslerindeki değer değişir!
            person2.FirstName = "Ecem";

            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            customer1.FirstName = "Engin";
            customer1.CreditCardNumber = "658912";

            Employee employee1 = new Employee();
            employee1.FirstName = "Deniz";
            //customer = employee;  // Hata verir tipleri farklı: biri Customer biri Employee.

            Person person3 = customer1; // Adressleri eşitlendi!
            person3.FirstName = "Leyla"; // Adresin son ataması her ikisi içinde geçerli olacaktır!
            
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(customer1.FirstName);

            Console.WriteLine(customer1.CreditCardNumber);
            // Console.WriteLine((Customer)person3.CreditCardNumber);

            // Person ve Customer tipleride farklı neden? 
            // Customer bir Person'dır. (: Person)
            // Miras aldığımız sınıf türüne mirası alan class'ı atayabiliriz!
            // Bu ifadenin teknik anlamı Base Class.

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(person2);
            personManager.Add(customer1);
            personManager.Add(person3);
            personManager.Add(employee1);
            // Person tipi yazılması ile Person olan her sınıf tutulabilir.
            // Arkaplanda, Person'a gönderilen tipin örneğin Employee'nin adresi yazılır!
        }
    }

    class Person // Base Class (ortak özelliklerin bulunduğu sınıf)
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //inheritance
    {
        //Id, FirstName ve LastName'den farklı olarak bulunanlar:
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person //inheritance
    {
        //Id, FirstName ve LastName'den farklı olarak bulunanlar:
        public int PersonelNumber { get; set; }
    }

    class PersonManager // Operasyon sınıfı
    {
        public void Add(Person person) // Person gönderirsek Person ve Person olan herkesi kullanabiliriz.
        {   // Person tipi yazılması ile Person olan her sınıf tutulabilir.
            // Arkaplanda, Person'a gönderilen tipin, örneğin Employee'nin adresi yazılır!
            Console.WriteLine(person.FirstName);
        }
    }
}
