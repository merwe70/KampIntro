using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet(hazır kodlar demek)
    class Product //ürün demek.Bu class larda sadece özellik olur
    {
        public int Id { get; set; } // ana anahtar bu. PK
        public int CategoryId { get; set; } // FK 2 sıraya yazılması daha doğru kodun okunulurluğu için
        public string ProductName { get; set; } //ürün adı
        public double UnitPrice { get; set; } //fiyatı demek
        public int UnitsInStock { get; set; } //stok adedi

        //E ticaret sisteminde ürünü listeliyoruz, arıyoruz, ekliyoruz, güncelliyoruz, yeni ürün ekliyoruz
        //CRUD------ Create(eklemek)    Read(okumak)     Updade(güncellemek)   Delete(silmek)


    }
}
