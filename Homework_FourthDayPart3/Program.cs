using System;
using System.Collections.Generic;

namespace Homework_FourthDayPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Turkuaz renkler görüldüğü üzere classtır.
            // List'te bir classtır.
            // List'ler collections yani koleksiyonlardır.
            // List arkaplanda array bazlıdır yani array yönetir.
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Eskişehir");
            cities.Add("Ankara");
            cities.Add("İzmir");
            Console.WriteLine(cities.Count); // 4 bekleriz

            //MyList cities2 = new MyList();
            MyList<string> cities2 = new MyList<string>();
            cities2.Add("İstanbul");
            cities2.Add("Eskişehir");
            cities2.Add("Ankara");
            cities2.Add("İzmir");
            Console.WriteLine(cities2.Count); // 4 bekleriz
            cities2.ListAll();
        }
    }

    class MyList <T> //T : Type, Artık Generic bir class
    { // T, hangi tip verilirse ona dönüşür.
        T[] _array; //Hangi tip gönderilirse o tipte bir array yapılır.
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; //newlendiği anda 0 elemanlı bir array tutuyor.
        }

        public void Add(T item)
        { // Her eklemede eleman sayısı 1 arttırılmalı!
            _tempArray = _array; // tempArray array'in referansını tutar.
            _array = new T[_array.Length + 1];  // Her eklemede o eleman için yer açılmalıdır.
            // newleme işleminde eski veriler kaybedilir!
            // Elemanları kaybetmemek için referans adresini tutan bir array oluşturulur(tempArray).
            
            for (int i = 0; i < _tempArray.Length; i++) //tempArray array'e aktarılacak
            {
                _array[i] = _tempArray[i]; // array'in indisleri için tempArray indislerinden atamlar yapılır.
            } // Atamalar yapılıp array geri alınır

            // Son gelecek değer için atama yapılır, Parametreye gelecek item için atama
            _array[_array.Length - 1] = item;
        }

        public int Count // Uzunluğu bir Property olarak atadık.
        {
            get { return _array.Length; }
        }

        public void ListAll() // Listenin tüm elemanlarını yazdırma
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]); 
            }
        }

    }


}
