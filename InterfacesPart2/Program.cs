using System;

namespace InterfacesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir interface newlenemez. Tek başına bir anlamı yoktur, şablon tutar.
            //IPerson person = new IPerson(); //Cannot create an instance of the abstract type or interface.

            //IPerson person = new Customer(); // Person olan her sınıfın instance'ı oluşturulabilir.
                                             // Soyut nesneleri interface ve abstracları newlemek mümkündeğildir.

            CustomerDalManager customerDALManager = new CustomerDalManager();
            customerDALManager.Add(new SqlServerCustomerDAL());
            customerDALManager.Update(new OracleCustomerDAL());

            /* Polymorphisim(çok biçimlilik), bir nesneyi farklı amaçlarla implement edip,
             * o implementationların belirli bir kısmına veya tamamına ulaşmaktır.
             */
            // Polymorphisim:
            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlServerCustomerDAL(),
                new OracleCustomerDAL(),
                new MySqlCustomerDAL()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); // Veritabanları gezilip, herbiri için Add() çağırılır.
            }
            // Yeni bir veritabanı desteği eklenmek istenirse, kodlara dokunulmadan yeni kısımlar eklenir.
        }
    }
}
