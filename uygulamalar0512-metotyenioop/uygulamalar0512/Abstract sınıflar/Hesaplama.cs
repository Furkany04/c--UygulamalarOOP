using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamalar0512.Abstract_sınıflar
{
    internal abstract class Hesaplama
    {
        
        public abstract int sayi { get; set; }
        public abstract int sayi2 { get; set; }
        public abstract int sayi3 { get; set; }

        public abstract int geometrik { get; set; }

        public abstract int[] dizi { get; set; }

        public abstract string ad { get; set; }
        public abstract string sifre { get; set; }


        


      
     
        public virtual string hesaplama(int islemtepki , Form1 ff , params int[] sayilar )
        {
            int sonuc = 1;
            for (int i = sayi; i != 0; i--)
            {
                sonuc = sonuc * i; 
            }
            return "cevap oop abstract " + sonuc;


        }

        public virtual void kullanıcı(int tip , string ad, string sifre ,string tam, Form1 ff)
        {
             
        }

      
    }
}
