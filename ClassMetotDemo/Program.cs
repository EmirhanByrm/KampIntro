using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri user = new Musteri();
            user.Ad = "Emirhan";
            user.Soyad = "Bayram";
            user.Id = 1;
            Musteri user2 = new Musteri();
            user2.Ad = "Aslı";
            user2.Soyad = "Deniz";
            user2.Id = 2;
            Musteri user3 = new Musteri();
            user3.Ad = "Hakan";
            user3.Soyad = "Pak";
            user3.Id = 3;

            Musteri[] users = new Musteri[] { user, user2, user3 };
            foreach (Musteri info in users)
            {
                Console.WriteLine(info.Ad);
                Console.WriteLine(info.Soyad);
                Console.WriteLine(info.Id);
            }

            MusteriManager method = new MusteriManager();
            /*ADD*/
            method.CustomerAdd(user);
            method.CustomerAdd(user2);
            method.CustomerAdd(user3);
            /*UPDATE*/
            method.CustomerUpdate(user);
            method.CustomerUpdate(user2);
            method.CustomerUpdate(user3);
            /*DELETE*/
            method.CustomerDelete(user);
            method.CustomerDelete(user2);
            method.CustomerDelete(user3);
            

        }
    }
}
