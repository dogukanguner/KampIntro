using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)//Böylesi Bir Methot daha faydalı
            /*Diyelim stok adedide eklenmesi gerek stok adedi 
            ekleyince Ekle2 Methodundaki kodlar patlar. Ekle1 yani bu 
            metotdaki kodlar patlamaz. Buna ( ENCAPSULATİON ) denir*/
        {

            int sayaç = 0;
            urun.StokAdedi = urun.StokAdedi - 1;
            sayaç = sayaç + 1;
            if (urun.StokAdedi < 0)
            {
                Console.WriteLine(sayaç+".Ürün sepete eklenemedi.Yetersiz stok");
               
            }
            else
            {
                Console.WriteLine("Sepete Eklendi : " + urun.Adi);
                Console.WriteLine("Stok adedi: " + urun.StokAdedi);
            }
        }

        public void Ekle2(string urunAdı,double fiyati,string aciklama)
        {
            Console.WriteLine();
        }
        public void Topla(Urun urun1,Urun urun2,Urun urun3)
        {
           double Toplama = urun1.Fiyati + urun2.Fiyati + urun3.Fiyati;
            Console.WriteLine("Sepet Toplamı : "+urun1.Adi+" : "+urun1.Fiyati+" , "+urun2.Adi+" : "+urun2.Fiyati +" , "+urun3.Adi+" : "+urun3.Fiyati+" = " + Toplama);
        }
    }
}
