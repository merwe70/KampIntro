using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention metotlar da büyük harfle isimlendirilir
        //c# da bir yerde normal parantez varsa bu bir metottur
        //syntax -- yazım şekilleri
        // neyi eklemek istediğimizi metoda vermemiz lazım buna parametre veriyoruz
        // bir class ın içinde birden fazla metot olabilir
        public void Ekle(Urun urun )
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:" + urun.Adi);
          
        } 
        //metot olarak yazdığımız zaman sonradan eklediğimiz parametreleri bütün ekleyip, bu metodu kullandığımız sayfalarda 
        //eklemeliyiz. Class kullanmak daha doğru stok adedi eklersek diğer sayfalarda da değişiklk yapmaya gereek olmaz sayfa patlamaz

        //Ekle2 ayrı ayrı yzaıldığında bir class değil ama bunun tamamını içeren kolay yapıya CLASS deniyor.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:" + urunAdi);  
        }
    }
}
