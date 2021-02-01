using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_FifthDay
{
    class LoopsManager
    {
        public void For(int item) 
        {
            for (int i = item; i >=0 ; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------");
        }

        public void While(int item) 
        {
            while (item >= 0)
            {
                Console.WriteLine(item);
                item = item - 2;
            }
            Console.WriteLine("------");
        }

        public void DoWhile(int item)
        {
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num = num + 2;

            } while (num <= item);
            Console.WriteLine("------");
            // Mutlaka yapılması gereken bir şey varsa do-while kullanılabilir.
            // Çok ihtiyaç yoktur bu döngüye.
        }

        public void Foreach(string[] items)
        {
            // Veritabanından çekilen tabloyu, datayı gezmek için kullanırız. 
            foreach (var item in items)
            { //foreach ile dönerken eleman değiştirme yapılmaz!
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
        }

        // Girilen sayının asal olup olmadığını bulan program:
        public bool isPrimeNumber(int num) 
        { // Sayı'nın kendisi bir hariç tam bölümü olmayan sayıdır!
            bool result = true;
            for (int i = 2; i < num -1; i++)
            {
                if (num % i == 0) // Tam bölen bir sayı var mı?
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
