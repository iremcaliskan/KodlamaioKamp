using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_FifthDay
{
    class Customer
    { // Classlar genel olarak ya operasyon yada özellik tutar.
        // CustomerManager operasyonları tutarken,
        // Customer; Property yani özellikleri, nesneleri tutabilir.
        // Entity(varlık) özelliklerini tutmak için nesneleri tutarız.
        public int Id { get; set; }
        //public string Name { get; set; } //Property tanımlamak
        // public string Name; // Field tanımlamak
        // Ne fark var?
        // 
        private string _name; //_name değişkeni tutuluyor

        public string Name
        {
            get { return "Mr." + _name; } // Name istenince Mr. _name verilir.
            set { _name = value; } // Name atanırken değer atanıyor.
            // Field üzerinde get veya set ederken, değeri verirken veya okurken başka bir şey yapmak istenirse
            // propfull, bu olaya implementation gizlenme, encapsulation denir.
            // Single Responsibilty'e aykırıdır.
        }

        public string Surname { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }

    }
}
