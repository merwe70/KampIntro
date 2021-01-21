using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;         //sayi1, sayi2 yi kopyaladı ve irtibatını kopardı. O yüzden sayi1 65 olmadı
            //sayi1 kaç ?? --30 sayi1 30 da kalıyor


            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100,200,300 };
            sayilar1 = sayilar2;      //ikisi de referans tip olduğu için adres kopyalaması yapar
            sayilar2[0]=999;
            //sayilar1[0] elemanı kaç ?? -- 999 
            //new dediğimiz anda heapte bir alan oluştur oraya yaz demek. Stack ve heap bağlantısı şöyle kuruluyor; heap te stack in bi adresi var, birbirine karşılık geliyor. Yani new bellekten bir tane adres(yer) oluştur demek   
            // İNT DE OLSA ARRAY LER REFERANS TİPTİR
            //sayısal veri tipleri; int,decimal,float,double,bool(0 ve 1 döndürüyor) bunlar DEĞER TİP. (Değer tip değeri kopyalıyor ve işi bitiyor) 
            // ARRAY, CLASS,İNTERFACE =REFERANS TİPTİR

            // Sonuçlarının farklı olmasının sebebi; değer tip olanlar stack. 
            //değer tiplerde değer atanıyor, referans tiplerde adres atanıyor.

            
        }
    }
}
