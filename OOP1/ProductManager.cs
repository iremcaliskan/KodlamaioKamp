using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // ProductService'te verilebiliyor!
    { // Ürünle ilgili operasyonlar Manager,Service,Controller,... gibi classların içerisinde bulunur!
        
        //Encapsulation, çok fazla parametre vermek yerine obje verilir!
        // void keyword, void ile belirtilen metotlar komut olarak görülür, ekle, güncelle, sil gibi.
        public void Add(Product product) // Parametre olarak ürün verilecek!
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Do(int num) 
        {
            num = 99;
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        // Void ve Return Farkı
        public int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }

        /* Sayıları toplar int tipinde bir değer döndürür!
         * return döndür demektir, sana değer veririm demektir!
         */

        public void Sum2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        /* Sayıları toplayıp ekrana yazdırır.
         * void, git yap bitir mantığıyla çalışır!
         * */
    }
}
