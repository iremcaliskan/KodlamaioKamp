using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken 1
            // Class değişkenini oluşturmak ve değerlerini atamak için yapılacak işlemler:
            Course course1 = new Course(); // Değişken olarak obje tanımlama!
            course1.courseName = "C#";
            course1.courseLecture = "Engin Demiroğ";
            course1.watchRate = 86; //Yüzde 86 izlemiş gibi

            // Değişken 2
            Course course2 = new Course(); // Değişken olarak obje tanımlama!
            course2.courseName = "Python";
            course2.courseLecture = "Sadık Turan";
            course2.watchRate = 26;

            // Değişken 3
            Course course3 = new Course(); // Değişken olarak obje tanımlama!
            course3.courseName = "Java";
            course3.courseLecture = "Özgür Özşen";
            course3.watchRate = 72;

            //Console.WriteLine(course1.courseName + ": " + course1.courseLecture);
            //Console.WriteLine(course2.courseName + ": " + course2.courseLecture);
            //Console.WriteLine(course3.courseName + ": " + course3.courseLecture);
            // Dinamik listeleme için

            // İçerisinde Kurs değişkenlerini tutan Kurs Arrayı oluşturma:
            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            { // courses isimli arrayin her bir elemanının yani objesinin yani değişkeninin istenilen özelliklerini döner
                Console.WriteLine(course.courseName + ": " + course.courseLecture);
            }

            // Yeni bir kurs eklemek için Kurs sınıfının değişkenini yani objesini oluştur.
            // Ve özelliklerini tanımla.

            Console.WriteLine("[1-10] arasında sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            string result = sayi % 2 == 0 ? "Çift" : "Tek";
            Console.WriteLine(result);
        }
    }

    class Course
    { // Class objesinde classa ait tüm verileri tutarız
        public string courseName { get; set; } // prop ile şablon alınır.
        public string courseLecture { get; set; }
        public double watchRate { get; set; }
    }
}