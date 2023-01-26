using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uygulamalar0512.Abstract_sınıflar;
using uygulamalar0512.Interfaceler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uygulamalar0512.Sınıflar
{
    internal class ornek7faktoriyel : Hesaplama ,Iornek77faktoriyel
    {
        public override int sayi { get; set; }
        public override int sayi2 { get; set; }
        public override int sayi3 { get; set; }

        public override int[] dizi { get; set; }

        public override int geometrik { get; set; }

        public override string ad { get; set; }
        public override string sifre { get; set; }

        public string tam { get; set; }




        public override string hesaplama(int islemtipi ,  Form1 ff ,params int[] sayilar)
        {
            int sonuc = 1;
            switch (islemtipi)
            {

                case 1:
                    #region faktöriyel

                    
                    for (int i = sayi; i != 0; i--)
                    {
                        sonuc = sonuc * i;
                    }
                       
                    break;
                #endregion


                case 2:
                    #region Üslü sayı hesaplama

                   
                    for (int i = 0; i < sayi2; i++)
                    {
                        sonuc *= sayi;
                    }
                    
                    break;
                #endregion

                case 3:
                    #region pozitif negatif bulma girilen 20 sayının

                    
                    int uzunluk = sayilar.GetLength(0);
                    int neg = 0;
                    int poz = 0;
                    for (int i = 0; i < uzunluk; i++)
                    {
                        if (dizi[i] >= 0)
                        {
                            poz++;
                        }
                        else
                        {
                            neg++;
                        }

                        
                    }
                    return "cevap oop abstract " + poz.ToString()+ "tane pozitif" + neg.ToString() + "tane negatif";
                #endregion

                case 4:
                    #region fibonacci

                   
                    int num1 = 0, num2 = 1, num3;

                    string seri = "";
                    string cevap = "0 1 ";



                    for (int i = 2; i < sayi; i++)
                    {
                        num3 = num1 + num2;
                        num1 = num2;
                        num2 = num3;
                        seri = num3.ToString();
                        cevap = cevap + seri;



                    }
                    return "oop abstract " + cevap;
                #endregion

                case 5:
                    #region ortalama hesaplama

                   
                    int toplam = 0;
                    int uzunluk1 = sayilar.GetLength(0);
                    for (int i = 0; i < uzunluk1; i++)
                    {
                        toplam += sayilar[i];
                    }
                    sonuc = toplam / uzunluk1;

                    if (sonuc < 50)
                    {
                        return "oop abstract körü";
                    }
                    else
                        return "oop abstract iyi";
                #endregion

                case 6:
                    #region dereceden fah ve kelvin dönüşümü

                    float fah;
                    fah = 1.8f + 32;

                    float kelvin;
                    kelvin = sayi + 273.15f;

                   

                    ff.ornek9fahlbl.Text = "Fahrenheit" + fah;
                    ff.ornek9kelvinlbl.Text = "Kelvin" + kelvin;

                    #endregion
                    break;

                case 7:
                    #region mükemmel sayı hesaplama

                    
                    int toplam1 = 0;
                    for (int i = 1; i < sayi; i++)
                    {

                        if (sayi % i == 0)
                        {
                            toplam1 += i;
                        }
                        else
                            continue;
                    }

                    if (toplam1 == sayi)
                    {
                        ff.ornek7sonuclbl.Text = "sayınız mükemmel sayıdır oop";
                    }
                    else
                        ff.ornek7sonuclbl.Text = "sayınız mükemmel sayı değildir oop";
                    #endregion
                    break;

                case 8:
                    #region Binary'e çevirme

                    
                    int deger;
                    string kalan = "";

                    

                    for (int i = sayi; sayi != 0; sayi /= 2)
                    {
                        deger = sayi % 2;
                        kalan = deger.ToString() + kalan;
                    }

                    return "oop" + kalan;
                #endregion
                case 9:
                    #region Faiz hesaplama

                    
                    int sonuc1 = sayi * sayi2 * sayi3;
                    return sonuc1.ToString() + "oop";
                #endregion
                case 10:
                    #region Tek mi çift mi kontrol

                    
                    if (sayi % 2 == 0)
                    {
                        ff.ornek3sonuclbl.Text = "sayınız çift oop" + sayi;
                    }
                    else
                    {
                        ff.ornek3sonuclbl.Text = "sayınız tek oop " + sayi;
                    }
                    break;
                #endregion
                case 11:
                    #region 3'e ve 5'e tam bölünüp 7'ye bölünmeyen

                    
                    int tam = 0;
                    string sayilarbolum = "";
                    for (int i = sayi; i < sayi2; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0 && i % 7 != 0)
                        {
                            sayilarbolum += i.ToString() + ",";

                            tam++;
                        }
                        else
                            continue;

                    }
                    ff.ornek14sonuclbl.Text = sayilarbolum;
                    ff.ornek14sonuc1lbl.Text = tam.ToString() + "oop";
                    break;
                #endregion
                case 12:
                    #region sayı tahmin ooyunu

                    
                    if (sayi > 5)
                    {
                        ff.ornek12sonuclbl.Text = "sayı tahmininizden küçük oop";
                    }
                    else if (sayi < 5)
                    {
                        ff.ornek12sonuclbl.Text = "sayı tahmininizden büyük oop";
                    }
                    else
                    {
                        ff.ornek12sonuclbl.Text = "tebrikler dogru tahmin! oop";
                    }
                    break;
                #endregion
                case 13:
                    #region Hesap Makinası

                    
                    if (sayi3 == 0)
                    {
                        sonuc = sayi + sayi2;
                    }
                    else if (sayi3 == 1)
                    {
                        sonuc = sayi - sayi2;
                    }
                    else if (sayi3 == 2)
                    {
                        sonuc = sayi * sayi2;
                    }
                    else if (sayi3 == 3)
                    {
                        sonuc = sayi / sayi2;
                    }


                    break;
                #endregion
                case 14:
                    #region Geometrik şekil

                    
                    if (geometrik == 0)
                    {
                        int cevre = sayi + sayi2 + sayi3;
                        double yarıcevre = cevre / 2;
                        double cevapgeo = Math.Sqrt(yarıcevre * (yarıcevre - sayi) * (yarıcevre - sayi2) * (yarıcevre - sayi3));

                        return cevapgeo + "oop";
                    }
                    else if(geometrik == 1)
                    {
                        return ((sayi * sayi3) / 2).ToString();
                    }
                    else if(geometrik == 2)
                    {
                        return ((Math.Sqrt(3) / 4) * sayi * sayi).ToString();
                    }
                    else if(geometrik == 01)
                    {
                        return (sayi * sayi).ToString();
                    }
                    else if(geometrik == 02)
                    {
                        return ((sayi2 * sayi) / 2).ToString();
                    }
                    else if(geometrik == 03)
                    {
                        return (3 * (sayi * sayi)).ToString();
                    }
                    else if(geometrik == 001)
                    {

                        return  (sayi + sayi2 + sayi3).ToString();
                    }
                    else if (geometrik == 002)
                    {

                        return (sayi + sayi2 + sayi3).ToString();
                    }
                    else if (geometrik == 003)
                    {

                        return (sayi + sayi2 + sayi3).ToString();
                    }
                    else if (geometrik == 004)
                    {

                        return (sayi * 4).ToString();
                    }
                    else if (geometrik == 005)
                    {

                        return (((sayi*2) + (sayi2*2))).ToString();
                    }
                    else if (geometrik == 006)
                    {

                        return (sayi * 6).ToString();
                    }

                    break;
                #endregion
                default:
                   

                    break;
            }
            return "cevap oop abstract " + sonuc;
        }

        public override void kullanıcı(int tip ,string ad, string sifre, string tam ,Form1 ff)
        {
            
            string liste = "";
            
            #region kullanıcı ekleme

            
           
            if(tip == 1)
            {
                if (tam == ad + sifre)
                {
                    ff.ornek17sonuclbl.Text = "ooptebrikler başarıyla giriş yaptınız. sayın : " + ad;
                    liste += "" + ad + ",";
                    ff.ornek17kullanıcılarlbl.Text = liste;
                }

                else
                {
                    ff.ornek17sonuclbl.Text = "oopkullanıcı bulunamadı yeni bir kullanıcı kaydetmek ister misiniz?";
                    ff.ornek17kaydetbtn.Visible = true;
                    if (ff.ornek17adtxt.Text + ff.ornek17sifretxt.Text == "frkn12")
                    {
                        ff.ornek17kaydetbtn.Visible = false;
                        ff.ornek17sonuclbl.Text = "tebrikler başarıyla giriş yaptınız. sayın : furkan";
                        liste += " furkan,";
                        ff.ornek17kullanıcılarlbl.Text = liste;

                    }



                }
            }
            #endregion
            
        }

        public string liste(int tip,string ad,string sifre,Form1 ff)
        {
            string tam = "";
            if (tip == 0)
            {
                tam = ad + sifre;
                
            }
            return tam;
        }




    }
}
