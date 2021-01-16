using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {   // Sepete ekle
        // Manager, Service, Controller, DataAcces, Dal gibi sözcükler var ise operasyon tutulduğunu anlamamız gerekir.

        // Naming Convention add() değilde Add() 
        // Syntax
        // Encapsulation yapılmış! Class kullanılmış!
        public void addToCart(Product product) //Metod parametre alıyor o da ürün
        {
            // Neyi eklemek istediğini metoda vermek gerekir.
            // Parametre vermek gerekir.
            Console.WriteLine("{0} {1} TL, Sepete Eklendi!", product.name, product.price);
        }

        // Kötü kullanım!
        // Bir değişim her sayfayı bozar! Tek tek düzeltme gerekir!
        public void addAlternative(string productName, string description, double price, int stockNum)
        {
            Console.WriteLine("Sepete Eklendi :" + productName);
        }
    }
}
