using System;

namespace Homework_ThirdDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            // veriTipi değişken = değeri;
            // 32 bitlik yer kaplar!
            int num1 = -2147483648;
            int num2 = 2147483647;
            Console.WriteLine("Integer number boundry is from {0} to {1}", num1, num2);

            // - veya + 2 milyardan büyük tam sayılar için
            // long inti kapsar, 2 kat büyük sayıları tutar denebilir.
            // Bellekte 2 kat daha fazla yer kaplanır.
            // Sayı 2 milyardan azsa integer kullan.
            // 64 bitlik yer kaplar!
            long num3 = 9223372036854775807;
            long num4 = -9223372036854775808; //19 karakter
            Console.WriteLine("Long number boundry is from {0} to {1}", num3, num4);

            // 16 bitlik yer kaplar!
            short num5 = -32768;
            short num6 = 32767;
            Console.WriteLine("Short number boundry is from {0} to {1}", num5, num6);

            // 8 bitlik yer kaplar! (1 byte)
            // Negatif değerleri tutmaz!
            byte num7 = 0;
            byte num8 = 255;
            Console.WriteLine("Byte number boundry is from {0} to {1}", num7, num8);

            // Koşullu durumlarda kullanılır!
            bool conditionOk = true;
            bool conditionNotOk = false;
            Console.WriteLine("Boolean values are {0} and {1}", conditionOk, conditionNotOk);

            // char bir değer tipidir!
            // ASCII(klavye karakterleri) karakterlerin bir tam sayı değeri vardır!
            char character = 'A';
            Console.WriteLine("Örnek karakter : {0}", character);
            Console.WriteLine("'{0}' karakterinin değeri: {1}", character, (int)character);


            // String değer tip değildir!
            string city = "Istanbul"; //8 karakterli bir dizi anlamına gelir!

            // Ondalıklı sayılar tutulur.
            // 64 bitlik yer kaplar!
            double num9 = -999999999.999999; //Hassasiyeti 15-16 digittir.
            double num10 = 999999999.999999;
            Console.WriteLine("Double number precision is 15-16 digits {0} , {1}", num9, num10);

            // Ondalıklı sayılar tutulur!
            // Daha hassas hesaplar için kullanılır!
            // Hassasiyeti 28-29 digittir.
            // Double'ın iki katıdır. (Int ve float gibi)
            // decimal değişken = 1.6m/M ;
            decimal num11 = -99.99999999999999999999999999m;
            decimal num12 = 99.99999999999999999999999999m;
            Console.WriteLine("Decima number precision is 28-29 digits {0} , {1}", num11, num12);

            // Enum, enumaration(numaralandırma).
            // Alanları sabit bir sabitler kümesinden oluşur!
            // Compile time da type safety sağlar!
            // magic string değerleri tutmak yerine, onlar
            Console.WriteLine(Days.Saturday);
            Console.WriteLine((int)Days.Saturday);

            // var keyword, değişken tutmak için kullanılır.
            var num13 = 10; // var burada integer olarak algınır!
                            // İlk atama integer olduğu için burada her atama integer olarak algılanacak!
                            // Başta ne verilirse öyle devam eder!
            num13 = 'A'; // A karakterinin değerini yani 65'i alacaktır.
                         // num13 = "A"; String ataması hata verecektir.
                         // num13 = 10.5; Double ataması hata verecektir.
            Console.WriteLine(num13);
        }
    }
    enum Days { Monday = 0, Tuesday, Wednesday, Thursday, Friday = 16, Saturday, Sunday }
}
