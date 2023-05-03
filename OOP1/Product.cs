using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet
    class Product
    {
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; }//foregn key 2. alana yazılır.
        public string ProductName { get; set; } // ürün demek
        public double UnıtPrice { get; set; } //Birim Fiyatı
        public int UnitsInStock { get; set; } // stok adeti

        //Eklemek Silmek Güncellemek gibi operasyonlarıa CRUD deniyor.
        //Create read update delete
    }
}
