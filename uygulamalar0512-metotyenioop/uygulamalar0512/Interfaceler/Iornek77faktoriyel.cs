using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamalar0512.Interfaceler
{
    internal interface Iornek77faktoriyel
    {
        int sayi { get; set; }
        int sayi2 { get; set; }
        int sayi3 { get; set; }

        int[] dizi { get; set; }

        int geometrik { get; set; }

        string ad { get; set; }
        string sifre { get; set; }

        string tam { get; set; }

        string hesaplama(int islemtipi, Form1 ff, params int[] sayilar);


        void kullanıcı(int tip, string ad, string sifre, string tam, Form1 ff);


        string liste(int tip, string ad, string sifre, Form1 ff);
        
    }
}
