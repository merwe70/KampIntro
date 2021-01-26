using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //miras inheritance ---müşteride olan özellikler gerçekte de tüzelde de vardır.

    class TuzelMusteri:Musteri   //buna miras yani inheritance diyoruz
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
