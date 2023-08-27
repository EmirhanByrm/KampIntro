using System;

namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama="Amasya Elması";
            urun1.Fiyati = 15;
            urun1.stokadeti = 30;
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 80;
            urun2.stokadeti = 30;
            Urun[] urunler=new Urun[] {urun1,urun2};   
            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.stokadeti);
                Console.WriteLine("***************************");
            }
            Console.WriteLine("********************************");
            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil Armut",12,5);
            sepetManager.Ekle2("Elma", "Yeşil s", 12,6);
            sepetManager.Ekle2("Karpuz", "Yeşil q", 12,7);
        }
    }
}
