using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun// nasıl int de tam sayı tutuyorsak string de metin tutuyorsak class larda da birden fazla eleman tutulabilir     
    {
        // nesneyi tanımlayan birden fazla bilgi varsa içerisinde istediğimiz özellikler barındıran yapı 
        //property - özellik(her biri özellik id ad fiyat açıklama vs )
        // manager bir operasyon tutuyor demek
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
