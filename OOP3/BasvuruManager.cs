using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection---- yani burada kullanılacak metodun ne olacağını hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz 
        //hem veritabanına loglama hem de sms atma için birden fazla logger yolluyoruz onun için liste oluşturuyoruz
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService>loggerServices)//bu başvuruyu hangi krediye göre yapmam gerektiğini belirlememiz gerekiyor  
        {


            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); //biz böyle yapar isek tüm başvurular konut kredisi üzerinden hesaplanır.
            //yukardaki gibi yaparsak tüm başvuruyu konut kredisine bağımlı hale getiririz


            krediManager.Hesapla(); //şu an başvuruyu kredi bağımsız hale getirdik
            //Hangisinin hesaplası gönderiliyorsa o çalışıyor

             
            foreach (var loggerService in loggerServices) //her loglayıcıyı çalıştır diyoruz
            {

                loggerService.Log(); // hangi logger servis verilmişse onu logla diyoruz
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) //birden fazla kredinin hesabınıyapmak istiyorsak liste kullanırız tür olarak da IKrediManager istedik.------burda ön bilgilendirme birden çok kredinin hesabını yapmak için 
        {
            foreach (var kredi in krediler)  //kredilerdeki her bir kredinin bi operasyonunu yap
            {
                kredi.Hesapla(); //Listedeki her bir kredinin hesabını yap
            }
        }

        internal void BasvuruYap(EsnafKredisiManager esnafKredisiManager, SmsLoggerService smsLoggerService)
        {
            throw new NotImplementedException();
        }

        //internal void BasvuruYap(EsnafKredisiManager esnafKredisiManager, SmsLoggerService databaseLoggerService)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
