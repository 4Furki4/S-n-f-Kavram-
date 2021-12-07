// See https://aka.ms/new-console-template for more information
// Ön atamalı Kurucu metotlar
Console.WriteLine("**** Çalışan 1 ****");
Calisanlar calisan1= new Calisanlar("Furkan","Cengiz",4444,"Doğa Bilimleri");
calisan1.CalisanAdini_Yazma();
Console.WriteLine("**** Çalışan 2 ****");
Calisanlar calisan2= new Calisanlar();
calisan2.Ad="Esat";
calisan2.Soyad="Cengiz";
calisan2.No=555368;
calisan2.Departman="Sinyal ve Sinyalizasyon";
calisan2.CalisanAdini_Yazma();
Console.WriteLine("**** Çalışan 3 ****");
Calisanlar calisan3= new Calisanlar("Sinan", "Canan");
calisan3.CalisanAdini_Yazma(); // no ve departman atamadığımız için 0 ve null çıktılarını alıyoruz.


class Calisanlar
{
    public Calisanlar(string ad, string soyad, int no, string departman){
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;

    }
    public Calisanlar(){} // Overloaded Empty Constructor Method
    public Calisanlar(string ad, string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;
    }
public string Ad;
public string Soyad;

public int No;

public string Departman;

public void CalisanAdini_Yazma()
{
    Console.WriteLine("Çalışanın Adı: {0}",Ad);
    Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
    Console.WriteLine("Çalışanın Numarası: {0}",No);
    Console.WriteLine("Çalışanın Departmanı: {0}",Departman);
}

    } 
