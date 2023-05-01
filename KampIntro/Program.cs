using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenler veri tutuculardır.programlamanın en temeli//
            //her şeyi değişkenlerle yonetiriz.
            //type safety -tip güvenliği demek veri türünü yazmak zorundayım
            //metinsel olanları tek tırnakla yapmıyoruz
            //noktalı virgül satır sonuna koymak zorundayım
            string kategoriEtiketi = "Kategori";//değer tutucu.alias
            //cw tab tab Console.WriteLine("Kategori"); boyle yazmak yerine
            /*
            degistirmek istedigimde hepsini degistirmem gerekiyor
            kendini tekrar etmeyeceksin do not repeat yourself*/
            int ogrenciSayisi = 32000000;//tam sayılar
            double faizOrani = 1.45; //ondalıklı
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
         //Donguler
        }
    }
}
