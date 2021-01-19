using System;
using System.Linq;

namespace Homework_ThirdDayPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metod Overloading
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add(1,2,3,4,5,6)); // İstenilen miktarda parametre yollanır.
            // İlk gönderilen değer int number parametresi olarak algılanır, toplamaya dahil edilmez!
        }

        static int Multiply(int num1, int num2) // int Multiply(int num1, int num2) kısmı metodun imzasıdır!
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3) //Aynı isimli farklı parametre alan bir metot yazılabilir.
        { // Bu duruma metotların aşırı yüklenmesi denir! (Overload)
            return num1 * num2 * num3;
        }

        static int AddOverload(int num1, int num2)
        { // 1,2,3....100 sayı toplamak için Overload yapılmaz!
            return num1 + num2;
        }
        static int Add(int number, params int[] numbers) // params notation ile dizi formatında parametreler yollayabiliriz.
        { // 1,2,3....100 sayı toplamak için Overload yapılmaz!
            // params'lı ifade en sonda veya tek olmak zorundadır!
            return numbers.Sum(); //Linq hazır notation'ı
        }

    }
}