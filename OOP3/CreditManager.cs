using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    { // ICreditManager'ı implement eden her sınıf için referans tutsun diye,
        // Ve aynı zamanda tüm implement eden sınıfların uygulaması zorunlu olan
        // operasyonları tutması için bu interface'i oluşturduk.

        /* Teknik olarak: Interface oluşturulduğunda içerisindeki operasyonlar
         * alternatif sistemler için bir şablon ve ek olarak referans tutucu
         * görevini görür. Interface'leri birbirinin alternatifi olan ama 
         * kod içerikleri farklı olan durumlar için kullanırız.
         */

        /* Örneğimizde: Kredi türlerinin hepsinde hesaplama vardır,
         * ama bu hesaplamaların kodları birbirinden farklıdır. Faiz oranları,
         * dosya masrafları, BDDK'nın kuralları gibi kredinin türlerine göre
         * hesaplama işleri değişkenlik gösterir.
         */

        public void Calculate() // imza kısmı: void CalculateCredit()
        { // İmzanın aynı olduğu, içerisinin farklı olduğu durumlarda class yerine interface kullanırız. 
        }
        
        // Interface'i kullanan her sınıf interface'in metodlarını içermek zorundadır.
        // Okunurluk için interfaceler I harfi ile başlar.
        /* Interface'i kullanacak olan her sınıf yani 
         * interface'den implemente olduğu için o interface'in 
         * metotlarını içermek zorundadır.
         */

        // Interface, arayüz yani şablon demektir.
        /* Interface'i implemente eden yani kullana her sınıf, 
         * interface'in kurallarını yani şablonunu implement etmek zorundadır.
         * Şablonu implement eden her sınıf kendi kurallarını aynı metotlar
         * üzerinden belirleyebilir.
         */
        
        // Interface'ler genellikle operasyonel metodlar için kullanılır.
        // Metot veya metotlar aynı ama kullanan her sınıf kendisine göre yazmak istiyorsa interface kullanılır.
        void CalculateCredit();
        void DoSomething();
    }
}
// loglama: Sistemdeki hareketlerin Dökümü
// Veri tabanına yazma, dosyaya yazma, mail yollama, sms yollama gibi alternatif sistemleri vardır.