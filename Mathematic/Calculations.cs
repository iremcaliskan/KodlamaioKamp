using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematic
{
    class Calculations
    {
        public void Add(double num1, double num2) // Bu metodu kullanman için iki sayı vermen gerekli! - void
        {
            double sum = num1 + num2;
            Console.WriteLine("Toplam: {0}", sum);
            // Console.WriteLine("Toplam: {0}" + sum); Otomatik str'ye çeviriyor.
        }
        public void Subtraction(double num1, double num2)
        {
            double sub = num1 - num2;
            Console.WriteLine("Fark(Kalan): {0}", sub);

        }
        public void Multiplication(double num1, double num2)
        {
            double mul = num1 * num2;
            Console.WriteLine("Çarpım: {0}", mul);
        }
        public void Division(double num1, double num2)
        {
            double div = num1 / num2;
            Console.WriteLine("Bölüm: {0}", div);
        }
    }
}
