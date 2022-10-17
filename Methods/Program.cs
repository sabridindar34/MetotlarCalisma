using System;
namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 35;
            urun1.Aciklama = "Amasya Elması, Elmas Gibi Parlar";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Mis Gibi Adana Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 50;
            urun3.Aciklama = "Kan Kırmızı Çilek";
            
            Urun urun4 = new Urun();
            urun4.Adi = "Dondurma";
            urun4.Fiyati = 25;
            urun4.Aciklama = "Süt Beyaz Dondurma";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            foreach (Urun urun in urunler)
            {
                //i prefer: Console.WriteLine($"Ad: {urun.Adi}, Fiyat: {urun.Fiyati}, Aciklama: {urun.Aciklama}");
                Console.WriteLine($"Ürünün Adı: {urun.Adi}");
                Console.WriteLine($"Ürünün Fiyatı: {urun.Fiyati}");
                Console.WriteLine($"Ürünün Açıklaması: {urun.Aciklama}");
                Console.WriteLine("***********************************");
            }
            Console.WriteLine("-------------METOTLAR---------------");
            //instanse - örnek

            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            //sepetManager.Ekle2("Armut","Armutun İyisini Dayılar Yer",45,6);
            //sepetManager.Ekle2("Muz","HAK'ın Muz Ortalarından Daha İyi",60,5); 
        }
    }  
}
