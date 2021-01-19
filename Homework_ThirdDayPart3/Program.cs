using System;

namespace Homework_ThirdDayPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar DRY implementasyonlarından biridir.
            // PascalCase
            // Best Practice
            // Metotlar, bir işlemi bir daha kullanmak için tek merkezde kontrol edebilme imkanı sağlar.
            // Void işlem yap anlamına gelir, return kullanılmaz!
            
            Sample();
            
            Add(2, 9); // Hesap yapıldı, sonuç döndürüldü. Fakat yazdırma yapılmadı!
            var result = Add(2, 9);
            Console.WriteLine(result);
            Console.WriteLine(Add(2, 9));

            var result2 = Add(20); // Default değer atandığı için işlem yapılır.
            Console.WriteLine(result2);
            // Default değerler her zaman en sonda olmalıdır.
            // Sadece ilk değerin default olması söz konusu değildir.
            // (int num1=20, int num2=30) olur
            // (int num1=10, int num2, .....) olmaz!
            var result3 = Add();
            Console.WriteLine(result3);

            int num1 = 20;
            // ref keyword'ünde num1'in mutlaka tanımlı olması gerekir.
            int num2 = 100;
            var resul4 = Add2(ref num1, num2); // Metoda 20 ve 100 değeri gönderilir, ama 
            // içerideki tanımdaki num1 = 30 ile üstteki num1 aynı değildir!
            // Metoda girince num1 30 olur ve toplamları 130 döner!
            Console.WriteLine(resul4);
            Console.WriteLine(num1); // ?
            // num1'in fonksiyon scope'u fonksiyon içerisidir.
            // 20 döner!
            // num1'in değişmesini istiyorsak, ref keyword parametre önüne eklenir!
            // Hem göndirelen yere hemde gönderilecek yere ref keyword eklenmeli!
            // ref keyword'ü ile num1 30 olarak değiştirilir!
  
            int num3;
            int num4 = 66;
            var result5 = Add3(out num3, num4);
            Console.WriteLine(result5);
            // out keyword'ünde num3'ün tanımlı olması gerekmez!
            // Metot içindeki tanımdan veri alınır!
            // Başta tanım varsa ve metotda da tanım yoksa hata verir!
            // Başta tanım varsa ve metotda da tanım varsa baştakinin hiçbir anlamı olmaz,
            // Metot içindeki set edilmeye bakar!

            // ref ve out keywordleri aynı işlem için kullanılır,
            // Ama tanım gerektirmeleri yönüyle değişir.
            // out değişkeni metot içinde set edilmek ister!

        }
        static void Sample()
        {
            Console.WriteLine("Method is called!");
        }

        static int Add(int num1=16, int num2=30) // Eğer num2 verilmezse default değer olarak 30'u kullan.
        {
            var sum = num1 + num2;
            return sum;
        }

        static int Add2(ref int num1, int num2) // num1'in referansını kullan, yeni değişken atama demektir!
        {
            // Örneğin, müşteriye özel indirim kuponu tanımlamak veya özel kredi tanımlamak  gibi!
            num1 = 30;
            return num1 + num2;
        }

        static int Add3(out int num1, int num2)
        {
            num1 = 33; // Değişken tanımlansın, tanımlanmasın burada set edilmesi gerekir!
            return num1 + num2;
        }
    }
}

