using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine("-----------------------");

            //array - Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu",
                "Programlamaya Başlangıç İçin Temel Kurs",
            "java","C++" };

            for (int i = 0; i < kurslar.Length; i++)  
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu- footer");
        }
    }
}
