using System;

namespace Metotlar//Tekrar tekrar kulanılma ortamı sağlar
{
    class Program
    {
        static void Main(string[] args)
            //Clean Code -> Temiz kod demek
            //Best Practice -> Doğru uygulama teknikleri
            //Dont Repeat Yourself -> Kendini tekrarlama DRY
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string urunAdi2 = "Kayısı";
            double fiyat2 = 44;
            string aciklama2 = "Malatya Kayısı sı";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasa Elması";
            urun1.StokAdedi = 2;
            

            Urun urun2 = new Urun();
            urun2.Adi = "Kayısı";
            urun2.Fiyati = 44;
            urun2.Aciklama = "Malatya Kayısı'sı";
            urun2.StokAdedi = 19;

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 44;
            urun3.Aciklama = "Armut Gibi Armut";
            urun3.StokAdedi = 12;

            Urun[] urunler = new Urun[] { urun1, urun2,urun3 };
            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("--------------------------\n");
            }
            Console.WriteLine("----------Metotlar---------");
            
            SepetManager sepetManager1 = new SepetManager();
            sepetManager1.Ekle(urun1);
            sepetManager1.Ekle(urun1);
            sepetManager1.Ekle(urun1);
           
            /* sepetManager1.Ekle(urun2);
            sepetManager1.Ekle(urun3);
            */
            
            sepetManager1.Topla(urun1,urun2);

            

            
        }
    }
}
