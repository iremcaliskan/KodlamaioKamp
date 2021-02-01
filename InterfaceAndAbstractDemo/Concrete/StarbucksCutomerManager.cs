using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class StarbucksCutomerManager : BaseCustomerManager // ,IPersonCheckService
    {
        private IPersonCheckService _personCheckService; //Bir doğrulama gerektirir, Mernis

        public StarbucksCutomerManager(IPersonCheckService personCheckService) // Oluşturulma anında bir kişi kontrol servisi alır.
        {
            _personCheckService = personCheckService;
        }

        public override void SaveToDatabase(Customer customer) // Default metod iki aşamalı olarak değiştirilir.
        { // Database'e kaydedilirken, oluşturulan kontrol servisine göre kişinin gerçekliğini kontrol eder, gerçek değilse hata verir!
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.SaveToDatabase(customer); // Veritabanına kaydeden kod

            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }
    }
}
