using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uygulamalar0512.Abstract_sınıflar;
using uygulamalar0512.Sınıflar;

namespace uygulamalar0512
{
    public partial class Form1 : Form
    {
        int val;
        Random r = new Random();
        int random;
        public Form1()
        {
            InitializeComponent();
        }

        #region groupBox ayarları




        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox24.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox21.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox20.Visible = false;
                groupBox19.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox19.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox18.Visible = false;
                groupBox21.Visible = false;
                groupBox20.Visible = false;
                groupBox24.Visible = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox4.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox23.Visible = false;
                groupBox16.Visible = false;
                groupBox22.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox24.Visible = false;
            }

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox5.Visible = true;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox23.Visible = false;
                groupBox8.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox22.Visible = false;
                groupBox21.Visible = false;
                groupBox24.Visible = false;

            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox23.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = true;
                groupBox7.Visible = false;
                groupBox22.Visible = false;
                groupBox8.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox21.Visible = false;
                groupBox20.Visible = false;
                groupBox24.Visible = false;

            }

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                groupBox7.Visible = true;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox8.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox24.Visible = false;
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox8.Visible = true;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox21.Visible = false;
                groupBox24.Visible = false;

            }

        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                groupBox16.Visible = true;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox22.Visible = false;
                groupBox23.Visible = false;
                groupBox24.Visible = false;

            }

        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                groupBox17.Visible = true;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox24.Visible = false;

            }

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                groupBox18.Visible = true;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox24.Visible = false;

            }

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                groupBox19.Visible = true;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox21.Visible = false;
                groupBox22.Visible = false;
                groupBox23.Visible = false;
                groupBox24.Visible = false;


            }

        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                groupBox20.Visible = true;
                groupBox19.Visible = false;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox21.Visible = false;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox24.Visible = false;


            }

        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                groupBox21.Visible = true;
                groupBox20.Visible = false;
                groupBox19.Visible = false;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox22.Visible = false;
                groupBox23.Visible = false;
                groupBox24.Visible = false;


            }

        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                groupBox22.Visible = true;
                groupBox21.Visible = false;
                groupBox20.Visible = false;
                groupBox19.Visible = false;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox23.Visible = false;
                groupBox24.Visible = false;


            }

        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                groupBox23.Visible = true;
                groupBox22.Visible = false;
                groupBox21.Visible = false;
                groupBox20.Visible = false;
                groupBox19.Visible = false;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;
                groupBox24.Visible = false;


            }

        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                groupBox24.Visible = true;
                groupBox23.Visible = false;
                groupBox22.Visible = false;
                groupBox21.Visible = false;
                groupBox20.Visible = false;
                groupBox19.Visible = false;
                groupBox18.Visible = false; ;
                groupBox17.Visible = false;
                groupBox16.Visible = false;
                groupBox8.Visible = false;
                groupBox7.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox6.Visible = false;


            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox24.Visible = false;
            groupBox23.Visible = false;
            groupBox22.Visible = false;
            groupBox21.Visible = false;
            groupBox18.Visible = false;
            groupBox17.Visible = false;
            groupBox19.Visible = false;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox16.Visible = false;
            groupBox20.Visible = false;

        }

        #endregion

        #region metotlar


        static bool kontrol(string text)
        {
            if (Int32.TryParse(text, out int val))
            {


                return true;
            }
            else
            {
                MessageBox.Show("lütfen sayı giriniz");
                return false;
            }
        }
        //ornek2 metot dizi ile ---------
        void poznegbulma(int[] dizi)
        {
            int uzunluk = dizi.GetLength(0);
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
            sonuc1lbl.Text = "pozitif metot sayısı : " + poz + "\n" + "negatif metot sayısı : " + neg;
        }

        //ornek1 metot
        static int büyükbulma(int sayi, int sayi2)
        {
            if (sayi > sayi2)
            {
                return sayi;
            }
            else
            {
                return sayi2;
            }

        }

        //ornek3 fibonacci metot
        void fibonacci(int sayi)
        {
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
            ornek11sonuclbl.Text = cevap + " metot";

        }

        //ornek4 sayı tahmin oyunu ++ **
        void sayıtahmin(int sayi)
        {
            
            if (sayi > 5)
            {
                ornek12sonuclbl.Text = "sayı tahmininizden küçük metot";
            }
            else if (sayi < 5)
            {
                ornek12sonuclbl.Text = "sayı tahmininizden büyük metot";
            }
            else
            {
                ornek12sonuclbl.Text = "tebrikler dogru tahmin! metot";
            }

        }

        //ornek5 4 işlem
        static int toplama(int sayi, int sayi1)
        {
            int sonuc = 0;
            sonuc = sayi + sayi1;
            return sonuc;
        }
        static int cıkarma(int sayi, int sayi1)
        {
            int sonuc = 0;
            sonuc = sayi - sayi1;
            return sonuc;
        }
        static int carpma(int sayi, int sayi1)
        {
            int sonuc = 0;
            sonuc = sayi * sayi1;
            return sonuc;
        }
        static float bolme(int sayi, int sayi1)
        {
            float sonuc = 0f;
            sonuc = sayi / sayi1;
            return sonuc;
        }

        //ornek6 3 ve 5 e bölünüp 7 ye bölünmeyen
        int ucbesyedi(int sayi, int sayi1)
        {
            int tam = 0;
            string sayilar = "";
            for (int i = sayi; i < sayi1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 != 0)
                {
                    sayilar += i.ToString() + ",";

                    tam++;
                }
                else
                    continue;

            }
            ornek14sonuclbl.Text = sayilar;
            return tam;
        }

        //ornek7 faktöriyel hesaplama

        static int faktoriyel(int sayi)
        {
            int sonuc = 1;
            for (int i = sayi; i != 0; i--)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        //ornek8 fahrenheit ve kelvin dönüşümü

        static float fahrenheit(float sayi)
        {
            float fah;
            fah = 1.8f + 32;
            return fah;
        }
        static float kelvin(float sayi)
        {
            float kelvin;
            kelvin = sayi + 273.15f;
            return kelvin;
        }

        //ornek9 öğrenci not hesaplama paramss ile -----

        void nothesapla(int sayi)
        {
        //    if (ornek5sayac < 10)
        //    {
        //        ornek5sayitxt.Clear();
        //        ornek5toplam += sayi;
        //        ornek5sayac++;
        //    }
        //    if (ornek5sayac >= 10)
        //    {
        //        ornek5toplam = ornek5toplam / 10;
        //        if (ornek5toplam < 70)
        //            ornek5sonuclbl.Text = "ortalama kötü metot";
        //        else
        //            ornek5sonuclbl.Text = "ortalama iyi metot";

        //    }
        }

        static int islem(params int[] sayilar)
        {
            int toplam = 0;
            int uzunluk = sayilar.GetLength(0);
            for (int i = 0; i < uzunluk ; i++)
            {
                toplam += sayilar[i];
            }
            int sonuc = toplam / uzunluk;
            return sonuc;
        }

        //ornek10 üslü sayı hesaplama 

        static int üshesapla(int alt,int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= alt;
            }
            return sonuc;
        }

        //ornek11 mükemmel sayi ref ile ---------
        void mükemmelsayi(ref int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {

                if (sayi % i == 0)
                {
                    toplam += i;
                }
                else
                    continue;
            }

            if (toplam == sayi)
            {
                ornek7sonuclbl.Text = "sayınız mükemmel sayıdır metot";
            }
            else
                ornek7sonuclbl.Text = "sayınız mükemmel sayı değildir metot";
        }

        //ornek12 binary çevirme

        void Binary(int sayi)
        {
            int deger;
            string kalan = "";

            sayi1 = int.Parse(ornek10sayitxt.Text);

            for (int i = sayi1; sayi1 != 0; sayi1 /= 2)
            {
                deger = sayi1 % 2;
                kalan = deger.ToString() + kalan;
            }
            ornek10sonuclbl.Text = kalan + "metot";
        }

        //ornek13 faiz hesaplama

        static int faizs(int faiz,int vade, int anapara)
        {
            int sonuc = 0;
             sonuc = faiz * vade * anapara;
            return sonuc;
        }
        
        //ornek14 tek çift hesaplama

        void tekcift(int sayi)
        {
            if (sayi % 2 == 0)
                ornek3sonuclbl.Text = "sayınız çift metot";
            else
                ornek3sonuclbl.Text = "sayınız tek metot ";
        }

        //ornek 15 kullanıcı girişi
        string kullanıcı = "";
        int sayac1 = 1;
        string liste = "";

        void kullanıcıgrs(string toplam, string ad)
        {
            if (kullanıcı == toplam)
            {
                ornek17sonuclbl.Text = "tebrikler başarıyla giriş yaptınız. sayın metot : " + ad;
                liste += "" + ad + ",";
                ornek17kullanıcılarlbl.Text = liste;
            }
            else
            {
                ornek17sonuclbl.Text = "kullanıcı bulunamadı yeni bir kullanıcı kaydetmek ister misiniz? metot";
                ornek17kaydetbtn.Visible = true;
                if (ornek17adtxt.Text + ornek17sifretxt.Text == "frkn12")
                {
                    ornek17kaydetbtn.Visible = false;
                    ornek17sonuclbl.Text = "tebrikler başarıyla giriş yaptınız. sayın metot : furkan";
                    liste += " furkan,";
                    ornek17kullanıcılarlbl.Text = liste;
                }

            }
        }
        void kullanıcıkaydet(int sayac)
        {
            if (sayac1 > 2)
            {
                ornek17sonuclbl.Text = "2'den fazla kullanıcı kayıt olamaz metot";
            }
        }



        #endregion

      

        //**----------------------------------**//

        #region  Mainler



        //girilen 2 sayıdan büyük olanını bulma ++ **

        int sayi1;
        int sayi2;
        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {

                if (!Int32.TryParse(sayi2txt.Text, out val))
                {
                    sonuclbl.Text = "lütfen sayi giriniz";
                    sayi2txt.Select();

                    return;
                }

                if (!Int32.TryParse(sayi1txt.Text, out val))
                {
                    sonuclbl.Text = "lütfen sayi giriniz";
                    sayi1txt.Select();
                    return;

                }



                sayi1 = int.Parse(sayi1txt.Text);
                sayi2 = int.Parse(sayi2txt.Text);

                if (sayi1 > sayi2)
                {
                    sonuclbl.Text = "" + sayi1 + "sayısı daha büyüktür";
                }
                else if (sayi1 < sayi2)
                {
                    sonuclbl.Text = "" + sayi2 + "sayısı daha büyüktür";
                }
                else
                {
                    sonuclbl.Text = "" + sayi1 + "sayısı" + sayi2 + "sayısına eşittir";

                }
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(sayi1txt.Text) && kontrol(sayi2txt.Text))
                {


                    sayi1 = int.Parse(sayi1txt.Text);
                    sayi2 = int.Parse(sayi2txt.Text);
                    if (sayi1 == sayi2)
                    {
                        sonuclbl.Text = "sayılar eşittir metot";
                    }
                    else
                    {
                        int sonuc = büyükbulma(sayi1, sayi2);
                        sonuclbl.Text = sonuc + "sayısı daha büyüktür metot";
                    }

                }

            }
            else if (radioButton18.Checked)
            {
                try
                {
                    if (sayi11txt.Text == sayi2txt.Text)
                    {
                        sonuclbl.Text = "Sayılar eşit oop";
                    }
                    else
                    {
                        Ornek1 oo = new Ornek1();
                        oo.sayi1 = int.Parse(sayi1txt.Text);
                        oo.sayi2 = int.Parse(sayi2txt.Text);
                        sonuclbl.Text = oo.bilgiver();
                    }

                }
                catch (ArgumentException ex )
                {

                    sonuclbl.Text = ex.Message;
                }
              
            }
        }

        // girilen 20 sayıdan pozitif ve negatiflerin sayısını bulma  ++ **
        int sayac = 0;
        int neg = 0, poz = 0;
        int[] dizi = new int[20];

        private void hesapla1btn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(sayi11txt.Text, out val))
                {
                    sonuc1lbl.Text = "lütfen sayi giriniz";

                    return;
                }

                int sayi1;


                sayi1 = int.Parse(sayi11txt.Text);



                if (sayac < 20)
                {

                    if (sayi1 < 0)
                    {
                        neg++;
                        sayac++;
                    }
                    else
                    {
                        poz++;
                        sayac++;
                    }

                }
                else if (sayac >= 20)
                {

                    sonuc1lbl.Text = "negatif : " + neg + "pozitif : " + poz + "sayınız vardır";



                }


            }
            else if (radioButton17.Checked)
            {
                if (kontrol(sayi11txt.Text))
                {
                    if (sayac < 20)
                {
                    
                        dizi[sayac] = int.Parse(sayi11txt.Text);
                        sayac++;
                    }
                    else
                    {
                        poznegbulma(dizi);
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                if (sayac < 20)
                {
                    
                    dizi[sayac] = int.Parse(sayi11txt.Text);

                    sayac++;
                }
                else
                {
                    ornek7faktoriyel ff = new ornek7faktoriyel();
                    ff.dizi = dizi;
                    sonuc1lbl.Text = ff.hesaplama(3,this, ff.dizi);
                }
               
                
            }
        }


        //fibonoci dizisi yapma ++ **

        private void ornek11hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek11sayitxt.Text, out val))
                {
                    ornek11sonuclbl.Text = "lütfen sayi giriniz";
                    ornek11sayitxt.Select();
                    return;
                }

                int num1 = 0, num2 = 1, num3;
                int sayi = int.Parse(ornek11sayitxt.Text);
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
                ornek11sonuclbl.Text = cevap;


            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek11sayitxt.Text))
                {
                    sayi1 = int.Parse(ornek11sayitxt.Text);
                    fibonacci(sayi1);
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek11sayitxt.Text);
                ornek11sonuclbl.Text = ff.hesaplama(4,this,ff.sayi);

            }
        }


        //sayı tahmin oyunu ++ **
        private void ornek12hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek12sayitxt.Text, out val))
                {
                    ornek12sonuclbl.Text = "lütfen sayi giriniz";
                    ornek12sayitxt.Select();
                    return;
                }
                int a;
                int sayi = 4;


                string hata = "1 ile 10 arası değer giriniz";
                a = int.Parse(ornek12sayitxt.Text);

                ornek12sayitxt.Text = a.ToString();

                if (a > 10 || a < 0)
                {
                    ornek12sonuclbl.Text = hata;

                }
                else
                {
                    if (a > sayi)
                    {

                        ornek12sonuclbl.Text = "sayı tahmininizden küçük";
                        sayac += 1;

                    }
                    else if (a < sayi)
                    {

                        ornek12sonuclbl.Text = "sayı tahmininizden büyük ";
                        sayac += 1;


                    }
                    else
                    {
                        sayac++;
                        ornek12sonuclbl.Text = "tebrikler \t" + sayac + ". tahmininizde doğru bildiniz!!";

                        sayac = 1;
                    }

                }
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek12sayitxt.Text))
                {
                    sayi1 = int.Parse(ornek12sayitxt.Text);
                    sayıtahmin(sayi1);
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek12sayitxt.Text);
                ff.hesaplama(12, this, ff.sayi);

            }

        }



        //4işlem uygulaması ++ **

        private void ornek13toplamabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek13sayi1txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi1txt.Select();
                    return;
                }
                if (!Int32.TryParse(ornek13sayi2txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi2txt.Select();
                    return;
                }

                int sayi1 = int.Parse(ornek13sayi1txt.Text);
                int sayi2 = int.Parse(ornek13sayi2txt.Text);
                int sonuc = sayi1 + sayi2;

                ornek13sonuclbl.Text = "cevap : " + sonuc;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek13sayi1txt.Text) && kontrol(ornek13sayi2txt.Text))
                {


                    sayi1 = int.Parse(ornek13sayi1txt.Text);
                    sayi2 = int.Parse(ornek13sayi2txt.Text);

                    int sonuc = toplama(sayi1, sayi2);
                    ornek13sonuclbl.Text = "cevap metot : " + sonuc;
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek13sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek13sayi2txt.Text);
                ff.sayi3 = 0;
                ornek13sonuclbl.Text = ff.hesaplama(13, this, ff.sayi,ff.sayi2,ff.sayi3);

            }
        }

        private void ornek13cıkarmabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek13sayi1txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi1txt.Select();
                    return;
                }
                if (!Int32.TryParse(ornek13sayi2txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi2txt.Select();
                    return;
                }
                int sayi1 = int.Parse(ornek13sayi1txt.Text);
                int sayi2 = int.Parse(ornek13sayi2txt.Text);
                int sonuc = sayi1 - sayi2;

                ornek13sonuclbl.Text = "cevap : " + sonuc;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek13sayi1txt.Text) && kontrol(ornek13sayi2txt.Text))
                {
                   
                    sayi1 = int.Parse(ornek13sayi1txt.Text);
                    sayi2 = int.Parse(ornek13sayi2txt.Text);

                    int sonuc = cıkarma(sayi1, sayi2);
                    ornek13sonuclbl.Text = "cevap metot : " + sonuc;
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek13sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek13sayi2txt.Text);
                ff.sayi3 = 1;
                ornek13sonuclbl.Text = ff.hesaplama(13, this, ff.sayi, ff.sayi2,ff.sayi3);

            }
        }

        private void ornek13carpmabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek13sayi1txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi1txt.Select();
                    return;
                }
                if (!Int32.TryParse(ornek13sayi2txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi2txt.Select();
                    return;
                }
                int sayi1 = int.Parse(ornek13sayi1txt.Text);
                int sayi2 = int.Parse(ornek13sayi2txt.Text);
                int sonuc = sayi1 * sayi2;

                ornek13sonuclbl.Text = "cevap : " + sonuc;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek13sayi1txt.Text) && kontrol(ornek13sayi2txt.Text))
                {
                    sayi1 = int.Parse(ornek13sayi1txt.Text);
                    sayi2 = int.Parse(ornek13sayi2txt.Text);

                    int sonuc = carpma(sayi1, sayi2);
                    ornek13sonuclbl.Text = "cevap metot : " + sonuc;
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek13sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek13sayi2txt.Text);
                ff.sayi3 = 2;
                ornek13sonuclbl.Text = ff.hesaplama(13, this, ff.sayi, ff.sayi2, ff.sayi3);

            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek13sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek13sayi2txt.Text);
                ff.sayi3 = 2;
                ornek13sonuclbl.Text = ff.hesaplama(13, this, ff.sayi, ff.sayi2, ff.sayi3);

            }
        }

        private void ornek13bolmebtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek13sayi1txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi1txt.Select();
                    return;
                }
                if (!Int32.TryParse(ornek13sayi2txt.Text, out val))
                {
                    ornek13sonuclbl.Text = "lütfen sayi giriniz";
                    ornek13sayi2txt.Select();
                    return;
                }
                int sayi1 = int.Parse(ornek13sayi1txt.Text);
                int sayi2 = int.Parse(ornek13sayi2txt.Text);
                int sonuc = sayi1 / sayi2;

                ornek13sonuclbl.Text = "cevap : " + sonuc;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek13sayi1txt.Text) && kontrol(ornek13sayi2txt.Text))
                {
                    sayi1 = int.Parse(ornek13sayi1txt.Text);
                    sayi2 = int.Parse(ornek13sayi2txt.Text);

                    float sonuc = bolme(sayi1, sayi2);
                    ornek13sonuclbl.Text = "cevap metot : " + sonuc;
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek13sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek13sayi2txt.Text);
                ff.sayi3 = 3;
                ornek13sonuclbl.Text = ff.hesaplama(13, this, ff.sayi, ff.sayi2, ff.sayi3);

            }
        }


        //3 ve 5 e tam bölünen fakat 7 ye tam bölünmeyen sayılar ve kaç adet oldugu ++ **
        int tam = 0;
        string sayilar = "";


        private void ornek14hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek14sayi1txt.Text, out val))
                {
                    ornek14sonuclbl.Text = "lütfen sayi giriniz";
                    ornek14sayi1txt.Select();
                    return;
                }

                if (!Int32.TryParse(ornek14sayi2txt.Text, out val))
                {
                    ornek14sonuclbl.Text = "lütfen sayi giriniz";
                    ornek14sayi2txt.Select();
                    return;
                }


                int sayi1 = int.Parse(ornek14sayi1txt.Text);
                int sayi2 = int.Parse(ornek14sayi2txt.Text);

                for (int i = sayi1; i < sayi2; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 != 0)
                    {
                        sayilar += i.ToString() + ",";

                        tam++;
                    }
                    else
                        continue;

                }
                ornek14sonuclbl.Text = sayilar;

                ornek14sonuc1lbl.Text = tam.ToString();

            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek14sayi1txt.Text) && kontrol(ornek14sayi2txt.Text)){
                    sayi1 = int.Parse(ornek14sayi1txt.Text);
                    sayi2 = int.Parse(ornek14sayi2txt.Text);

                    int tam = ucbesyedi(sayi1, sayi2);
                    ornek14sonuc1lbl.Text = tam.ToString() + "metot";
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek14sayi1txt.Text);
                ff.sayi2 = int.Parse(ornek14sayi2txt.Text);
                ff.hesaplama(11, this, ff.sayi,ff.sayi2);

            }
        }



        //geometrik şekil seçimi + alan ve çevre hesaplama --

        private void ornek15ucgenradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15ucgenradioButton.Checked)
            {
                groupBox10.Visible = true;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;


            }

        }


        private void ornek15ikizkenarradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15ikizkenarradioButton.Checked)
            {
                groupBox11.Visible = true;
                groupBox10.Visible = true;
                




            }

        }
        private void ornek15eskenarradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15eskenarradioButton.Checked)
            {
                groupBox11.Visible = true;
                groupBox10.Visible = true;
                



            }

        }
        private void ornek15dikradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15dikradioButton.Checked)
            {
                groupBox11.Visible = true;
               
                groupBox10.Visible = true;



            }

        }

        private void ornek15kareradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15kareradioButton.Checked)
            {
                groupBox11.Visible = true;
                groupBox10.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;


            }

        }



        private void ornek15dikdörtgenradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15dikdörtgenradioButton.Checked)
            {
                groupBox11.Visible = true;
                groupBox10.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;



            }

        }



        private void ornek15daireradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15daireradioButton.Checked)
            {
                groupBox11.Visible = true;
                groupBox10.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;


            }

        }

        private void ornek15alanradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15alanradioButton.Checked)
            {
                ornek15secimbtn.Visible = true;
            }

        }


        private void ornek15cevreradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ornek15cevreradioButton.Checked)
            {
                ornek15secimbtn.Visible = true;
            }

        }

        int kenar1, kenar2, kenar3;

        
        private void ornek15secimbtn_Click(object sender, EventArgs e)
        {
            if (ornek15ucgenradioButton.Checked)
            {
                groupBox12.Visible = true;
                ornek15hesaplabtn.Visible = true;



            }
            if (ornek15kareradioButton.Checked)
            {
                groupBox13.Visible = true;
                ornek15hesaplabtn.Visible = true;



            }
            if (ornek15dikdörtgenradioButton.Checked)
            {
                groupBox14.Visible = true;
                ornek15hesaplabtn.Visible = true;



            }
            if (ornek15daireradioButton.Checked)
            {
                groupBox15.Visible = true;
                ornek15hesaplabtn.Visible = true;



            }




        }

        private void ornek15hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (ornek15alanradioButton.Checked)
                {
                    if (ornek15ucgenradioButton.Checked)
                    {
                        kenar1 = int.Parse(ornek15kenar1txt.Text);
                        kenar2 = int.Parse(ornek15kenar2txt.Text);
                        kenar3 = int.Parse(ornek15kenar3txt.Text);
                        if (ornek15ikizkenarradioButton.Checked)
                        {


                            int cevre = kenar1 + kenar2 + kenar3;
                            double yarıcevre = cevre / 2;
                            double cevap = Math.Sqrt(yarıcevre * (yarıcevre - kenar1) * (yarıcevre - kenar2) * (yarıcevre - kenar3));

                            //double yükseklik = Math.Sqrt((kenar1 * kenar2) - ((kenar3 / 2) * (kenar3 / 2)));
                            //double cevap = (kenar3 * yükseklik) /2;
                            ornek15sonuclbl.Text = cevap.ToString();


                        }
                        else if (ornek15dikradioButton.Checked)
                        {
                            ornek15sonuclbl.Text = ((kenar1 * kenar3) / 2).ToString();

                        }
                        else if (ornek15eskenarradioButton.Checked)
                        {
                            ornek15sonuclbl.Text = ((Math.Sqrt(3) / 4) * kenar1 * kenar1).ToString();
                        }
                    }
                    else if (ornek15kareradioButton.Checked)
                    {

                        int karekenar = int.Parse(ornek15karetxt.Text);
                        ornek15sonuclbl.Text = (karekenar * karekenar).ToString();

                    }
                    else if (ornek15dikdörtgenradioButton.Checked)
                    {
                        int ust = int.Parse(ornek15usttxt.Text);
                        int sol = int.Parse(ornek15soltxt.Text);
                        int cevap = (sol * ust) / 2;
                        ornek15sonuclbl.Text = cevap.ToString();


                    }
                    else if (ornek15daireradioButton.Checked)
                    {
                        int r = int.Parse(ornek15yarıcaptxt.Text);
                        ornek15sonuclbl.Text = (3 * (r * r)).ToString();
                    }

                }
                // ayrım
                else if (ornek15cevreradioButton.Checked)
                {
                    if (ornek15ucgenradioButton.Checked)
                    {
                        kenar1 = int.Parse(ornek15kenar1txt.Text);
                        kenar2 = int.Parse(ornek15kenar2txt.Text);
                        kenar3 = int.Parse(ornek15kenar3txt.Text);
                        if (ornek15ikizkenarradioButton.Checked)
                        {


                            int cevre = kenar1 + kenar2 + kenar3;

                            double cevap = cevre;

                            //double yükseklik = Math.Sqrt((kenar1 * kenar2) - ((kenar3 / 2) * (kenar3 / 2)));
                            //double cevap = (kenar3 * yükseklik) /2;
                            ornek15sonuclbl.Text = cevap.ToString();


                        }
                        else if (ornek15dikradioButton.Checked)
                        {
                            int cevre = kenar1 + kenar2 + kenar3;

                            double cevap = cevre;
                            ornek15sonuclbl.Text = cevap.ToString();

                        }
                        else if (ornek15eskenarradioButton.Checked)
                        {
                            int cevre = kenar1 + kenar2 + kenar3;

                            double cevap = cevre;
                            ornek15sonuclbl.Text = cevap.ToString();
                        }
                    }
                    else if (ornek15kareradioButton.Checked)
                    {

                        int karekenar = int.Parse(ornek15karetxt.Text);
                        ornek15sonuclbl.Text = (karekenar * 4).ToString();

                    }
                    else if (ornek15dikdörtgenradioButton.Checked)
                    {
                        int ust = int.Parse(ornek15usttxt.Text);
                        int sol = int.Parse(ornek15soltxt.Text);
                        int cevap = (sol * ust) * 2;
                        ornek15sonuclbl.Text = cevap.ToString();


                    }
                    else if (ornek15daireradioButton.Checked)
                    {
                        int r = int.Parse(ornek15yarıcaptxt.Text);
                        ornek15sonuclbl.Text = (6 * r).ToString();
                    }

                }


            }
            else if (radioButton18.Checked)
            {

                if (ornek15alanradioButton.Checked)
                {
                    ornek7faktoriyel ff = new ornek7faktoriyel();

                 
                    if (ornek15ucgenradioButton.Checked)
                    {
                        ff.sayi = int.Parse(ornek15kenar1txt.Text);
                        ff.sayi2 = int.Parse(ornek15kenar2txt.Text);
                        ff.sayi3 = int.Parse(ornek15kenar3txt.Text);

                        if (ornek15ikizkenarradioButton.Checked)
                        {
                            ff.geometrik = 0;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.sayi2, ff.sayi3,ff.geometrik);


                        }
                        else if (ornek15dikradioButton.Checked)
                        {
                            ff.geometrik = 1;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.sayi2, ff.sayi3, ff.geometrik).ToString();

                        }
                        else if (ornek15eskenarradioButton.Checked)
                        {
                            ff.geometrik = 2;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.sayi2, ff.sayi3, ff.geometrik).ToString();

                        }
                    }
                    else if (ornek15kareradioButton.Checked)
                    {
                       

                        ff.sayi = int.Parse(ornek15karetxt.Text);

                        ff.geometrik = 01;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi,ff.geometrik);

                        

                    }
                    else if (ornek15dikdörtgenradioButton.Checked)
                    {
                        ff.sayi= int.Parse(ornek15usttxt.Text);
                        ff.sayi2 = int.Parse(ornek15soltxt.Text);
                        ff.geometrik = 02;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi,ff.sayi2, ff.geometrik);


                    }
                    else if (ornek15daireradioButton.Checked)
                    {
                        ff.sayi = int.Parse(ornek15yarıcaptxt.Text);
                        ff.geometrik = 03;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.geometrik);
                    }

                }
                // ayrım
                else if (ornek15cevreradioButton.Checked)
                {
                    ornek7faktoriyel ff = new ornek7faktoriyel();
                    if (ornek15ucgenradioButton.Checked)
                    {
                        
                        if (ornek15ikizkenarradioButton.Checked)
                        {
                            ff.sayi = int.Parse(ornek15kenar1txt.Text);
                            ff.sayi2 = int.Parse(ornek15kenar2txt.Text);
                            ff.sayi3 = int.Parse(ornek15kenar3txt.Text);

                            ff.geometrik = 001;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi,ff.sayi2,ff.sayi3, ff.geometrik);
                            


                        }
                        else if (ornek15dikradioButton.Checked)
                        {
                            ff.sayi = int.Parse(ornek15kenar1txt.Text);
                            ff.sayi2 = int.Parse(ornek15kenar2txt.Text);
                            ff.sayi3 = int.Parse(ornek15kenar3txt.Text);
                            ff.geometrik = 002;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.sayi2, ff.sayi3, ff.geometrik);

                            

                            

                        }
                        else if (ornek15eskenarradioButton.Checked)
                        {
                            ff.sayi = int.Parse(ornek15kenar1txt.Text);
                            ff.sayi2 = int.Parse(ornek15kenar2txt.Text);
                            ff.sayi3 = int.Parse(ornek15kenar3txt.Text);
                            ff.geometrik = 003;
                            ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.sayi2, ff.sayi3, ff.geometrik);



                        }
                    }
                    else if (ornek15kareradioButton.Checked)
                    {

                        ff.sayi = int.Parse(ornek15karetxt.Text);

                        ff.geometrik = 004;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi,  ff.geometrik);

                        
                        

                    }
                    else if (ornek15dikdörtgenradioButton.Checked)
                    {
                       
                        
                        ff.sayi= int.Parse(ornek15usttxt.Text);
                        ff.sayi2 = int.Parse(ornek15soltxt.Text);

                        ff.geometrik = 005;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi,ff.sayi2, ff.geometrik);




                    }
                    else if (ornek15daireradioButton.Checked)
                    {
                        ff.sayi = int.Parse(ornek15yarıcaptxt.Text);
                        ff.geometrik = 006;
                        ornek15sonuclbl.Text = ff.hesaplama(14, this, ff.sayi, ff.geometrik);
                    }

                }
            }

        }



        //kullanıcı giriş ekranı ++



        string tam1 = "";
        private void ornek17girisbtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {




                string ad = ornek17adtxt.Text;
                string sifre = ornek17sifretxt.Text;

                string toplam = ad + sifre;


                if (kullanıcı == toplam)
                {
                    ornek17sonuclbl.Text = "tebrikler başarıyla giriş yaptınız. sayın : " + ad;
                    liste += "" + ad + ",";
                    ornek17kullanıcılarlbl.Text = liste;
                }
                else
                {
                    ornek17sonuclbl.Text = "kullanıcı bulunamadı yeni bir kullanıcı kaydetmek ister misiniz?";
                    ornek17kaydetbtn.Visible = true;
                    if (ornek17adtxt.Text + ornek17sifretxt.Text == "frkn12")
                    {
                        ornek17kaydetbtn.Visible = false;
                        ornek17sonuclbl.Text = "tebrikler başarıyla giriş yaptınız. sayın : furkan";
                        liste += " furkan,";
                        ornek17kullanıcılarlbl.Text = liste;

                    }



                }

            }
            else if (radioButton17.Checked)
            {
                string ad = ornek17adtxt.Text;
                string sifre = ornek17sifretxt.Text;
                string toplam = ad + sifre;
                    kullanıcıgrs(toplam, ad);

            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.ad = ornek17adtxt.Text;
                ff.sifre = ornek17sifretxt.Text;
                ff.tam = tam1;
                ff.kullanıcı(1, ff.ad, ff.sifre, ff.tam ,this);



            }

        }

       

        private void ornek17kaydetbtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                kullanıcı = (ornek17adtxt.Text + ornek17sifretxt.Text);
                ornek17adtxt.Clear();
                ornek17sifretxt.Clear();
                sayac1++;
                if (sayac1 > 2)
                {
                    ornek17sonuclbl.Text = "2'den fazla kullanıcı kayıt olamaz";
                }

            }
            else if (radioButton17.Checked)
            {
                kullanıcı = (ornek17adtxt.Text + ornek17sifretxt.Text);
                ornek17adtxt.Clear();
                ornek17sifretxt.Clear();
                sayac1++;
                kullanıcıkaydet(sayac);
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.ad = ornek17adtxt.Text;
                ff.sifre = ornek17sifretxt.Text;
                tam1 = ff.liste(0, ff.ad, ff.sifre, this);
                ornek17adtxt.Clear();
                ornek17sifretxt.Clear();
                sayac1++;
                if (sayac1 > 2)
                {
                    ornek17sonuclbl.Text = "2'den fazla kullanıcı kayıt olamaz oop";
                }

            }

        }

        //faktöriyel hesaplama++ **
        
       

        private void ornek8hesaplabtn_Click_1(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek8sayitxt.Text, out val))
                {
                    ornek8sonuclbl.Text = "lütfen sayı giriniz!";
                    ornek8sayitxt.Select();
                    return;

                }
                int sonuc = 1;
                int sayi = int.Parse(ornek8sayitxt.Text);

                for (int i = sayi; i != 0; i--)
                {
                    sonuc = sonuc * i;
                }

                ornek8sonuclbl.Text = "sonuç : " + sonuc;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek8sayitxt.Text))
                {
                    sayi1 = int.Parse(ornek8sayitxt.Text);
                    int sonuc = faktoriyel(sayi1);
                    ornek8sonuclbl.Text = "metot" + sonuc;
                }
            }
            else if (radioButton18.Checked)
            {

                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek8sayitxt.Text);
               
                ornek8sonuclbl.Text = ff.hesaplama(1,this,ff.sayi); 


            }
        }

       

        //dereceden fahrenheit ve kelvin dönüşümü ++ **

        private void ornek9hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek9sayitxt.Text, out val))
                {
                    ornek9kelvinlbl.Text = "lütfen sayı giriniz!";
                    ornek9fahlbl.Text = "lütfen sayı giriniz!";
                    ornek9sayitxt.Select();
                    return;

                }

                float derece = float.Parse(ornek9sayitxt.Text);
                float fah;
                float kelvin;

                kelvin = derece + 273.15f;
                fah = 1.8f + 32;

                ornek9kelvinlbl.Text = kelvin.ToString();
                ornek9fahlbl.Text = fah.ToString();

            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek9sayitxt.Text))
                {
                    float sayi1 = float.Parse(ornek9sayitxt.Text);


                    ornek9fahlbl.Text = fahrenheit(sayi1).ToString() + "metot";
                    ornek9kelvinlbl.Text = kelvin(sayi1).ToString() + "metot";

                }
            }
            else if (radioButton18.Checked)
            {

                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek9sayitxt.Text);
                ff.hesaplama(6,this,ff.sayi);

             


            }
        }



        //10 öğrencinin notunu hesaplayıp iyi kötü yazdırma ++ **

        int ornek5sayac = 0;
        int ornek5toplam = 0;
        int[] diziparams = new int[9];


        private void ornek5hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek5sayitxt.Text, out val))
                {
                    ornek5sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek5sayitxt.Select();
                    return;

                }
                int sayi = int.Parse(ornek5sayitxt.Text);
                if (ornek5sayac < 10)
                {
                    ornek5sayitxt.Clear();
                    ornek5toplam += sayi;
                    ornek5sayac++;
                }
                if (ornek5sayac >= 10)
                {
                    ornek5toplam = ornek5toplam / 10;
                    if (ornek5toplam < 70)
                        ornek5sonuclbl.Text = "ortalama kötü";
                    else
                        ornek5sonuclbl.Text = "ortalama iyi";

                }
            }
            else if (radioButton17.Checked)
            {
                int sonuc;
                if (kontrol(ornek5sayitxt.Text))
                {
                    
                    
                    if (sayac < 9)
                    {
                        diziparams[sayac] = int.Parse(ornek5sayitxt.Text);
                        sayac++;
                    }
                    else
                    {
                       sonuc = islem(diziparams);
                        if(sonuc < 50)
                        {
                            ornek5sonuclbl.Text = "params -- ortalama kötü" ;
                        }
                        else
                        {
                            ornek5sonuclbl.Text = "params ortalama iyi";
                        }
                    }

                    

                }

            }
            else if (radioButton18.Checked)
            {
                if (sayac < 9)
                {

                    diziparams[sayac] = int.Parse(ornek5sayitxt.Text);

                    sayac++;
                }
                else
                {
                    ornek7faktoriyel ff = new ornek7faktoriyel();
                    ff.dizi = diziparams;
                    ornek5sonuclbl.Text = ff.hesaplama(5, this,ff.dizi);
                }

            }
        }

       

        //üslü sayı hesaplama ++ **


        private void ornek6hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek6sayitxt.Text, out val))
                {
                    ornek6sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek6sayitxt.Select();
                    return;

                }
                if (!Int32.TryParse(ornek6üstxt.Text, out val))
                {
                    ornek6sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek6üstxt.Select();
                    return;

                }
                int sonuc = 1;
                int alt = int.Parse(ornek6sayitxt.Text);
                int us = int.Parse(ornek6üstxt.Text);
                for (int i = 0; i < us; i++)
                {
                    sonuc *= alt;
                }
                ornek6sonuclbl.Text = sonuc.ToString();
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek6sayitxt.Text) && kontrol(ornek6üstxt.Text))
                {

                    sayi1 = int.Parse(ornek6sayitxt.Text);
                    sayi2 = int.Parse(ornek6üstxt.Text);
                    int sonuc = üshesapla(sayi1, sayi2);
                    ornek6sonuclbl.Text = "method :" + sonuc;

                }
            }
            else if (radioButton18.Checked)
            {

                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek6sayitxt.Text);
                ff.sayi2 = int.Parse(ornek6üstxt.Text);

                ornek6sonuclbl.Text = ff.hesaplama(2, this ,ff.sayi,ff.sayi2);
            }
        }

        

        //mükemmel sayı ++ **

        private void ornek7hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek7sayitxt.Text, out val))
                {
                    ornek7sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek7sayitxt.Select();
                    return;

                }
                int toplam = 0;
                int sayi = int.Parse(ornek7sayitxt.Text);

                for (int i = 1; i < sayi; i++)
                {

                    if (sayi % i == 0)
                    {
                        toplam += i;
                    }
                    else
                        continue;
                }

                if (toplam == sayi)
                {
                    ornek7sonuclbl.Text = "sayınız mükemmel sayıdır";
                }
                else
                    ornek7sonuclbl.Text = "sayınız mükemmel sayı değildir";
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek7sayitxt.Text))
                {
                    int sayi = int.Parse(ornek7sayitxt.Text);
                    mükemmelsayi(ref sayi);
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek7sayitxt.Text);
                

                ff.hesaplama(7, this, ff.sayi);

            }
        }

      



        // binary çeviren program ++ **

        private void ornek10hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {


                if (!Int32.TryParse(ornek10sayitxt.Text, out val))
                {
                    ornek10sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek10sayitxt.Select();
                    return;

                }
                int sayi1;
                int deger;
                string kalan = "";

                sayi1 = int.Parse(ornek10sayitxt.Text);

                for (int i = sayi1; sayi1 != 0; sayi1 /= 2)
                {
                    deger = sayi1 % 2;
                    kalan = deger.ToString() + kalan;
                }
                ornek10sonuclbl.Text = kalan;
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek10sayitxt.Text))
                {
                    sayi1 = int.Parse(ornek10sayitxt.Text);
                    Binary(sayi1);
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek10sayitxt.Text);


               ornek10sonuclbl.Text = ff.hesaplama(8, this, ff.sayi);
            }
        }

        //faiz hesaplama ++ **

        private void ornek16hesaplabtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek16anaparatxt.Text, out val))
                {
                    ornek16sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek16anaparatxt.Select();
                    return;

                }
                if (!Int32.TryParse(ornek16vadetxt.Text, out val))
                {
                    ornek10sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek16vadetxt.Select();
                    return;

                }
                if (!Int32.TryParse(ornek16faiztxt.Text, out val))
                {
                    ornek10sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek16faiztxt.Select();
                    return;

                }

                int faiz = int.Parse(ornek16faiztxt.Text);
                int vade = int.Parse(ornek16vadetxt.Text);
                int anapara = int.Parse(ornek16anaparatxt.Text);
                int sonuc = faiz * vade * anapara;

                ornek16sonuclbl.Text = sonuc.ToString();
            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek16faiztxt.Text) && kontrol(ornek16vadetxt.Text) && kontrol(ornek16anaparatxt.Text))
                {


                    int faiz = int.Parse(ornek16faiztxt.Text);
                    int vade = int.Parse(ornek16vadetxt.Text);
                    int anapara = int.Parse(ornek16anaparatxt.Text);
                    int sonuc = faizs(faiz, vade, anapara);
                    ornek16sonuclbl.Text = sonuc.ToString() + "metot";
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek16faiztxt.Text);
                ff.sayi2 = int.Parse(ornek16vadetxt.Text);
                ff.sayi3 = int.Parse(ornek16anaparatxt.Text);


                ornek16sonuclbl.Text = ff.hesaplama(9, this, ff.sayi,ff.sayi2,ff.sayi2);

            }
        }

        //girilen sayının tek çift oldugunu bulan program ++ **

        private void ornek3hesaplavtn_Click(object sender, EventArgs e)
        {
            if (uygulamalar1radioButton.Checked)
            {
                if (!Int32.TryParse(ornek3sayitxt.Text, out val))
                {
                    ornek3sonuclbl.Text = "lütfen sayı giriniz!";

                    ornek3sayitxt.Select();
                    return;

                }

                int sayi = int.Parse(ornek3sayitxt.Text);

                if (sayi % 2 == 0)
                    ornek3sonuclbl.Text = "sayınız çift";
                else
                    ornek3sonuclbl.Text = "sayınız tek";

            }
            else if (radioButton17.Checked)
            {
                if (kontrol(ornek3sayitxt.Text))
                {
                    int sayi = int.Parse(ornek3sayitxt.Text);
                    tekcift(sayi);
                }
            }
            else if (radioButton18.Checked)
            {
                ornek7faktoriyel ff = new ornek7faktoriyel();
                ff.sayi = int.Parse(ornek3sayitxt.Text);


               ff.hesaplama(10, this, ff.sayi);
            }
        }




        #endregion





    }
}

