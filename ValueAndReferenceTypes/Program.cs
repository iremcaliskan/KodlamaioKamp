using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Yazılımcı için en önemli kısımlardan biri
            int num1 = 10;
            int num2 = 30;

            num1 = num2; // num1'in değeri num2'nin değerine eşittir.
            num2 = 65;
            // num1 ? 

            // num1 = 10, num2=30
            // num1 = num2
            // num1 = X10X 30, num2 =30
            // num1 = 30, num2 = X30X 65
            // num1 = 30, num2 =65
            // num1 30 olur.
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            int[] nums1 = new int[] { 10, 20, 30 }; // referans tip
            int[] nums2 = new int[] { 100, 200, 300 };
            nums1 = nums2; // num1'in referans numarası num2'nin referan numarasına eşittir.
            nums2[0] = 999;
            // nums1[0] ?

            // nums1 ------------------- 10 20 30 0.adress(Öylesine bir adress)
            // nums2 ------------------- 100 200 300 1.adress(Öylesine bir adress)
            // nums1 = nums2
            // nums1 \                   0.adress öylece kalır!! Garbage Collector tarafından silinir.
            // nums2 ------------------- 100 200 300 1.adress
            // Her ikiside 1.addrese sahip olur.
            // nums2[0] = 999 olursa değer değiştirilir, Sonuç 999, 200, 300 olur.
            // nums1 diziside aynı adrese sahip listeyi aldığı için 0. elemanı 999 olur.
            Console.WriteLine(nums1[0]);

            // int, decimal, float, double, boolean :: değer tip -- stack
            // array, class, interface, class :: referans tip -- stack + heap
        }
    }
}
