public struct Kitap
{
    public string Adi;
    public string Yazar;
    public int SayfaSayisi;
    public string Turu;

    public Kitap(string adi, string yazar, int sayfaSayisi, string turu)
    {
        Adi = adi;
        Yazar = yazar;
        SayfaSayisi = sayfaSayisi;
        Turu = turu;
    }
}

internal class Program
{
    //sTRUCT, FARKLI VERİ TİPLERİNDEN OLUŞAN KARMA BİR YAPIDIR. SINIFLARA BENZER ONLAR GİBİ TANIMLANI, NESNELERİ ONLAR GİBİ YARATILIR. (FİELDS PROPERTİES METHOD CONSTRUCTOR İÇEREBİLİRLER)

    // Sınıflar belleğin heap bölgesinde tutulurken struct ise belleğin stack kısmında tutulurlar. Kısacası value type dır. 

    //BİR KERE DEĞER VERİLDİKTEN SONRA NESNEYE İHTİYAÇ DUYMADAN BİR DAHA DEĞERİ DEĞİŞTİRİLEMİYOR.

    //STRUCT YAPILARINDA NEW ANAHTAR KELİMESİ KULLANILAMAZ DİYE BİR KAVRAM YOKTUR. KULLANIM AMACI FARKI VARDIR. NEW ANAHTAR KELİMESİ NESNE OLUŞTURMAK AMACIYLA DEĞİL STRUCT (YAPI) ÜYELERİNE DEĞERLERİNE DEFAULT (VARSAYILAN) DEĞER YÜKLEMESİ YAPILMNAK İÇİN KULLANILIR.

    // BOŞ CONSTRUCTRO TANIMLANAMAZ
    //EĞER CONSTRUCTOR TANIMLANACAKSA PARAMETRE ALMAK ZORUNDA VE METOT İÇERİSİNDE DEĞERLER BAŞLANGIÇ DEĞERLERİNİ ATMAK ZORUNDADIR 

    private static void Main(string[] args)
    {
        Console.WriteLine("KARTAL");
        Kitap kitap1;
        kitap1.Adi = "Sultanı Öldürmek";
        kitap1.Yazar = "Ahmet Ümit";
        kitap1.SayfaSayisi = 230;
        kitap1.Turu = "Polisiye";

        Kitap kitap2;
        kitap2.Adi = "Sultanı Öldürmek2";
        kitap2.Yazar = "Ahmet Ümit2";
        kitap2.SayfaSayisi = 232;
        kitap2.Turu = "Polisiye2";

        Kitap kitap3 = new Kitap("Mihindar","İskender pala",150,"Edebiyat");



        Console.WriteLine(kitap3.Adi);

    }
}