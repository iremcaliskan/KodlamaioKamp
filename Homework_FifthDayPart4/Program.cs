using System;

namespace Homework_FifthDayPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface = Şablon = Arayüz
            // Interface, mülakatlarda çok sorulur.
            // Doğru öğrenimi, yazılım hayatı için çok önemlidir.

            /*
            IPersonManager personManager = new IPersonManager();
            personManager.Add();
            */
            // Bu kullanımda sadece imza, içi boş olan şablon vardır.
            // Bu yüzden Interface'ler newlenemez.

            CustomerManager customerManagerI = new CustomerManager();
            customerManagerI.Add();

            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            // Interfaceler referans tiptir.
            // newlendiği an bellekte Heap kısmında EmployeeManager'ın referans değeri oluşur.
            // Interfaceler onu implemente eden Class'ın referansını tutabilirler.

            IPersonManager workerManager = new WorkerManager();
            //workerManager.Update();

            // Neden insanlar sorun yaşıyor? - Gerçek hayatla doğru ilişkilendirme yapılamadığı için.
            
            ProjectManager projectManager = new ProjectManager(); // Tüm projeyi tek bir noktada yönetmek
            //projectManager.Add(employeeManager);
            //projectManager.Add(workerManager);
            // Birden fazla nesne ile çalışıldığı için tek merkezde yönetime ihtiyaç duyulur.
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new WorkerManager()); // Yazılımda değişim

            // Yazılımın temel prensibi: yeni özellik eklenirken mevcut kodlara dokunulmaz!!!
            projectManager.Add(new InternManager());
            // Yazılımdaki en büyük problem: Sürekli değişiklik talebi gelir.
            // Yazılımı canlı bir yapı olarak düşünmek gerekir.

        }
    }

    class Person
    {
        //Base Class, Parent Class
    }

    class Customer:Person
    { // Customer inherits or extends Person
        // Customer, Person'un erişilebilir üyelerini kullanabilir.
    }


    class PersonManager
    {
        // Implemented Operation : içi doldurulmuş, tamamlanmış operasyondur.
        public void Add()
        {
            Console.WriteLine("Inheritance ile Eklendi!");
        }
    }

    // inherits - class
    class CustomerManager:PersonManager
    {
        // Kalıtım aldığı sınıfın operasyonlarını kullanabilir.
    }

    // Interfacelerde de üyeler olur ama içleri boş olur, sadece imzaları olur.
    interface IPersonManager // Default internaldır.
    {
        // Unimplemented operation : içi doldurulmamış, tamamlanmamış operasyondur.
        void Add(); //Default publictir
        // Inheritance'ta her yerde ortak Add() operasyonu vardır.
        // Interface'te imza aynı ama her kullanan için operasyon farklıdır.
        // Interface arayüz, şablondur.
        // Kullanan herkes imzaları, şablonu taşımak zorundadır.
        // Şablonu her kullanan kendine göre doldurur.

        void Update();
    }

    // implements - interface
    class EmployeeManager : IPersonManager
    {
        // Interface implement edilerek tamamlanmış oluyor, içi doldurulmuş oluyor!
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class WorkerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Çalışan Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) // EmployeeManager, WorkerManager ekleyebilmek için onların implement ettiği tipi kullanırız.
        { // IPersonManager onu implement eden tüm sınıfları tutabildiği için parametre olarak onu geçersek her üyesini kullanabilir.
            // personManager'a EmployeeManager,WorkerManager hangisi gelirse onun Add() metodu çalışır.
            personManager.Add();
        }
    }
}
