using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Berkay";
            int yas = 18;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmeni = "Berkay Tüylü";
            kurs1.İzlenmeOranı = 36;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Python";
            kurs2.Eğitmeni = "Ahmet Mum";
            kurs2.İzlenmeOranı = 54;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Java";
            kurs3.Eğitmeni = "Kamil Mert";
            kurs3.İzlenmeOranı = 85;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Eğitmeni);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmeni);
            }



        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmeni { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}