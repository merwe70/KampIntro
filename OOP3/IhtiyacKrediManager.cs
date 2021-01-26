using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager  // eğer bir sınıf bir interface i böyle kullanıyorsa. Her kredi mutlaka bu interface deki metotları içermek zorunda 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

    }
}
