using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            Console.WriteLine("Kategoriler");
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}
