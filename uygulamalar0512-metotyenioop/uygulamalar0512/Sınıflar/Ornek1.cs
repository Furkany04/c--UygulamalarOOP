using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uygulamalar0512.Interfaceler;

namespace uygulamalar0512.Sınıflar
{
    internal class Ornek1 : Iislem
    {
        private int sayi1alan;

        public int sayi1
        {
            get { return sayi1alan; }
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException ("lütfen pozitif değer giriniz");
                }
                else
                sayi1alan = value; 
            }
        }

        private int sayi2alan;

        public int sayi2
        {
            get { return sayi2alan; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("lütfen pozitif değer giriniz");
                }
                else
                    sayi1alan = value;
            }
        }


      
        int sonuc = 0;
        public int hesapla(int sayi1alan, int sayi2alan)
        {
            
            if (sayi1alan > sayi2alan)
            {
                sonuc = sayi1alan;
            }
            else if (sayi1alan < sayi2alan)
            {

                sonuc = sayi2alan;
            }
            return sonuc;
        }

        public string bilgiver()
        {
            return hesapla(sayi1alan,sayi2alan).ToString();
        }
    }
}
