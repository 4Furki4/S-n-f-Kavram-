using System;

namespace ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int sıcaklık=24;

            if (sıcaklık>=(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Bugün dışarı çıkma yoksa çok terlersin!");
            }
            else if (sıcaklık>=(int)HavaDurumu.AşırıSıcak)
            {
                Console.WriteLine("Kendini buzdolabına sokmalısın!");
            }
            else if (sıcaklık<(int)HavaDurumu.Sıcak && sıcaklık>=(int)HavaDurumu.Ilık)
            {
                Console.WriteLine("Bugün kendimi sokaklara atacağım!!!!");
            }
        }
    }
    enum HavaDurumu 
    {
        CokSoğuk=0,
        Soğuk=10,
        Ilık=20,
        Sıcak=25,
        CokSıcak=30,
        AşırıSıcak=40


    }
}
