using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Serpil";
            musteri1.Soyad = "DONER";
            musteri1.Tckn = 1234567890;

            Console.WriteLine(musteri1);
        }

    
    
    }
}
