namespace Homework_FifthDayPart3
{
    class Program
    {
        static void Main(string[] args)
        {

            //MultiImplementationOfInterfaces();
            // Interfaceler inheritance(kalıtım, miras) örneği gibi çalışırlar.
            // Interfaceler bir implemantation'dır, inheritance değildir.
            // Inheritance'ta bir sınıf tek bir sınıftan miras alabilir.
            // Interfaceler newlenemezken, BaseClasslar newlenebilir.
            // Inheritance da multiple inheritance olmaz!
            // class Customer: Person, IEat, IPerson gibi bir ifade yazılabilir.
            // Inheritance önce yazılır, daha sonra implement edeceği interface yazılır.

            Person[] persons = new Person[]
            {
                new Student(),
                new Person(),
                new Student() {Id = 1, FirstName = "İrem", LastName = "Çalışkan", Department = "Software" },
                new Customer() {Id = 1, FirstName = "Ceren", LastName = "Yıldız",  CustomerNumber = "123456"}
            };

            // Student(), Student(...) şeklinde de olabiliyor.
            // Interface tek başına bir anlam ifade etmezken, 
            // Inherit edilen sınıf bir anlam ifade ediyor.

            foreach (var person in persons)
            {
                System.Console.WriteLine(person.FirstName); // Null olsada bazı isimler, boş döndürüyor.
            }
            System.Console.WriteLine(persons.Length); // 4 döner


            Customer customer = new Customer();
            customer.Id = 2;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.CustomerNumber = "123457";

            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Han";
            student.LastName = "Gümüş";
            student.Department = "Science";

            // Interface ile Inheritance Arasında Karar Vermek
            /* Interfaceler inheritance olmasada, Inheritance mantığı ile kullanılıyor. 
             * Inheritance : Abstract sınıflar
             * Eğer interface kullanılabiliyorsa, inheritance ihtiyacı yoksa interface kullan.
             */
        }

        private static void MultiImplementationOfInterfaces()
        {
            // Bir şirket : işçiler, yöneticiler, robotlar
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Employee(),
                new Robot()
            };

            // Interfacelerin metodları tüm kullanıcıların kullanacağı şekilde doğru planlanmalıdır,
            // İçi boş veya kullanılmayan metodu olmamalıdır.
            // SOLID : Yazılım geliştirme prensipleridir.
            // I: Interface Aggregation -- şuanki örneğimiz
            // S: Single Responsibility
            // O: Open-closed
            // L: Liskow Substitution
            // D: Dependency Inversion

            foreach (var worker in workers)
            {
                worker.Work(); // Tüm personellere çalış emri verilmiş olur!
            }

            IEat[] eats = new IEat[]  //IEat interface'inin Robot implement etmediği için, kullanılamaz.
            {
                new Manager(),
                new Employee()
                //new Robot()
            };

            foreach (var eat in eats)
            {
                eat.Eat(); // Robot dışındaki tüm personellere yeme emri verilir.
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CustomerNumber { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}
