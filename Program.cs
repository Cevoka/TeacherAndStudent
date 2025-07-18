using System;

// Base sınıf - BaseKisi
public class BaseKisi
{
    // Propertyler
    public string Ad { get; set; }
    public string Soyad { get; set; }
    
    // Constructor
    public BaseKisi(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }
    
    // Konsol ekranına ad ve soyad yazdıran metot
    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

// Ogrenci sınıfı - BaseKisi'den miras alıyor
public class Ogrenci : BaseKisi
{
    // İlave property
    public int OgrenciNumarasi { get; set; }
    
    // Constructor
    public Ogrenci(string ad, string soyad, int ogrenciNumarasi) : base(ad, soyad)
    {
        OgrenciNumarasi = ogrenciNumarasi;
    }
    
    // Konsol ekranına öğrenci numarası, ad ve soyad yazdıran metot
    public override void BilgileriYazdir()
    {
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        // Base sınıfın metodunu çağırıyoruz
        base.BilgileriYazdir();
    }
}

// Ogretmen sınıfı - BaseKisi'den miras alıyor
public class Ogretmen : BaseKisi
{
    // İlave property
    public decimal MaasBilgisi { get; set; }
    
    // Constructor
    public Ogretmen(string ad, string soyad, decimal maasBilgisi) : base(ad, soyad)
    {
        MaasBilgisi = maasBilgisi;
    }
    
    // Konsol ekranına maaş bilgisi, ad ve soyad yazdıran metot
    public override void BilgileriYazdir()
    {
        Console.WriteLine($"Maaş Bilgisi: {MaasBilgisi:C}");
        // Base sınıfın metodunu çağırıyoruz
        base.BilgileriYazdir();
    }
}

// Ana program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== INHERITANCE (MİRAS ALMA) ÖRNEĞİ ===");
        Console.WriteLine();
        
        // Öğrenci nesnesi oluşturma
        Ogrenci ogrenci1 = new Ogrenci("Ahmet", "Yılmaz", 12345);
        
        // Öğretmen nesnesi oluşturma
        Ogretmen ogretmen1 = new Ogretmen("Fatma", "Kaya", 8500.50m);
        
        // Öğrenci bilgilerini yazdırma
        Console.WriteLine("--- ÖĞRENCİ BİLGİLERİ ---");
        ogrenci1.BilgileriYazdir();
        Console.WriteLine();
        
        // Öğretmen bilgilerini yazdırma
        Console.WriteLine("--- ÖĞRETMEN BİLGİLERİ ---");
        ogretmen1.BilgileriYazdir();
        Console.WriteLine();
        
        // Farklı bir örnek daha
        Console.WriteLine("--- BAŞKA ÖRNEKLER ---");
        
        Ogrenci ogrenci2 = new Ogrenci("Zeynep", "Demir", 67890);
        Ogretmen ogretmen2 = new Ogretmen("Mehmet", "Özkan", 9200.75m);
        
        Console.WriteLine("İkinci Öğrenci:");
        ogrenci2.BilgileriYazdir();
        Console.WriteLine();
        
        Console.WriteLine("İkinci Öğretmen:");
        ogretmen2.BilgileriYazdir();
        
        Console.WriteLine("\nProgram tamamlandı. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}