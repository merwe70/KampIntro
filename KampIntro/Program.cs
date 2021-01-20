using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ///type safety- tip güvenliği demek c# da değişkenin veri türünü belirtmemiz gerekiyor
             ///Do not repeat yourself-Kendini tekrarlama
           /// kategorietiketi bir değer tutucu,alias 
           /// 
            string kategoriEtiketi = "Kategoriler";
            int ogrensiSayisi = 32000;
            double faizOrani = 1.45;
            /// gerçek hayatta bool değer karşılığı bir veri kaynağından gelir. Bir fonksiyon çalışır mesela
            bool sistemeGirisYapmisMi = false;
            double DolarDun = 7.35;
            double dolarBugün = 7.45;

            if (DolarDun > dolarBugün) 
            {
                Console.WriteLine("Azalış butonu göster");

            }
            else if (DolarDun<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");  
            }
             


            /// if yazıp süslü yarantez açıyoruz. Şart geçerliyse şu blok çalışsın demek
            /// 
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);




        }
    }
}
 