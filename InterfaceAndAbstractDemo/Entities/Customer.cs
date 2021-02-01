using InterfaceAndAbstractDemo.Abstract;
using System;

namespace InterfaceAndAbstractDemo.Entities
{
    public class Customer : IEntity // Çıplak Class kalmasın
    { // Müşterilerin özelliklerini tutan sınıfımız oluşturuldu.
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
