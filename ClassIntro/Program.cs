using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Merve";
            int yasi = 28;

            Kurs kurs1 = new Kurs();// burayakurs yazabilmek için class tanımlamalıyız. Yani, sanki kendi veri tipimizi yazıyormuşuz gibi düşünülebilir
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();// burayakurs yazabilmek için class tanımlamalıyız. Yani, sanki kendi veri tipimizi yazıyormuşuz gibi düşünülebilir
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();// burayakurs yazabilmek için class tanımlamalıyız. Yani, sanki kendi veri tipimizi yazıyormuşuz gibi düşünülebilir
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();// burayakurs yazabilmek için class tanımlamalıyız. Yani, sanki kendi veri tipimizi yazıyormuşuz gibi düşünülebilir
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            // kurs değil de string yazar isek sadece string değerler tutabiliriz
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
            }

           // Console.WriteLine(kurslar[]);
        }
        }

    class Kurs
    {
        public string KursAdi  { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
