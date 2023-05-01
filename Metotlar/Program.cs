using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            string[] meyveler = new string[] {"Elma","Karpuz" };
            /* boyle olmaz cunku amasya elması sadece elmadan olusmuyor
             fiyatı vb. de var bu yuzden class olusturmam gerekiyor.*/
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };//genellikle bu veriler veri kaynağından gelir
            foreach (Urun x in urunler)
                //in urunler : urunler dizisini gez
                //urun takma isimi
                //Urun ise veri tipi type-safe çalışacağı veri tipini bilecek
                //var yazsan da olur
            {
                Console.WriteLine(x.Adi);//bu programcı icin programcının aracı
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine("----------------------");
               //kullanıcı gormesi icin <li><\li>
            }

            Console.WriteLine("--------------METODLAR----------------");
            SepeteManager sepetManager = new SepeteManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //bir değişiklik olursa direkt clasdan degistirecegim
            sepetManager.Ekle2("Armut", "Yeşil", 12,10);//sayfa1
            sepetManager.Ekle2("Elma", "Yeşil", 12,9);//sayfa2
           // sepetManager.Ekle2("Karpuz", "Diyarbakır", 12);//sayfa3
            //yonetim dedi ki urunun stok adetini de yazalım
            //butun sayfalar patlar hepsine eklememiz lazım
            // o yuzden clas olusturup ona ekleyıp cıkarmaliyiz zaten Urun urun diyoruz fonk içine
            //hepsi dahil oluyor zaten.

        }
    }
}
/*Id diğerlerinden ozgun olan bir şeydir.
 * metotlar tekrar tekrar kullanılabilirliği sağlayan bir ortam sağlar
Dont repeat yourself DRY
Clean code onemli : temiz kod yazmak.
Best Practice : Doğru Uygulama Teknikleri.
Ornek bir mağaza nereye girersem sepete ekle cıkıyor.
tekrarlamak burada ise yarıyor
Her şey classlardan oluşur.*/