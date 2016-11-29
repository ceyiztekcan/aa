using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sayıkarşılaştırma

            //    int sayi1 = 7, sayi2 = 3;

            //if (sayi1 > sayi2)

            //    {
            //        Console.WriteLine("sayi1 büyük");
            //    }
            // else if (sayi2 > sayi1)
            //{
            //        Console.WriteLine("sayi2 büyük");
            //}
            //else
            //{
            //        Console.WriteLine("sayılar eşit");
            //}

            //    Console.ReadKey();
            #endregion
            #region TekCift
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("sayi çift");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tek");
            //}
            //Console.ReadKey();
            #endregion
            #region sayiArtirma
            //int a = 5;
            //int b = a++; /*b = a; a++;*/
            //int b = ++a;/* a++; b = a;*/

            #endregion
            #region Dortislem
            //int sayi1, sayi2, sonuc=0;

            //char islem;

            //Console.Write("sayi1:");
            // sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("sayi2:");
            // sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("işlem seçiniz:");
            //islem = Convert.ToChar(Console.ReadLine());

            //if (islem == '+')
            //{
            //    sonuc = (sayi1 + sayi2);

            //}
            //else if (islem == '-')
            //{
            //    sonuc = (sayi1 - sayi2);
            //}

            //else if (islem == '*')
            //    {
            //    sonuc = (sayi1 * sayi2);
            //}
            //else if (islem == '/')
            //{
            //    sonuc = (sayi1 / sayi2);
            //}
            //Console.WriteLine("sonuc" + sonuc);
            //Console.ReadKey();
            #endregion
            #region vizenotu
            //int vize1, vize2, final, not;
            //string sonuc = "AA";
            //Console.WriteLine("1.vize notu:");
            //vize1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.vize notu:");
            //vize2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("final notu:");
            //final = Convert.ToInt32(Console.ReadLine());
            //not = ((vize1 * 20 + vize2 * 20 + final * 60) / 100);
            //if (not>=85)
            //{
            //    sonuc = "AA";
            //} 
            //else if (not >= 80 && not<= 84)
            //{
            //    sonuc = "BA";
            //}
            //else if (not >= 75 && not <= 79)
            //{
            //    sonuc = "BB";
            //}
            //else if (not >= 70 && not <= 74)
            //{
            //    sonuc = "CB";
            //}
            //else if (not >= 60 && not <= 69)
            //{
            //    sonuc = "CC";
            //}
            //else 
            //{
            //    sonuc = "FF";
            //}

            //Console.WriteLine("sonuc : " + sonuc);
            //Console.ReadKey();
            #endregion
            #region maasvergi
            double maas;
           double vergi;

            Console.WriteLine("maas");
            maas = Convert.ToDouble(Console.ReadLine());
            if (maas <=1000)
            {
                vergi = maas * 0.1;
            }

            if (maas <= 2500)
            {
                vergi = maas * 0.2;
            }

            if (maas >2500 && maas<5000)
            {
                vergi = maas * 0.3;
            }
            else
            {
                vergi = maas * 0.5;
            }

            Console.WriteLine("vergi : " + vergi);
            Console.ReadKey();
            #endregion

        }
    }
}
