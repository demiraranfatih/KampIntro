using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevHafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Iphone 11";
            urun1.urunRengi = "Beyaz";
            urun1.urunStokAdeti = 5;
            Urun urun2 = new Urun();
            urun2.urunAdi = "Samsung Galaxy S20";
            urun2.urunRengi = "Mavi";
            urun2.urunStokAdeti = 10;
            Urun urun3 = new Urun();
            urun3.urunAdi = "Samsung Galaxy A50";
            urun3.urunRengi = "Siyah";
            urun3.urunStokAdeti = 20;
            Urun urun4 = new Urun();
            urun4.urunAdi = "Apple Watch";
            urun4.urunRengi = "Mat";
            urun4.urunStokAdeti = 52;
            Urun urun5 = new Urun();
            urun5.urunAdi = "Iphone 13";
            urun5.urunRengi = "Sarı";
            urun5.urunStokAdeti = 20;
            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4,urun5 };
            Console.WriteLine(" For ile");
            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine(" Urun Adı ::"+
                    urunler[i].urunAdi+" Rengi :"+urunler[i].urunRengi
                    + " Stok Adeti :" + urunler[i].urunStokAdeti);
            }
            Console.WriteLine(" Foreach ile");
            foreach (var urun in urunler)
            {
                Console.WriteLine(" Urun Adı :"+urun.urunAdi
                    +" Rengi :"+urun.urunRengi
                    +"Stok Adeti :"+urun.urunStokAdeti);
            }
            Console.WriteLine("While ile");
            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine(" Urun Adı ::" +
                   urunler[x].urunAdi + " Rengi :" + urunler[x].urunRengi
                   + " Stok Adeti :" + urunler[x].urunStokAdeti);
                x++;
            }
        }
    }
    class Urun
    {
        public string urunAdi { get; set; }
        public string urunRengi { get; set; }
        public int urunStokAdeti { get; set; }
    }
}
