using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Emirhan Bayram";
            kurs1.KursAdi="C#";
            kurs1.İzlenmeOrani = 1500;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Emircan Yılmaz";
            kurs2.KursAdi = "Angular";
            kurs2.İzlenmeOrani = 1200;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Emirhan Çağman";
            kurs3.KursAdi = "Visual Basic";
            kurs3.İzlenmeOrani = 1250;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
