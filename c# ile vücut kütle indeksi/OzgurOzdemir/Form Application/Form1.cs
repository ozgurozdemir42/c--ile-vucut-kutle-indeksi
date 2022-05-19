using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OzgurOzdemir;


namespace Form_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hesapla_Button_Click(object sender, EventArgs e)
        {
            
            double boy, kilo;
            string ad = " ", soyad = " ";
            boy = Convert.ToDouble(boy_textBox.Text);
            kilo = Convert.ToDouble(kilo_textBox.Text);
            ad = ad_textBox.Text;
            soyad = soyad_textBox.Text;
            double indeks=VKI_Class.Hesapla(boy, kilo);
            int sonuc = Convert.ToInt32(indeks);
            sonuc_Label.Text = sonuc.ToString();
            if (indeks < 18)
            {
                sonuc_label2.Text = "Zayıf";
                VKI_Class.Olustur(ad, soyad, "Zayıf");
            }
            else if (indeks >= 18 && indeks < 25)
            {
                sonuc_label2.Text = "Normal";
                VKI_Class.Olustur(ad, soyad, "Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                sonuc_label2.Text = "Kilolu";
                VKI_Class.Olustur(ad, soyad, "Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                sonuc_label2.Text = "Obez";
                VKI_Class.Olustur(ad, soyad, "Obez");
            }
            else
            {
                sonuc_label2.Text = "Ciddi Obez";
                VKI_Class.Olustur(ad, soyad, "Ciddi Obez");
            }

        }
    }
}
