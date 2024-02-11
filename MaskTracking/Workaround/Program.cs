using Business.Concrete;
using Entities.Concrete;
public class Program
{
    public static void Main(string[] args)
    {
        // Degiskenler();
        SelamVer("Engin");
        SelamVer();
        int sonuc = Topla(50);
        //Diziler /Arrays

        string ogrenci1 = "Engin";
        string ogrenci2 = "Muzaffer";
        string ogrenci3 = "Ahmet";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Muzaffer";
        ogrenciler[2] = "Ahmet";

        ogrenciler = new string[4];
        ogrenciler[3] = "Sefa";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Amasya", "Ankara", "İstanbul" };
        string[] sehirler2 = new[] { "Ankara", "Bursa","Gazi Antep" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Samsun";
        Console.WriteLine(sehirler2[0]);

        Person person1 = new Person();
        person1.FirstName = "Muzaffer";
        person1.LastName = "Bolat";
        person1.NationalIdentity = 123;
        person1.DateOfBirthYear = 1985;

        Person person2 = new Person();
        person2.FirstName = "Ahmet";

        foreach (var sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }
        List<string> yeniSehirler1 = new List<string>() { "Amasya 1", "Ankara 1","İstanbul 1" };
        yeniSehirler1.Add("Samsun 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }
    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    static int Topla(int sayi1, int sayi2 = 5)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + sonuc.ToString());
        return sonuc;
    }
    private static void Degiskenler()
    {
        string mesaj = "Selam";
        double tutar = 100000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Muzaffer";
        string soyad = "Bolat";
        int dogumYili = 1990;
        long tcNo = 12345678910;

        Console.WriteLine(mesaj);
        Console.WriteLine(mesaj);
    }
}
