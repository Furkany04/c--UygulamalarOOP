using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamalar0512.Interfaceler
{
    internal interface Iislem
    {
        int sayi1 { get; set; }
        int sayi2 { get; set; }
        
        int hesapla(int x, int y);
        string bilgiver();
        
    }
}
