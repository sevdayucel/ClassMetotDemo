using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new  Musteri();
            musteri1.Id = 1903;
            musteri1.MusteriAdi = " Sevda ";
            musteri1.MusteriSoyad = " Yücel ";
            musteri1.Cinsiyet = "K";

            Musteri musteri2 = new  Musteri();
            musteri1.Id = 59;
            musteri1.MusteriAdi = " Mete ";
            musteri1.MusteriSoyad = " Yüksel ";
            musteri1.Cinsiyet = "E";

            Musteri musteri3 = new  Musteri();
            musteri1.Id = 195;
            musteri1.MusteriAdi = " Leyla ";
            musteri1.MusteriSoyad = " Güzel ";
            musteri1.Cinsiyet = "K";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriMananger = new MusteriManager();

            musteriMananger.MusteriEkle(musteri1);
            musteriMananger.MusteriEkle(musteri2);
            musteriMananger.MusteriEkle(musteri3);
           
            musteriMananger.MusteriSil(musteri2);
        }
    }
}
