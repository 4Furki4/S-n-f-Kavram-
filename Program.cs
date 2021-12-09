using System;

namespace Struct_Yapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktörtgen class_diktörtgen=new Diktörtgen();

        }
    }


    class Diktörtgen{

        public int Kısa_Kenar;
        public int Uzun_Kenar;
        public int AlanHesapla(){

            return Kısa_Kenar*Uzun_Kenar;
        }
        public Diktörtgen()
        {
            Kısa_Kenar = 4;
            Uzun_Kenar = 3;
        }

    }

    struct Diktörtgen_Struct{

        public int Kısa_Kenar;
        public int Uzun_Kenar;
        public int AlanHesapla(){

            return Kısa_Kenar*Uzun_Kenar;
        }
        //public Diktörtgen()
        //{                         Struct Yapılarda classlardaki gibi parametresiz kurucu metotlar kuramazsın.
        //    Kısa_Kenar = 4;
        //    Uzun_Kenar = 3;
        //}


    }
}
