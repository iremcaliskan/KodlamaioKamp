using System;
using System.Collections.Generic;

namespace Homework_FourthDayPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary Sınıfı:
            // Standart diziler sabit boyutludur.
            /** Programlama aşamasında dizinin boyutu belirtilir ve programın
             * çalışması sırasında değiştirilemez.
             ** Dictionary sınıfı ise değişken boyutludur.
             ** Eleman ekleme ve çıkarmaya göre boyutu dinamik olarak değişir.
             ** Standart dizilere eklenen elemanlar, belleğe sıralı bir şekilde 
             * yerleştirilmektedir. 
             ** Sıfırdan başlanarak her bir elemana birer indeks değeri verilip,
             * elemanlara o indeksler aracılığıyla erişmemiz sağlanır.
             ** Koleksiyon sınıflarından biri olan ArrayList içinde aynı durum
             * söz konusudur. 
             ** ArrayList’e eklenen her bir elemana indeks numarasıyla 
             * erişe bilmekteyiz.
             ** Dictionary koleksiyonunda ise Anahtar(Key) ve Değer(Value) 
             * olmak üzere iki kavram karşımıza çıkar. 
             ** Konuyu daha anlaşılır kılmak açısından; standart dizilere
             * eklediğimiz elemanları Değer, o elemanlara erişmek için 
             * kullandığımız indeksleri de Anahtar olarak düşünebiliriz.
             ** Her bir Değerin farklı bir Anahtarı olmalıdır, yani koleksiyon
             * içerisinde yer alan Anahtarlar birbirinden farklı olmalıdır.
             ** Dictionary sınıfından bir nesne oluştururken, 
             * anahtar ve değerin veri tiplerini belirtmemiz gerekir. 
             ** Aşağıdaki kod satırında, Key_Tipi yerine Anahtarın veri tipini,
             * Value_Tipi yerine de Değerin verini tipini belirtmeliyiz.
             */

            //Sample of Dictionary usage:
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(123, "İrem Çalışkan");
            students.Add(456, "Ece Salkım");
            students.Add(789, "Naz Aras");
            students.Add(159, "Engin Demiroğ");
            
            Console.WriteLine("Öğrenci No Giriniz:");
            int num = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(students[num]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }

            //MyDictionary
            MyDictionary<int, string> students2 = new MyDictionary<int, string>();
            students2.Add(12345, "İrem Çalışkan");
            students2.Add(12457, "Ayşe Yıldız");
            students2.Add(23568, "Naz Aras");
            Console.WriteLine(students2.Count);
            students2.ListAll();
        }
    }

    class MyDictionary<K, V>
    {
        K[] _key, _keyTemp; 
        V[] _value, _valueTemp;

        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }

        public void Add(K key, V value)
        {
            _keyTemp = _key; // keyTemp key'in referansını tutar.
            _valueTemp = _value; // valueTemp value'nun refaransını tutar.

            _key = new K[_key.Length + 1]; //key'in boyutu bir arttırılır ve newlenir.
            _value = new V[_value.Length + 1]; //value'nun boyutu bir arttırılır ve newlenir.

            for (int i = 0; i < _keyTemp.Length; i++)
            { // Önceki değerleri kaybetmemek için keyTemp ve valueTemp'ten elemanlar geri alınır.
                _key[i] = _keyTemp[i];
                _value[i] = _valueTemp[i];
            }

            // Boşalan alana yapılacak yeni atama için kontroller sağlanır,
            // Parametre olarak gelecek yeni değer key'in değeri boş olursa hata vermeli,
            // Gelen key'in elimizde listedeki herhangibir key ile çakışması durumunda
            // hata vermeli, key değerleri eşsiz olmalıdır.
            for (int j = 0; j < _keyTemp.Length; j++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key can not be null!");
                }
                else if (_keyTemp[j].Equals(key))
                {
                    throw new ArgumentException("Same key already exists in key array!");
                }
            }
            // Kontrollerden geçen key değeri ve değer ataması yapılır
            _key[_key.Length - 1] = key; // Açılan boşluğa key atanır.
            _value[_value.Length - 1] = value; // Açılan boşluğa value atanır.
        }

        public int Count
        {
            get { return _key.Length; }
        }

        public void ListAll()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("({0} , {1})", _key[i], _value[i]);
            }
        }
    }
}
