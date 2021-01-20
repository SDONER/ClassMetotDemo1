using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    
    class MusteriManager
    {
        public static void Add(Musteri M)
        {
            Console.WriteLine(M.Ad + "  musteri ekleme işlemi gerçekleşti!");
        }
        public static void Delete(Musteri M)
        {
            Console.WriteLine(M.Soyad + "musteri silme işlemi gerçekleşti!");
        }
    }
}
