using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself - Kendini tekrarlama
            //type safety - tip güvenliği
            //değer tutucu -> kategoriEtiketi ( alias ) 

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun==dolarBugun)
            {
                Console.WriteLine("Eşittir Butonu");
            }
            else
            {
                Console.WriteLine("Artış Butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            

        }
    }
}
