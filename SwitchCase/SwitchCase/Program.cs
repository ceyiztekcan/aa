using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region gunler
            //bas:
            //Console.WriteLine("1-7 arası sayı girin: ");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch(gun)
            //{
            //    case 1:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");            
            //        break;
            //    case 5:
            //        Console.WriteLine("cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("pazar");
            //        break;
            //    default:
            //        goto bas;
            #endregion
            #region aylar

            //bas:
            //    Console.WriteLine("1-12 arası sayı girin: ");
            //    int ay = Convert.ToInt32(Console.ReadLine());
            //    switch (ay)
            //    {
            //        case 1:
            //        case 2:
            //        case 12:
            //            Console.WriteLine("kış");
            //            break;
            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("ilkbahar");
            //            break;
            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("yaz");
            //            break;
            //        case 9:
            //        case 10:
            //        case 11:

            //            Console.WriteLine("sonbahar");
            //            break;


            //        default:
            //            Console.WriteLine("yanlış giriş");
            //            break;

            //    }
            //    if (ay!=0)
            //    {
            //        goto bas;
            #endregion
            #region dortislem

            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //char islem = Convert.ToChar(Console.ReadLine());
            //switch (islem)
            //{
            //    case '+':
            //        Console.WriteLine("sonuç" + (sayi1 + sayi2));
            //        break;
            //    case '-':
            //        Console.WriteLine("sonuç" + (sayi1 - sayi2));
            //        break;
            //    case '*':
            //        Console.WriteLine("sonuç" + (sayi1 * sayi2));
            //        break;
            //    case '/':
            //        Console.WriteLine("sonuç" + (sayi1 / sayi2));
            //        break;
            //    default:
            //        Console.WriteLine("yanlis giris!");
            //        break;
            //}
            //Console.ReadKey();
            #endregion
            #region Call

            Console.WriteLine("yapmak istediginiz isleminiz secin: ");
            Console.WriteLine("1. Lira yukleme \n" + ");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
                {
                case 1:
                    Console.WriteLine("Lira yukleme");
                    break;
                case 2:
                    Console.WriteLine("internet");
                    break;
                case 3:
                    Console.WriteLine("konusma paketi");
                    break;

                default:
                    Console.WriteLine("Musteri temsicisi");
                    break;
            }
            Console.ReadKey();
            #endregion

        }

    }
}

