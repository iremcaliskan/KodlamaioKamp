using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Class'ın belirli bir tiple(T) çalıştığını söyleriz.
    {
        T[] items; //Heryerden erişilir! T tipinde bir dizi
                   // Bir array'in new'lenme zorunluluğu vardır!
                   // Bir class new'lenince çalışan bloğa Constructor denir.
                   // List<T> sınıfı arkaplanda bir array yönetir.
                   // Bizim sınıfımızda burada bir array yönetecek!
        public MyList()
        { // constructor(yapıcı) metot
            // Classların instance yani bir yerde new ile oluşturulmasıyla bu metot otomatik çalışır.
            items = new T[0]; 
            // Bu class bir yerde newlenirse, constructor otomatik olarak 0 elemanlı bir array oluşturup ona bir referans numarası atar.
            // default olarak çalışır!
        }
        public void Add(T item) //T olarak ne verirsem, istediğim elemanın türüde odur!
        {
            T[] tempArray = items; // Geçici dizi items'ın referansını tutuyor!
            items = new T[items.Length + 1]; // O dı 1 oldu ama new ile yeni referans numarası tutulduğu için elemanlar kaybolacak!
            //Referansı tutacak bir eleman lazım! Önceki değerleri tutmak için(tempArray)
            for (int i = 0; i < tempArray.Length; i++)
            { // Verileri geri almak için
                items[i] = tempArray[i];
            } // elemanları geri alır ve bir index boşluk yaratır!

            items[items.Length - 1] = item; //Eklenmek istenen elemanı yani item'ı açılan yere eklememizi sağlar!
            
        }

        public int Length //Eleman sayısını verir!
        {
            get { return items.Length; }
        }

        public T[] Items //Eleman sayısını verir!
        {
            get { return items; }
        }

    }
}
