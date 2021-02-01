using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerService
    { // Müşterileri Database'e kaydetme operasyonu, her iki firma içinde ortaktır ancak Mernis doğrulaması isteneceği için imzası oluşturulur, interface'e yazılır.
        void SaveToDatabase(Customer customer); // Starbucks ve Nero müşterilerini veritabanına kaydetmek istiyor.
    }
}
