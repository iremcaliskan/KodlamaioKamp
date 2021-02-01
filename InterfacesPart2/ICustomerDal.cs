using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPart2
{
    public interface ICustomerDal
    { // Data Acces Layer
        // Veritabanı işlemlerini yaptığımız sınıf: insert, update, delete..
        // ICustomerDAL : Oracle, SQL Server, MySql desteği için ayrı ayrı implement edilmesi gerekir.
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDAL : ICustomerDal
    {// Proje farklı veritabanlarını destekliyor:

        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }
    }

    class OracleCustomerDAL : ICustomerDal
    {// Proje farklı veritabanlarını destekliyor:
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }

    class MySqlCustomerDAL : ICustomerDal
    {// Proje farklı veritabanlarını destekliyor:
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }

    class CustomerDalManager
    { // Metot parametresi eklemekten ileri seviye olan constructor'a eklemekte bulur.
        // Henüz öğrenilmedi.
        public void Add(ICustomerDal customerDAL) // ICustomerDAL veri tipi ile onu kullanan her tipin kullanılması sağlanır.
        {
            customerDAL.Add(); // Seçilen, gönderilen tipin Add()'i çalışır.
        }
        public void Delete(ICustomerDal customerDAL) // ICustomerDAL veri tipi ile onu kullanan her tipin kullanılması sağlanır.
        {
            customerDAL.Delete(); // Seçilen, gönderilen tipin Delete()'i çalışır.
        }
        public void Update(ICustomerDal customerDAL) // ICustomerDAL veri tipi ile onu kullanan her tipin kullanılması sağlanır.
        {
            customerDAL.Update(); // Seçilen, gönderilen tipin Update()'i çalışır.
        }
    }
}
