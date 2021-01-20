using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classlar; özellik barındıranlar ve operasyon barındıranlar olarak ikiye ayrılır.
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoriId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Bu şekilde de tanımlama yapılabilir!
            Product product2 = new Product { Id = 2, CategoriId = 5, UnitsInStock = 5, ProductName = "Kalem",
                UnitPrice = 35 }; // () işareti yokkk!
            // Angular kullanarak kullanıcadan alıyor olacağız bu bilgileri!

            // PascalCase -- camelCase
            // case sensitivity in C#
            // ProductManager türündeki productManager değişkeni referans numarası almış yeni bir ProductManager'dır.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            // diziler, classlar, abstract class, interface
            // Referans tipler verileri heapte tutar.
            // Atamalar referans numaralarıyla yapılır, o numaraya yeni bir değer atandığı için değişir.

            int num = 100;
            productManager.Do(num);
            Console.WriteLine(num);
            // primitive tipler yani değer tipler verileri stack'te tutar.
            // değerle ilgilenir adresle değil!
            // main classtaki atamayla diğer classtaki atamanın bir bağlantısı yoktur!
            
            productManager.Sum2(3, 6); // Bu işlem sonucundaki sum'ı kullanmak istiyorsak return gerekir.
            int sumResult = productManager.Sum(3, 6);
            Console.WriteLine(sumResult*2);

        }
    }
}
