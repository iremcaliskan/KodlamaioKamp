using System;

namespace Homework_SecondDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Parfume parfume1 = new Parfume();
            parfume1.brand = "Chanel";
            parfume1.name = "Coco Mademoiselle";
            parfume1.gender = "Woman";
            parfume1.price = 990.0;
            parfume1.size = "100 Ml";

            Parfume parfume2 = new Parfume();
            parfume2.brand = "Yves Saint Laurent ";
            parfume2.name = "Libre";
            parfume2.gender = "Woman";
            parfume2.price = 719.0;
            parfume2.size = "90 Ml";

            Parfume parfume3 = new Parfume();
            parfume3.brand = "Versace";
            parfume3.name = "Eros";
            parfume3.gender = "Man";
            parfume3.price = 239.0;
            parfume3.size = "100 Ml";

            Parfume[] parfumes = new Parfume[] { parfume1, parfume2, parfume3 };
            Console.WriteLine("---Foreach Döngüsü---");
            foreach (var parfume in parfumes)
            {
                Console.WriteLine(parfume.brand + " " + parfume.name + " " + parfume.gender + " " + parfume.price + " " + parfume.size);
            }

            Console.WriteLine("---For Döngüsü---");
            for (int i = 0; i < parfumes.Length; i++)
            {
                Console.WriteLine(parfumes[i].brand + " " + parfumes[i].name + " " + parfumes[i].gender + " " + parfumes[i].price + " " + parfumes[i].size);
            }

            Console.WriteLine("---While Döngüsü---");
            int a = 0;
            while (a < parfumes.Length)
            {
                Console.WriteLine(parfumes[a].brand + " " + parfumes[a].name + " " + parfumes[a].gender + " " + parfumes[a].price + " " + parfumes[a].size);
                a++;
            }
        }
    }

    class Parfume
    {
        public string brand { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double price { get; set; }
        public string size { get; set; }

    }
}