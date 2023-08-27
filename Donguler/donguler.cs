using System;
using System.Linq;

namespace Donguler
{
    internal class donguler
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] 
            {
            "Emirhan","Emircan","Çağman"
            };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].ToString());
            }
            Console.WriteLine("*******");
            foreach (string s in kurslar) {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
