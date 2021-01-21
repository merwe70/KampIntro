using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" }; // ARRAY LERİ BİZ OLUŞTURDUĞUMUZDA, O SINIRLARDA TAKILIR BU SINIRLARIN DIŞINA ÇIKARAMAYIZ.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////isimler[4] = "ilker";  //YUKARIDA ELEMAN SAYISI 3 BİZ YENİ ELEMAN EKLEMEYE ÇALIŞTIĞIMIZ İÇİN HATA VERİYOR.
            //// Console.WriteLine(isimler[4 ]); //DİZİLERİ GENİŞLETEMİYORUZ, GENİŞLETİRSEK DEĞERİ KAYBEDİYORUZ.
            //// Bir dizide ancak olanla çalışabiliriz.
            ////Array lerde sabitlik var tanımlıyoruz artıramıyoruz sonra 

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// bomboş bir array atadık biz o yüzden boş dönüyor


            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");          //yeni eleman ekleme add ile olur
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //Koleksiyonlarda arrayler gibi değerleri kaybetmemizi engelleyecek bir alt yapı var
            
        }
    }
}
