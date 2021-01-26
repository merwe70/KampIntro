using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
        //Bu demek oluyor ki birisi bu interface i kullanırsa hesapla metodu içermek zorunda  
        // okunulurluğu artırmak için interfaceleri I harfi ile başlatırız bunun interface olduğunu anlarız
        //Birisi bu interface kullanırsa o arkadaş bu metotları kullanmak zorunda
        //sırf bizim için referans tutsun diye ve aynı zamanda tüm kredi tiplerinin uygulaması zorunlu halde olması istenen operasyonları tutsun diye biz bu INTERFACE oluşturuyoruz.
        //Biz bi interface oluşturduğumuzda o interface nin içindeki o operasyonlar alternatif sistemler için bir şablon ve buna ek olarak referans tutucu görevi görüyor.
        //INTERFACE İ BİRBİRİNİN ALTERNATİFİ OLAN AMA KOD İÇERİKLERİ FARKLI OLAN DURUMLAR İÇİN KULLANIRIZ. 
    {
        void Hesapla(); // imzanın aynı olduğu içerisinin farklı olduğu durumdalarda biz base de oluştuğumuz class ı interface olarak oluştururuz
        void BiseyYap();
        
           
        
    }
}
 