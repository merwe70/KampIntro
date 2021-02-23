using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {//birbirine benziyor diye birbirinin yerine kullanılamaz
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222245";
            //musteri1.MusteriNo = "123456";
            //musteri1.SirketAdi = "?";

            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1; 
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";
            


            //gerçek müşteri-tüzel müşteri
            //SOLID


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri(); // new görürsek referans numarası gelecek aklımıza
            Musteri musteri4 = new TuzelMusteri(); // Musteri gerçek ve tüzeli tutabiliyor.


            MusteriManager musteriManager = new MusteriManager();  //instance oluşturmak
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
