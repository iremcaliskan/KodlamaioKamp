using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    { // Kullanacak her iki class için default olarak tanımlanır ama istenilen yerde virtual alan metot değişebilir.
        public virtual void SaveToDatabase(Customer customer)
        { 
            Console.WriteLine("Saved to Database : {0} {1}", customer.FirstName, customer.LastName);
        } // İstediğim yerde virtual ile metodu değiştirebiliriz.
    }
}
