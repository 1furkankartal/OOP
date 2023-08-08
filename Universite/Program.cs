using System.Runtime.CompilerServices;
using Universite;

public class Program
{
    private static void Main(string[] args)
    {


        Ders ders = new Ders();
        ders.DersIsmi = "Matematik";
        Ogretmen ogretmen= new Ogretmen();
        ogretmen.Ad = "Erdinç Marquez";
        ogretmen.Brans = "Matematik";
        ders.Ogretmen = ogretmen;
       

        

    }  
}



//Bir üniversite uygulaması olsun. Burada öğretmenler ders anlatıyor, öğrenciler ders alıyor ve güvenlikler üniversiteyi koruyor.
//******************** Bir derste en fazla 10 öğrenci olabilir.

//Öğrenciler aldıkları dersleri zorluk derecesine göre puanlıyor. // Puan Ver Metodu

//Her dersin zorluk derecesini öğrencilerin verdiği puanlar belirliyor. // 

//Öğretmenler ders süresi boyunca başka bir derste bulunamaz ve alanı dışında ders anlatamaz.
//*/

//***************Branş için ayrı bir class oluşturulabilir.

// Ek bilgi: Öğrenciler, öğretmenler ve güvenlikler birer TC vatandaşıdır ve hepsinin ad, soyad, adres ve telefon bilgileri mevcuttur. // TAMAMMM
// Öğretmenlerin ve Güvenliklerin işe giriş tarihleri ve Maaşları vardır. /TAMAMM
// Öğrencilerin okul numaraları vardır. / TAMAMM

//Ders BAŞLADIĞINDA Hoca müsait mi değişkeni olabilir 
//Öğrenci sayısı 10 un altında mı kontrolü yapılabilir
//    Şartlar sağlanıyorsa 
//        öğretmen.dersver metodu çalışsın
//        Öğrenci ders al metodu çalışsın
//        Güvenlik koru metodu çalışsın
        
