using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    { // Class, nesneyi tanımlayan birden fazla özellikleri barındıran yapıdır.

        // Property - Özellik
        // prop bir snippet, bizim için önceden tanımlı kısa yollar
        public int Id { get; set; } // Id bir datanın eşsiz değerini gösterir.
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public int stockNum { get; set; }

    }
}