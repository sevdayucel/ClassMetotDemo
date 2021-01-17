using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi", "/n", "Adı:" + musteri.MusteriAdi, "/n", "Soyadı:" + musteri.MusteriSoyad, "/n", "Cinsiyet:" + musteri.Cinsiyet);
        
        }
       
        public void MusteriListele(Musteri[] listeleme)
        {
            Console.WriteLine("Müşteri Listesi");

            foreach (var musteri in listeleme)
            {
                Console.WriteLine("Adı:" + musteri.MusteriAdi, "/n", "Soyadı:" + musteri.MusteriSoyad, "/n", "Cinsiyet:" + musteri.Cinsiyet);
            }

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "Adı:" + musteri.MusteriAdi, "Müşteri Bilgisi Silindi");

        }

    }
}
