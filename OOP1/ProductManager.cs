using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ürünle ilgili operasyonlar olur bunun içinde. Ekleme, silme, güncelleme, listeleme, arama, filtreleme vs. içerir 
    {
        //encapsulation
        public void Add(Product product) //string ad demek gibi-----bana bir tane ürün ver diyoruz yani. --------- parametre metodumuzun nasıl çağırılacağını anlattığı yer ----------- Product ın içine yazdığımız publicleri burada Product ı çağırarak kullanabiliyoruz. metotta tek tek yazmak yerine Product yazıp kullanıyoruz
        {
            Console.WriteLine(product.ProductName+"eklendi.");
        }


        //void ne işe yarıyor? // eklesin bitsin ekleme sonucuda bir şey döndürülmesini istemiyoruz.Emir kipi git şunu yap
        public void Update(Product product) //Güncelleme
        {
            Console.WriteLine(product.ProductName+"güncellendi.");
        }

        //public int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2); //ortaya çıkan toplamı kullanamıyoruz void de.Başka bir metotta sonucu kullanmamıza izin vermiyor. Void emir kipi; git yap 
        
    }
}
