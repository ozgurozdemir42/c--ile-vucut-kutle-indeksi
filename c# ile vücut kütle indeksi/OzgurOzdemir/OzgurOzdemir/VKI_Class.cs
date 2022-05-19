using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurOzdemir
{
    public static class VKI_Class
    {
        public static double Hesapla(double boy, double kilo)
        {
            double indeks = 0;
            indeks = kilo/(boy * boy);
            return indeks;

        }
        public static void Olustur(string ad,string soyad,String Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\VKI_Sonuc.txt", true);
                sw.WriteLine(ad+" "+soyad + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
