using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Doğu";
            kurs1.IzlenmeOrani= 3542419;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Miraç";
            kurs2.IzlenmeOrani = 343;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ahmet";
            kurs3.IzlenmeOrani = 419;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Tolunay";
            kurs4.IzlenmeOrani = 1;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı: "+kurs.KursAdi);
                Console.WriteLine("Kurs Eğitmeni: "+kurs.Egitmen);
                Console.WriteLine("Kurs İzlenmesi: "+kurs.IzlenmeOrani);
                Console.WriteLine("------------------------");
            }
           
        }


        class Kurs
        {
            public string KursAdi { get; set; }//Java
            public string Egitmen { get; set; }//Doğu
            public int IzlenmeOrani { get; set; }//3.542.419
        } 
    }
}
