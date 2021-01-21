using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product 
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "kalem",
                UnitPrice = 35
            }; //bunları gerçek hayatta kullanıcıdan alıyoruz.
            //PascalCase //camelCase
            //case sensitive--küçük büyük harf duyarlı
            // referans tipleri heep te oluşabilmesi için newlemek gerekiyor.

            ProductManager productManager = new ProductManager();  // STRİNG İSİM DEİŞ GİBİ OLUYORUZ .------//PRODUCT1 VE PRODUCT 2 Yİ ALIP KULLANICIYA GÖNDERMEK GEREKİYOR
            productManager.Add(product1);   //Şu ürünü ekledim diyebilmek için parametre vermemiz gerekiyor
            Console.WriteLine(product1.ProductName); //değeri kamera oldu

            //productManager.Topla2(3, 6); //İŞLEM SONUCUNDA ORTAYA ÇIKAN SONUCU KULLANMAK İSTİYORUZ. METODU VOİD İLE YAPTIĞIMIZDA GİT YAP BİTİR DİYORUZ ORTAYA ÇIKAN DEĞERİ KULLANAMIYORUZ

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

            //Değer tiplerde atamalar tamamen değeri üzerinden olur ve bütün bağlantı kopar
            //ref out 
        }
    }
}
