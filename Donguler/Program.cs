using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        { // dinamik olarak listelemem lazım bir de java kursu olsaydı
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C++";
            //200 urunu boyle tek tek kurs 200 e kadar tanımlayamam
            //dizilerle tanımlarım.
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java" ,"Python","C#"};
            for (int i = 0; i <kurslar.Length; i++)//ekranımı dinamikleştirdim
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti sayfa sonu");

            /*birbirlerine benzeyen islemleri yapmak icin dongu*/
            //for (int i = 1; i < 10; i=i+2)
            //{
              //  Console.WriteLine(i);
            //}
            foreach (string kurs in kurslar)//in kurslar kursları dolas
            {//foreach dizilere uygulanır
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach BittiSayfa Sonu");
        }
    }
}
