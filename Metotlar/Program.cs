using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması"; ///3 ü beraber ürünün kendisi. Class bu üçünü beraber tutan yapıdır
            // string gibi dounble gibi o da bir veri tipidir aslında 
            // c# class tanımlarken ilk haff büyük yazılır pascal case.Bu bir yazım kuralı 

            string[] meyveler = new string[] { };

            
            Urun urun1 = new Urun();//Burada bir ürün oluşturduk aslında. class dan değişken tanımlayacağımızda new lememiz gerekiyor 
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması"; // bununların hepsi 1 ürünü ifade ediyor

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 }; //Array bir veri türünde istediğimiz kadar ne kadar data eklersek o datayı tutan yapı. Diziler çağul isimlendirilir içinde belirtilen tipte birden faazla data içeriyor

            //type-safe--tip güvenli 
            foreach (Urun urun in urunler) // gelen datayı tek tek ekrana basacak.urun takma isim. Urun veri tipi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("----------Metotlar-------------");

            //Instance - örnek
            //encapsulation --kapsülleme demek. Aslında ayrı ayrı yazılan ve düzensiz olan yapıyı, bir düzenin içine sokmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//metot bu şekilde çağrılıyor
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,2);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
          
        }
    }
}


//Dont repeat yourself ---DRY kendini tekrar etme.
//Clean code-Best Pratice(Doğru uygulama tekniği)
 
