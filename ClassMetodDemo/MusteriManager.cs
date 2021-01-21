using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager 
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın "+ musteri.MusteriAdi+ " "+ musteri.MusteriSoyadi +";\nKaydınız Eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Değerli Müşterimiz" +
                ";\nBilgileriniz Şu Şekildedir : " +
                "\nAdınız Soyadınız : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +
                "\nAdresiniz : " + musteri.MusteriAdresi);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.MusteriAdi  + " " + musteri.MusteriSoyadi + ";\nSilme İşleminiz Başarılı");
        }


    }
}
