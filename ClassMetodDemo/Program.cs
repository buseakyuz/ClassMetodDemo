using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
           
            musteri1.MusteriAdi = "Buse";
            musteri1.MusteriSoyadi = "Akyüz";
            musteri1.MusteriAdresi = "Ankara";
            musteri1.MusteriId = 1;
            musteri1.MusteriKartNo = 1111;

            musteri2.MusteriAdi = "Alper";
            musteri2.MusteriSoyadi = "Akyüz";
            musteri2.MusteriAdresi = "LosAngaras";
            musteri2.MusteriId = 2;
            musteri2.MusteriKartNo = 2222;

            musteri3.MusteriAdi = "Büşra";
            musteri3.MusteriSoyadi = "Akyüz";
            musteri3.MusteriAdresi = "İstanbul";
            musteri3.MusteriId = 3;
            musteri3.MusteriKartNo = 3333;
             
            //Ekleme ve Listeleme
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("----------------------------------");
            musteriManager.Listele(musteri1);
            Console.WriteLine("----------------------------------");

            musteriManager.Ekle(musteri2);
            Console.WriteLine("----------------------------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("----------------------------------");

            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------------------------");
            musteriManager.Listele(musteri3);
            Console.WriteLine("----------------------------------");
            //Silme 
            musteriManager.Sil(musteri3);




        }
    }
}
