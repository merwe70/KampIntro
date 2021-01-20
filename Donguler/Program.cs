using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Döngüler bir şeyleri tekrar etmek için kullanılan yapılardır
            ///c# da blok kavramı var. ++ demek 1 1 artır demek 
            ///i=i+2 şeklinde yazılabilir. 2 2 artır demek
            ///i+=2 şeklinde de yazılabilir 2 2 artır demek
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampüsü";
            string kurs2 = "Programlamaya başlangıç için temel kurs ";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //array-dizi

            //gerçek hayatta array leri yani listeleri bir veri kaynağından getiriyoruz 
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampüsü", 
                "Programlamaya başlangıç için temel kurs ","Java","Python","C#" };

            //döngüyü dinamize etmek için her defasında kaça kadar olacağını belirlemek yerine kurslar.lenght dedik
            for (int i = 0; i <kurslar.Length; i++) ///1 den başla 10 dan küçük olduğu sürece çalış 1 er 1 er artır
                
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //forech dizi temelli yapıları tek tek dolaşmaya yarıyor
            //buradaki kurs alias xyz desek de çalışır
            //forech i dizileri kolay dolaşmak için kullanırız
            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
