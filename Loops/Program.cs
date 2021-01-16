using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler: Birbirine benzeyen işleri tekrarlamak için kullanırız.
            // Örneğin Kursları döngü ile dolaşarak kursları listeleyebiliriz.

            //snippet : iskelet oluşturma == tab tab yapma
            for (int i = 0; i < 10; i += 2) // 2şer arttırma
            {
                Console.WriteLine(i);
                /* 0'dan başla 10'a kadar devam et
                 * i=0 ok, i++=1, ..... i=9 ok i++=10, i=10 stop!
                 */
            }
            Console.WriteLine("İşlem Sonu");

            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya Başlangıç İçin Temel Kursu";
            string course3 = "Java Programlama";
            string course4 = "C# Programlama";
            string course5 = "Android Programlama";
            // Bunun gibi bir yazış yanlıştır. Yeni eklenmeler için dinamik listeleme gereklidir.
            // Yüzlerce değişken tanımlanması olmazzzzz!
            // Listeler yani diziler yani Arrayler bunun için varlarrrr!

            // array - dizi
            Console.WriteLine("For Döngüsü");
            string[] courses = new string[] { //Birden fazla str tutan dizi - array
                "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kursu",
                "Java Programlama", "C# Programlama", "Android Programlama"
            }; // Yeni kurs ekleneceği zaman değişim sadece burada yapılır.
            for (int i = 0; i < courses.Length; i++) // Uzunluğu 5, i<5 için 0 1 2 3 4 yani tüm elemanları döndürür.
            { //Dinamik olması için statik(manuel) veriler yazılmaz, i<length dinamik, i<5 statik olur!
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("For Bitti!");

            Console.WriteLine("Foreach Döngüsü");
            foreach (string course in courses) //Büyük String class'a denk gelir!
            { // foreach dizi temelli yapıları tek tek döner
                // course ifadesi alias - geçici takma addır.
                Console.WriteLine(course);
            }
            Console.WriteLine("Foreach Bitti!");
        }
    }
}