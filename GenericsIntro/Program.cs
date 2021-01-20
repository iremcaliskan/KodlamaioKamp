using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        { //List<string> name = new List<string>();

            //MyList names = new MyList(); hata verir çünkü çalışacağı tipi ister!
            MyList<string> names = new MyList<string>();
            // T string oluyor.
            names.Add("İrem");
            Console.WriteLine(names.Length);

            names.Add("Efe");
            names.Add("Elif");
            Console.WriteLine(names.Length); // MyList'teki kendi Length'imiz.

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nFor Döngüsü ile Listeyi Yazdırma:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names.Items[i]);
            }
        }
    }
}
