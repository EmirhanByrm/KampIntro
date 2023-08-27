using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void CustomerAdd(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" "+musteri.Id+" "+"Eklendi");
        }
        public void CustomerDelete(Musteri musteri) 
        { Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " " + "Silindi"); }  
        public void CustomerUpdate(Musteri musteri) 
        { Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " " + "Güncellendi"); }
    }
}
