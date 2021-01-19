using System;

namespace Homework_ThirdDayPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Değer tipler, metotlara birebir kopyası oluşturularak geçirilirler 
            * ve metot içerisinde o değişkenle ilgili yapılan değişikliklerden
            * orijinal değer etkilenmez. Ancak bazen değer tiplerini de referansları ile 
            * metotlara parametre olarak vermek isteyebiliriz. Referans yolu ile 
            * metoda parametre olarak geçtiğimiz değişken üzerinde yapılacak bütün değişiklikler 
            * orijinal değeri etkileyecektir. Çünkü artık o metot içerisinde değişkenin 
            * bir kopyası değil de RAM'deki adresi bulunan bir değerdir. Örneğin:
            */
            int originalValue = 43;
            Console.WriteLine("ChangeMethod'dan önce: " + originalValue); //Output 43

            ChangeMethod(1, 3, ref originalValue);
            Console.WriteLine("ChangeMethod'dan sonra: " + originalValue); //Output 47

            // Out kısmının açıklanması:
            int refValue = 5; // Başlangıç değeri atanması zorunludur.
            int outValue; // Başlangıç değeri atanması zorunlu değildir.
            ChangeMethod2(out outValue, ref refValue);

            Console.WriteLine("ChangeMethod2'den sonra refValue : " + refValue); //Output 7
            Console.WriteLine("ChangeMethod2'den sonra outValue: " + outValue); //Output 8
        }

        static void ChangeMethod(int x, int y, ref int i)
        {
            i = i + x + y; //i değişkeninin referan adresindeki değeri 47 olur!
        }
        /* ChangeMethod'una o değişkenin örneğini değilde RAM'de bulunan adresini geçtiğimiz için 
        * "i" parametresi metodu çağırırken kullandığımız "originalValue" değerine refer ettiğinden
        * yapılan bir değişiklik "originalValue" parametresinin kendisine yapılmış olur.
        */

        static void ChangeMethod2(out int i, ref int j)
        {
            i = 8; // i argümanına bir değer atamak zorunludur. i değeri başta ataması dahi olsaydı 8 olarak çıkar.
            j = j + 2; // j için böyle bir zorunluluk yoktur. Refer ettiği için j yani refValue=7 olur
        }

        // Out aslında ref ile hemen hemen aynı amaca hizmet ediyor. 
        /* Ancak ref ile aralarında temel 2 farklılık vardır:
        * 1- Değişken metot içerisinde herhangi bir değişiklik yapmadan kullanılamaz.
        * 2- Orjinal değişken değeri metoda parametre olarak geçilmeden önce bir başlangıç değeri almak zorunda değildir.
        */
    }
}
