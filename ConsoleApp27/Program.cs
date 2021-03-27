using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class rex
    {
        private string Adsoyad;
        private ulong TCNo;
        private int odaNo;

        public string adsoyad
        {
            get { return Adsoyad; }
            set { Adsoyad = value; }
        }
        public ulong tcno
        {
            get { return TCNo; }
            set
            {
                if (value.ToString().Length == 11)
                    TCNo = value;

                else
                    Console.WriteLine("hata bu sayı 11 e eşit değildir.");

            }
        }
        public int Odano
        {
            get { return odaNo; }
            set
            {
                if (value > 0 && value < 120)
                    odaNo = value;
                else
                    Console.WriteLine("hata cevabı tam veremedın kardeşi malesefl");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rex p1 = new rex();
            p1.adsoyad = "FIRAT YILDIZHAN";
            p1.tcno = 413380830442;
            p1.Odano = 112;
            Console.WriteLine("isim {0} , tc {1} , odano {2}", p1.adsoyad, p1.tcno, p1.Odano);
            Console.ReadLine();
        }
        
    }

}

