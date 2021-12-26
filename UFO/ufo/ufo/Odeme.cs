using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufo
{
   
        abstract class Odeme
        {
            public string name { get; set; }
            public string adress { get; set; }

        }
        class kredikart : Odeme
        {
            public int kart_numarası { get; set; }
            public string tip { get; set; }
            public int son_kullanma_tarihi { get; set; }

        }
        class nakit : Odeme
        {
        }
        class çek : Odeme
        {
            public string isim { get; set; }
            public int bankID { get; set; }

        }
    
}
