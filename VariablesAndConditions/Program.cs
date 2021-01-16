using System;

namespace VariablesAndConditions
{
    class Program
    {
        static void Main(string[] args) // Main metodu: Programın ilk başladığı yerdir.
        {
            //Console.WriteLine("Hello World!");
            string categoriTag = "Kategori"; // Tek tırnak char(karakter) için kullanılır.
            string abc = "abc";

            Console.Write(abc); // Write aynı satıra yazmaya devam eder.
            Console.Write(abc);

            Console.WriteLine(categoriTag); // WriteLine yeni satıra yazar.
            Console.WriteLine(categoriTag);

            int studentNumber = 32000; // Tam sayıları tutar
            double rate = 1.45;
            float rate2 = 1.45f;

            bool isLogin = true; // Gerçek hayatta true kısmı veri kaynağından gelir.
            // Normalde bu durumu bilemeyiz, bu yüzden koşullar belirleriz.

            if (isLogin) // Belirtme olmazsa default olarak true kabul edilir.
            {
                Console.WriteLine("iremcaliskan");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

            double dollarYesterday = 7.45;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Azalış oku gösterilir");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Artış oku gösterilir");
            }
            else
            {
                Console.WriteLine("Değişmedi şablonu gösterilir.");
            }
        }
    }
}

// Programlama dili bir projenin her şeyi değildir.
// variable: veri tutan yapılardır.
// ; zorunludur.
// değer tutucu, alias

/* Type-safety: Tür güvenliği, 
 * derleyici derleme sırasında türleri doğrular 
 * ve bir değişkene yanlış bir tür atanırsa
 * hata vereceği anlamına gelir. 
 */
// Do not repeat yourself!!!!!