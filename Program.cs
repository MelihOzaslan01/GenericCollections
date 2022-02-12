using System.Collections.Generic;
using System;


// List <T> class
// system.collections.generic
// t --> Nesne türündedir

List<int> sayiListesi = new List<int>();

sayiListesi.Add(102);
sayiListesi.Add(11);
sayiListesi.Add(26);
sayiListesi.Add(83);
sayiListesi.Add(154);
sayiListesi.Add(955);

List<string> renkListesi = new List<string>();

renkListesi.Add("Mavi");
renkListesi.Add("Kırmızı");
renkListesi.Add("Yeşil");
renkListesi.Add("Turkuaz");
renkListesi.Add("Turuncu");
renkListesi.Add("Gri");

//Count

Console.WriteLine("Sayı Listesi Eleman Sayısı :  " + sayiListesi.Count);
Console.WriteLine("Renk Listesi Eleman Sayısı :  " + renkListesi.Count);


// Foreach ve List Foreach İle Elemanlara Erişim
foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//Listeden Eleman Çıkarma 
sayiListesi.Remove(4);
renkListesi.Remove("Mavi");

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(2);


sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Liste içerisinde Arama

if (sayiListesi.Contains(11))
{
    Console.WriteLine("11 Liste İçerisinde Bulundu ! ");
}
else
{
    Console.WriteLine("Liste İçerisinde Bulunamadı !");

}

// Eleman İle İndex'e Erişme 

Console.WriteLine(renkListesi.BinarySearch("Gri"));

// Diziyi List'e Çevirme 

string[] hayvanlar = { "Kedi", "Köpek", "Balık" };
List<string> hayvanListesi = new List<string>(hayvanlar);
hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));


// Listeyi Nasıl Temizleriz
hayvanListesi.Clear();


// Liste İçerisinde Nesne Tutmak 
List<Kullanicilar> kullanıcıListesi=new List<Kullanicilar>();
Kullanicilar kullanıcı1 = new Kullanicilar();
kullanıcı1.Isim = "Ali";
kullanıcı1.Soyisim = "Karabıyık";
kullanıcı1.Yas = 29;

Kullanicilar kullanıcı2 = new Kullanicilar();
kullanıcı2.Isim = "Selin";
kullanıcı2.Soyisim = "Doğan";
kullanıcı2.Yas = 27;

kullanıcıListesi.Add(kullanıcı1);
kullanıcıListesi.Add(kullanıcı2);

List<Kullanicilar>yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar()
{
    Isim = "Ayşe",
    Soyisim="Deli",
    Yas = 30


});

foreach (var kullanıcı in kullanıcıListesi)
{
    Console.WriteLine("Kullanıcı Adı : " + kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yaşı : " + kullanıcı.Yas);
}


yeniListe.Clear();




public class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int  Yas { get => yas; set => yas = value; }
}



