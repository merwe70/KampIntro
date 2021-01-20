using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Topla(2,3) sayi1 e karşılık gelen 2 sayi2 ye karşılık gelen3
        public void Topla(int sayi1,int sayi2)// parametre fonksiyonu kullanabilmek(metodu çağırabilmek için) için ona 2 tane sayıya vermen gereken demek
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç:" + toplam);
        }
    }
}
