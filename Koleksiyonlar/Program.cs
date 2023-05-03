using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];// bunu yaparsam new yapınca bellekte
            ////yeni bir adres oluşur o da sıkıntı bom boş gelir 0,1,2,3
            //isimler[4] = "İlker";// sınırlardan dışarıya çıkaramam
            //Console.WriteLine(isimler[4]); // hata alırım yer yok yer ayırıyor
            ////dizilerde çalışamam o yüzden koleksiyon yapmam gerekiyor.,
            ////çok fazla array kullanmamamız gerekiyor.
            ////new demek yeni adres demek.
            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //koleksiyonlarda degerleri koruyan bir altyapı var.
            i



        }
    }
}
