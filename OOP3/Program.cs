using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu şubedeki arkadaşın ekranı(ekrandaki açılır kutu)
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //interface ler de o interface i infleme eden class ın referans numarasını tutabiliyor
            //IKrediManager desek de çalışır IhtiyacKrediManager desek de çalışır.

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); //ÖNEMLİ ------------//yeni bir instance oluşturup sisteme esnafı dahil ettik
               //interface ler new lenemez
              //  new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() } ); //ALTERNATİFİ BU   loggers in yaptığını yapıyor bu da 
            //

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager }; //listeden hem ihtiyaç hem de taşıt seçti

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            // SİSTEME YENİ BİR ÖZELLİK EKLENDİĞİNDE MEVCUT KODLAR BOZULMAZ


            //İNTERFACE REFERANS TUTUCU
        }
    }
}
