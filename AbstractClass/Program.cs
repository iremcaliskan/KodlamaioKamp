using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass(); // Cannot create an instance of the abstract type or interface!
            BaseClass inheritedClass = new InheritedClass();
            inheritedClass.Method1();
            inheritedClass.Method2();

            // Abstract Class ile Normal Class arasındaki farklar:
            /* Normal Sınıflarda metot bildirimi, içi boş metot, sadece imzası bulunan metot, yapılmazken 
             * Abstract Sınıflar içerisinde tıpkı interfaceler gibi metot bildirimi yapılabilir.
             * Bildirimi yapılan metodlar, Abstract Sınıftan türeyen sınıflarda içerisinde implement edilmek,
             * tamamlanmak, doldurulmak, zorundadır. */

            /* Normal sınıflardan “new” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar
             * tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.
             * Referans tutucu olarak kullanılabilirler.
             */

            // Abstract Class ile Interface arasındaki farklar:
            /* Interfacelerde sadece metot bildirimi yapılabilirken Abstract Sınıflarda hem metot bildirimi 
             * yapılabilir hem de metot tanımlanabilir.
             */

            /* Bir Sınıfa sadece bir tane Abstract sınıf inherit edilebilir ancak 
             * aynı sınıfa birden fazla Interface implement edilebilir.
             * InheritedClass : BaseClass, IDemo, IDemo2 gibi.
             * Ancak Bir Abstract Sınıfa başka bir Abstract Sınıf inherit ederek bu kısıtı kaldırabiliriz.
             */

            Month month1 = new January();
            Month month2 = new February();
            Month month12 = new December();

            Month[] months = new Month[]{month1, month2, month12 };

            foreach (var month in months)
            {
                Console.WriteLine(month.WhatMonthOfYear());
                Console.WriteLine(month.HowManyDays());
                Console.WriteLine(month.HowManyHoursAreDays());
            }

        }
    }

    abstract class BaseClass
    {
        // Kalıtım için kullanılacak temel sınıfları oluşturuken Abstract keyword'ünü kullanırız.
        // Abstract bir sınıf oluştururken erişim belirtecinden sonra "abstract" sözcüğünü yazarız.
        // Abstract Class içerisine hem metot tanımlayabilir, hem de interfacelerdeki gibi metot bildirimi yapabiliriz.
        // Abstract Class sadece kalıtım amaçlı kullanılır.
        public void Method1()
        { // Method1 inherit eden sınıflara doğrudan aktarılır.
            Console.WriteLine("I'am a method in a Abstract Class!");
        }

        public abstract void Method2(); 
        // Bildirimi yapılan Method2 ise inherit eden sınıf içerisinde tanımlanması, tamamlanması gerekir.
        // Metot bildirimi yapmak için erişim belirtecinden sonra "abstract" sözcüğü yazılmak zorundadır.
        // Abstrac Sınıfları, Interface gibi kullanabiliriz.
    }
    class InheritedClass : BaseClass
    { //Implement Abstract Class
        public override void Method2() //Bildirimi yapılmış metodu kullanmak için "override" keyword'ü kullanılır. 
        { // Temel sınıftan türetilen sınıf Method2'nin tanımlamasını, implement yapmak zorundadır.
            Console.WriteLine("I'm a method in a InheritedClass derived from Abstract Base Class.");
        }
    }
}
