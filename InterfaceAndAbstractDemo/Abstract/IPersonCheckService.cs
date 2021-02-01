using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface IPersonCheckService
    { // Gerçek kişi olup olmadığını kontrol etme şablonu
        bool CheckIfRealPerson(Customer customer); // İleride Nero'da isteyebilir.

    }
}
