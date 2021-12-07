// See https://aka.ms/new-console-template for more information
// Ön atamalı Kurucu metotlar
/*
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

    } */

    // Encapsulation
    Console.WriteLine("**** Öğrenci 1 ****");
Ogrenci student1= new Ogrenci("Furkan","Cengiz",2357,1);
student1.Ogrenci_Yoklama();
Console.WriteLine("**** Öğrenci 2 ****");
Ogrenci student2= new Ogrenci();
student2.Ad="Erhan";
student2.Soyad="Erkut";
student2.OkulNumarasi=3434;
student2.Sinif=2;
student2.Ogrenci_Yoklama();
student2.Sınıf_Düsür();
Console.WriteLine(student2.Sinif);
student2.Sınıf_Düsür();
student1.Sınıf_Düsür();
class Ogrenci{

    private string ad;
    private string soyad;
    private int okulNumarasi;
    private int sinif;

    public string Ad { 
        get 
        {
        return ad;
        } //bu şekliyle de aynıdır
        set 
        {
            ad = value;
        } 
    }
    public string Soyad { get => soyad; set => soyad = value; }
    public int OkulNumarasi { get => okulNumarasi; set => okulNumarasi = value; } // 
    public int Sinif { 
        get => sinif; 
        set {
            if (value<1)    // bu şekilde şartlar koyarak property'mizi koruyabiliriz.
            {
                sinif=1;
                Console.WriteLine("Sınıf en az 1 olabilir. Sınıfın Değeri otomatikman 1 olarak ayarlandı.");
            }else
            {
                sinif = value;
            }
            
            }   
                   
         }

    private int sinif1;
    public Ogrenci(string ad, string soyad, int okulNumarasi, int sinif)
    {
        Ad = ad;
        Soyad = soyad;
        OkulNumarasi = okulNumarasi;
        Sinif = sinif;
    }
    public void Ogrenci_Yoklama(){
        Console.WriteLine("Öğrencinin Adı: {0}",this.Ad);
        Console.WriteLine("Öğrencinin Soyadı: {0}",this.Soyad);
        Console.WriteLine("Öğrencinin Okul Numarası: {0}",this.OkulNumarasi);
        Console.WriteLine("Öğrencinin Sınıfı: {0}",this.Sinif);
    }
    public Ogrenci(){

    }
    public void Sınıf_Atlat(){

        this.Sinif++;
    }
    public void Sınıf_Düsür(){

        this.Sinif--;
    }
}

