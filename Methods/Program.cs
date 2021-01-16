using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodlar, tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            // DRY principle: Do not repeat yourself! - Clean Code - Best Practice (Doğru Uygulama Teknikleri)

            // Örneğin, e-ticaret sitesinde ürünlerin sepete ekleme kısmı.
            // Sepete ekleme her yere eklenen hatta mail ile gönderilen aynı fonksiyonu, metodu içerir.

            // Class'tan bir değişken tanımlama:
            Product product1 = new Product(); // Class'ın örneği yani instance oluşturma
            product1.name = "Elma";
            product1.price = 14.99;
            product1.description = "Amasya Elması";

            Product product2 = new Product();
            product2.name = "Portakal";
            product2.price = 8.99;
            product2.description = "Antalya Portakalı";

            Product product3 = new Product();
            product3.name = "Karpuz";
            product3.price = 80;
            product3.description = "Diyarbakır Karpuzu";

            // Class'tan oluşturulan değişkenleri diziye toplamak:
            // Belirtilen tipte birden fazla data içerir.
            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {//products'ın içini gez, product gezilecek verilere takılan isim(alias), Product ise veri tipi (type-safety için)
                // var da yazılsa olur!
                Console.WriteLine(product.name + " " + product.price + " " + product.description);
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine("\nFor Döngüsü Hatırlatma :)");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name + " " + products[i].price + " " + products[i].description);
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine("--------------Metodlar--------------");

            // Class instance - örnek
            // Burada sayfaların patlamadı! - Encapsulation
            // Encapsulation : kapsülleme, bir yapıyı bir kapsüle düzene koymaktır.
            CartManager cartManager = new CartManager();
            cartManager.addToCart(product1); // çağrılan metod parametre ister
            cartManager.addToCart(product2);
            cartManager.addToCart(product3);

            // Class olmasaydı, böyle ürün gönderildi!!
            // Ürünün Stok Fiyatınında girilmesi istensin!
            // Hepsi sayfa olsaydı, her yer bozuldu, her ürünün stok fiyatını girmen gerekecek, tek tek değiştirmek gerekecek!
            cartManager.addAlternative("Armut", "Sarı Armut", 12, 10);
            cartManager.addAlternative("Elma", "Sarı Elma", 8, 10);
            cartManager.addAlternative("Karpuz", "Japon", 45, 10);

            // cw = snippet of print command --- Console.WriteLine();

            // Metodlar,  reusability sağlar. (Tekrar tekrar kullanılabilme özelliği verir!)
        }
    }
}
