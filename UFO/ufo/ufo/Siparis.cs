using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufo
{
    public class Siparis
    {
        public string Urunadı { get; set; }
        public float Urunfiyat { get; set;}
        public float Urunvergi { get; set; }

        public void Vergihesapla(float ilkfiyat)
        {
            Urunfiyat = ilkfiyat + (ilkfiyat * 18/100);
            return;
        }
    }
}
