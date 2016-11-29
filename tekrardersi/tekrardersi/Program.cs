using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrardersi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kelime = "İzmir Yağmurlu";
            //int sayi = 10;
            //sayi++;
            //sayi = sayi + 1;
            //int toplam = 10;
            ////toplam = toplam + sayi;
            //toplam += sayi;
            //toplam -= sayi;// toplam= toplam + sayi;
            //toplam *= sayi; // toplam = toplam * sayi;
            //toplam /= sayi; // toplam = toplam / sayi;

            //Console.WriteLine(toplam);
            //Console.ReadKey();

            double num1 = 10, num2 = 20, num3 = 30;
            Console.WriteLine("Sayi 1 : {0} \nSayi 2 : {1} \nSayi 3 : {2}", num1, num2, num3);
            num1 += num2;
            num1 += num3;
            num3 += num1;
            num3 /= 3;
            num1 /= 2;
            Console.WriteLine("Sayi 1 : {0} \nSayi 2 : {1} \nSayi 3 : {2}", num1, num2, num3);

            num2 = num3 % num2;

            Console.ReadKey();
        }
    }
}
