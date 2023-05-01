using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 =30
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999


            //int decimal float double bool = değer tip
            //array class interface =referans tip
            //bellecte stack ve heap diye alanlar var sdssda
            //int sayi1,sayi2 dediğinde stack de gerceklesiyor
            //stackte sadece değeri aktarır
            //dizide hem stackte hem heapte alan oluşturuyor(new ile)adres tutmaya baslıyor
            //stack     heap
            //sayilar1  [1,2,3]
            //sayilar2  [10,20,30]
            //sayilar1 = sayilar2 dediginde sayilar1 in referansı sayilar2nin referansına eşitrliyorsun
        }   //sonra sayilar2[0]=999 yapıyorsun ikisi de degisiyor pointer gibi.
            //sonrasında garbagecollector gelecek. silecek sailar[1]isdadsadsdasa
    }
}
