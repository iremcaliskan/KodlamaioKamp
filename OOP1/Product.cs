using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity(Varlık) isimleri
    {
        public int Id { get; set; } // Eşsiz değer, ayırt edici özellik
        public int CategoriId { get; set; } // Referencing key, Foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; } // Stok Adeti

        //CRUD Operasyonları: Create Read Update Delete
    }
}
