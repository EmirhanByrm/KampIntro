using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Class nesne türetme*/
            product ürün1 = new product();
            ürün1.ProductName = "Xioami Mİ Wifi Sinyal Güçlendirici";
            ürün1.ProductRainting = 38076;
            ürün1.ProductPrice = 319.99;
            product ürün2=new product();
            ürün2.ProductName = "Apple İphone 14 Pro Max 256 GB Uzay Siyahı";
            ürün2.ProductRainting = 7;
            ürün2.ProductPrice = 62.879;
            product ürün3= new product();
            ürün3.ProductName = "Apple 2. Nesil Beyaz Bluetooth Kulaklık";
            ürün3.ProductRainting = 17520;
            ürün3.ProductPrice = 3499;
            product[] products = { ürün1, ürün2, ürün3 };
            /* Döngüler ile Classı listeleme*/
            Console.WriteLine("Foreach döngüsü --------------");
            foreach (var urunler in products) 
            { 
                Console.WriteLine("Ürün adi : "+urunler.ProductName);
                Console.WriteLine("Ürün değerlendirmesi : "+urunler.ProductRainting);
                Console.WriteLine("Ürün Fiyati : "+urunler.ProductPrice);
                Console.WriteLine("*****");
            }
            Console.WriteLine("For döngüsü --------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adi : " + products[i].ProductName);
                Console.WriteLine("Ürün değerlendirmesi : " + products[i].ProductRainting);
                Console.WriteLine("Ürün Fiyati : " + products[i].ProductPrice);
                Console.WriteLine("*****");
            }
            int deger = 0;
            Console.WriteLine("While döngüsü --------------");
            while (deger<products.Length)
            {
                Console.WriteLine("Ürün adi : " + products[0].ProductName);
                Console.WriteLine("Ürün değerlendirmesi : " + products[0].ProductRainting);
                Console.WriteLine("Ürün Fiyati : " + products[0].ProductPrice);
                Console.WriteLine("*****");
                deger++;
            }
        }
        class product
        {
            public string ProductName { get; set; }
            public int ProductRainting { get; set; }
            public double ProductPrice { get; set; }

        }
    }
}
