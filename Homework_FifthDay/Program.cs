using System;

namespace Homework_FifthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            //MultidimensionalArrays();

            string[] names = { "Kerem", "Beren", "Helen", "İrem", "Ceren", "Deren" };

            LoopsManager loopsManager = new LoopsManager();
            loopsManager.For(6);
            loopsManager.While(16);
            loopsManager.DoWhile(26);
            loopsManager.Foreach(names);

            if (loopsManager.isPrimeNumber(3))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            //StringType();
            //StringMethods();

            // Classlar yapılan işlemleri gruplamak, grup üzerinden işlemleri yapmak, gruba rahatlıkla ulaşmak için kullanırız.
            CustomerManager customerManager = new CustomerManager(); // Class'ı kullanmak için Class'ın bir örneğini, referansını oluşturmak
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); // Product ile ilgili işlemler için örneğinin oluşturulması zorunludur.
            productManager.Add();
            productManager.Update();
            // Gruplama yapılmış oldu.

            Customer customer1 = new Customer(); // Class'ı kullanmak için newlemek gerekir.
            customer1.Id = 0;
            customer1.Name = "İrem"; //Class'ın property'sini eşitlediğimiz zaman set bloğu çalışır. Değeri kuruyoruz, ayarlıyoruz.
            customer1.Surname = "Çalışkan";
            customer1.Mail = "iremcaliskan0@outlook.com";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer() 
            {
                Id = 1, Name = "Ceren", Surname = "Yıldız", 
                City = "İstanbul", Mail = "cerenyildiz@gmail.com" 
            };
            Console.WriteLine(customer2.Name); // customer2.Name'i ver, yani get al bloğu çalışır.

        }

        private static void StringMethods()
        {
            string sentence = "My name is İrem Çalışkan";
            var result = sentence.Length;
            var result2 = sentence.Clone(); // Clonlama ile değişkenin klonu oluşturulur.
            //sentence = "ASDDFFGGH";
            //Console.WriteLine(result2);
            //Console.WriteLine(sentence);
            var result3 = sentence.EndsWith("n"); // Sonuç bool döner.
            Console.WriteLine(result3);
            var result4 = sentence.StartsWith("i"); // Küçük i büyük i farklı
            var result5 = sentence.StartsWith("My name");
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf("xxx");
            Console.WriteLine(result6); // Başlangıç indexini yazdırır.
            // Bulamazsa -1 döndürür.

            var result7 = sentence.IndexOf(" ");
            Console.WriteLine(result7); // Bulduğu ilk yeri yazdırır.

            var resul8 = sentence.LastIndexOf(" ");
            Console.WriteLine(resul8); // Aramaya sondan başlar. İlk bulduğunu yazar.

            var result9 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result9);

            var result10 = sentence.Substring(3, 4); // 3. indexten itibaren 4 tane al
            Console.WriteLine(result10);

            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            Console.WriteLine(String.Format("{0} {1}", result11, result12));

            var result13 = sentence.Replace("İrem", "Ceren");
            var result14 = sentence.Replace(" ", "-");
            Console.WriteLine(String.Format("{0} \n{1}", result13, result14));

            var result15 = sentence.Remove(2, 8); // 2.indexten sonrasını sil.
            Console.WriteLine(result15); // 2.indexten itibaren 8 tane sil.
        }

        private static void MultidimensionalArrays()
        {
            // Multidimensional arrays (Çok boyutlu diziler)
            //string[,] regions = new string[7, 3]; // 7 satır, 3 sütun
            string[,] regions = new string[5, 3] // 5 bölgenin 3 şehri
            { {"İstanbul","İzmit","Gebze" },
              {"Ankara","Konya","Kırıkkale" },
              {"Antalya","Adana","Mersin" },
              {"Rize","Odru","Trabzon" },
              {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // 5 0.dimension
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("------");
            }
        }

        private static void Arrays()
        {
            //Arrayler - diziler
            string student1 = "İrem";
            string student2 = "Naz";
            //
            /* Aynı tipteki değerleri, değişkenleri tek bir noktada yönetip,
             * tek bir değişkenle yönetmemizi sağlayan yapılar Array'lerdir.
             * Ayrıca değerlere hızlıca ulaşmamızı ve değerleri bir döngüyle 
             * gezmemizi sağladığı için Array'lere ihtiyaç duyarız.
             */
            string[] students = new string[3];
            students[0] = "İrem";
            students[1] = "Ceren";
            students[2] = "Derin";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("----------------");

            string[] students2 = new string[] { "Kerem", "Beren", "Helen" };
            string[] student2Alt1 = new[] { "Kerem", "Beren", "Helen" };
            string[] student2Alt2 = { "Kerem", "Beren", "Helen" };
            string[] student2Alt3 = new string[3] { "Kerem", "Beren", "Helen" };

            for (int i = 0; i < students2.Length; i++)
            {
                Console.WriteLine(students2[i]);
            }

            Console.WriteLine("\n" + student2Alt1[1]);
            Console.WriteLine("\n" + student2Alt2[2]);
        }

        private static void StringType()
        {
            string city = "İstanbul"; //Stringler birer char Array'idir.
            Console.WriteLine(city[2]); //t

            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(city.ToLower()[i]);
            }

            foreach (var item in city.ToUpper())
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(city.Contains('a'));
            //Console.WriteLine(city.Replace("t","T"));

            string sentence = "Hello boys, I'm Crowley!";
            string[] x = sentence.Split(',');
            Console.WriteLine(x[1].Trim()); // Baş ve son boşluklarını siler.


            string city1 = "İstanbul";
            string city2 = "İzmir";
            string result = city1 + city2;
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city1, city2));
        }
    }
}
