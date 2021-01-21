using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //burdaki t tipi ne yazılırsa o olsun demek
    {
        T[] items; //metodun dışında yazıyoruz.Class ın bütün elemanları erişebilir böyle. Bunu class ı new lediğimizde oluşturmamız gerekiyor
        //constructor(aslında metot) biz bu class ı bi yerde new lersek public MyList otomatik olarak çalışıyor ve buna constructor deniyor
        public MyList()  //constructor class ile aynı isim olur. 
        {
            items = new T[0];
        }

        public void Add(T item) //item eleman demek . T hangi tipte çalışıyorsak onu ekliyoruz demek
        {
            T[] tempArray = items; //geçici dizi nin referansı items in referansı.-----Referans atamamızın sebebi diziyi new lwdiğimizde var olan elemanların uçmaması(önceki değerlerin korunması)
            items = new T[items.Length+1]; //mevcutta eleman sayın kaçsa 1 artır diyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //items in i inci elemanı tempArray den gelen i inci elemandır.Yani emaneten verdiğimiz değerleri sırasıyla kendi üzerimize yeniden alıyoruz.Burada items eski değerlerine kavuştu.
            }

            items[items.Length - 1] = item; //aslında eklenmek istenen elemanı şu an ekledik.

        }
        
    }
}
