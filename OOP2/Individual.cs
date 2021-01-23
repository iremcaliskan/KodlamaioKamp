using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras, Inheritance
    // Gerçek Müşteri bir Müşteridir.
    // Individual extends Client
    class Individual:Client
    { // Gerçek Müşteri
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
