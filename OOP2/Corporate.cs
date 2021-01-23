using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras, Inheritance
    // Tüzel Müşteri bir Müşteridir.
    // Corporate extends Client
    class Corporate:Client
    { // Tüzel Müşteri
        public string CompanyName { get; set; } // Şirket Adı
        public string taxId { get; set; } // Vergi Numarası
    }
}
