using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>//<> içerisine her şeyi yazabilirim generic class calısacagım ozel bir tip
    // t verdiğim istediğim tür oluyor.
    {
        T[] items;//metodun dışında yazdım tipinde array yazdım newlemem lazım
        public MyList()//constructor burası classın ismiyle aynıdır içerisinde çalışır
        {
            items = new T[0];//burada her yaptığımda newlemesi için
        }
         public void Add(T item)
        {
            //hafızaya nasıl ekleriz simdi burada. arka planda bir arrayı yonetiyor
            //bir array tutalım
            //Boyle yaparsam deger kaybola biliyor o yuzden referansdizi oluşturmam gerek
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; // boylelikle eklemeyi yapabildimnmm
            
        }
    }
}
