using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla() //Bunları her class kendine göre doldurmak durumunda
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
