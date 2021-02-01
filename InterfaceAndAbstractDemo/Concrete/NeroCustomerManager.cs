using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    { // Veritabanına ekleme Nero için Mernis gerektirmez, Default yazılan veri tabanına ekleme metodu BaseCustomerManager Abstract Class'ından alınarak çalışır.
        
        // Neroda istedi diyelim:
        IPersonCheckService _personCheckService;
        public NeroCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public override void SaveToDatabase(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.SaveToDatabase(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
