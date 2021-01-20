using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack         heap        değerleri
            string[] names = new string[] {"İrem", "Ceren", "Kerem", "Engin" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5]; // 5 elemanlı boş bir arrray oluştu aslında!
            names[4] = "Ali"; //Aliyi 4'e atadın, öncekiler boş kaldı demektir!
            // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]); //Boş geldi

            // Uzun listelere yeni veriler eklemek için koleksiyonlar kullanılır!
            // Arrayler ilk tanımlandıkları şekli korurlar, ya tanımı değiştirmek yada ekleme metodları kullanılmasını gerektirir.
            // Çok fazla veri olduğu için bu yol tercih edilmez!
            // Elimizdeki array 4 elemanlı, 5 elemanlı yaparsak eski elemanları kaybederiz.
            // new demek yeni referans adresi demektir!

            /*       Stack         (new)           Heap
             * string[] names ------------------ [i,c,k,e] 101.Address diyelim
             * names --------------------------- [ , , , , a] 102.Adress diyelim
             * Yeni referanstaki 4.index ataması ile 4.indexe eleman atanır.
             * Öncesi boş kalır!
             * */

            // System.Collections.Generic sınıfının bir sınıfıdır.           
            List<string> names2 = new List<string> { "İrem", "Ceren", "Kerem", "Engin" };
            Console.WriteLine(names2[0]);
            names2.Add("Efe");
            names2.Add("Elif");
            Console.WriteLine(names2[4]);
            names2.Remove("Elif");
            Console.WriteLine(names2.IndexOf("Elif"));
        }
    }
}
