using System;

namespace Homework_ThirdDayPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = 49;

            if (grade == 50)
            { //Eşitse
                Console.WriteLine("Notunuz 50'dir.");
            }

            if (grade < 40)
            {
                Console.WriteLine("Geçerli notu alamadınız!");
            }
            else if (grade < 50)
            {
                Console.WriteLine("Koşullu Geçtiniz!");
            }
            else
            {
                Console.WriteLine("Geçerli notu aldınız, Tebrikler!");
            }

            //Single Line If
            Console.WriteLine(grade == 50 ? "Notunuz 50'dir." : "Notunuz 50 değildir.");
            // Notunuz elli ise burayı yap(true) : değilse burayı yap(false) demektir.
            // if-else if-else ve if-else bloklarında illaki biri çalışacaktır. Hiç bir durum karşılanmazsa else, sağlanırsa o koşulu belirten kısım çalışacaktır.

            var numberS = 16;
            // Switch Bloğu
            switch (numberS)
            {
                case 10: // sayı 10 ise
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                default: // Sayı hiçbiri değil ise
                    Console.WriteLine("Number not found!");
                    break;
            }

            var num1 = 201;
            if (num1 >= 0 && num1 <= 100)
            {
                Console.WriteLine("Number is between 0 and 100");
            }
            else if (num1 > 100 && num1 <= 200)
            {
                Console.WriteLine("Number is between 101 and 200");
            }
            else if (num1 > 200 || num1 < 0)
            {
                Console.WriteLine("Number is greater than 200 or less than 0");
            }

            var number = -1;

            if (number <= 100)
            {
                if (number >= 90)
                {
                    Console.WriteLine("Number is between 90 - 100");
                }
                else if (number >= 80 && number < 90)
                {
                    Console.WriteLine("Number is between 80 - 89");
                }
                else if (number >= 70 && number < 80)
                {
                    Console.WriteLine("Number is between 70 - 79");
                }
                else if (number >= 60 && number < 70)
                {
                    Console.WriteLine("Number is between 60 - 69");
                }
                else if (number >= 50 && number < 60)
                {
                    Console.WriteLine("Number is between 50 - 59");
                }
                else if (number >= 40 && number < 50)
                {
                    Console.WriteLine("Number is between 40 - 49");
                }
                else if (number >= 30 && number < 40)
                {
                    Console.WriteLine("Number is between 30 - 39");
                }
                else if (number >= 20 && number < 30)
                {
                    Console.WriteLine("Number is between 20 - 29");
                }
                else if (number >= 10 && number < 20)
                {
                    Console.WriteLine("Number is between 10 - 19");
                }
                else if (number >= 0 && number < 10)
                {
                    Console.WriteLine("Number is between 0 - 9");
                }
                else
                {
                    Console.WriteLine("Number is not in the range 0 and 100");
                }
            }
        }
    }
}
