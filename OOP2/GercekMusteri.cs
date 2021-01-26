using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri:Musteri  // müşteri ebeveyn 
    {
        
        public string TcNo { get; set; } //bir veri üzerinde matematiksel işlem yapılmıyorsa, metinsel olarak yapılırsa bunlar daha iyi olur
        public string Adi { get; set; } // bir nesneye a
        public string Soyadi { get; set; }
    }
}
