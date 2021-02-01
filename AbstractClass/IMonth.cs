using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Month
    {
        public int HowManyHoursAreDays()
        {
            return 24;
        } // Böylece 12 ay için aynı metodu 12 defa yazmak yerine, bir defa yazmış olduk.
        // Eğer bir metot tüm türetilmiş sınıflarda aynı şekilde tanımlanıyorsa o metodu 
        // abstract sınıf içerisinde standart bir metot tanımlar gibi tanımlarız.

        public virtual int HowManyDays()
        {
            return 31;
        } // Bu metot Ocak, Mart, Mayıs, Temmuz, Ağustos, Ekim ve Aralık ayları için aynı sonucu (31) 
        // döndürmesi gerektiğinden, en azından bu aylar için tekrardan HowManyDays() metodunun tanımını
        // yapmamak adına varsayılan olarak geriye 31 döndüren ancak istenilen sınıf içerisinde override
        // edilerek yeniden tanımlanabilecek şekilde kullanılabilmesi için "virtual" olarak tanımladık.

        /* Eğer bir metot bir çok türetilmiş sınıfta aynı şekilde tanımlanıyor iken sadece bir kaçında 
         * değişik şekilde tanımlanıyorsa o metot abstract sınıf içerisinde virtual olarak tanımlanır.
         */

        public abstract int WhatMonthOfYear();

        /* Eğer bir metot tüm türetilmiş sınıflarda farklı şekilde tanımlanıyorsa o metodun 
         * abstract sınıf içerisinde sadece bildirimi yapılır.
         */

    }

    interface IMonthDemo
    {
        int HowManyHoursAreDays(); // Her ay için ortak
        int HowManyDays(); // Her ay için değişir
        int WhatMonthOfYear(); // Her ay için değişir

        // Ortak bir metot bulunduğu anda Interface değilde, Abstract Sınıf kullanılması gerektiğini anlarız.

    }
}
