using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();


            TuzelMusteri musteri1 = new TuzelMusteri();
            GercekMusteri musteri2 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "101";
            musteri1.SirketAdi = "Tesla";
            musteri1.VergiNo = "10001";

            musteri2.Id = 2;
            musteri2.MusteriNo = "102";
            musteri2.Adi = "Elon";
            musteri2.Soyadi = "Musk";
            musteri2.TcNo = "11111111111";
            

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
