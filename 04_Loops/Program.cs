using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for(x; y; z)
            // x : başlangıç
            // y : bitiş
            // z : artış / azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("     C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine("    " + i);
            //}

            //for (int i = 3; i <= 50; i+= 3)
            //{
            //    Console.WriteLine("    " + i);
            //}

            //Console.Write("     Ekrana yazılmasını istediğiniz Adeti giriniz.   : ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i ++)
            //{
            //    Console.WriteLine("    Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine("     "+i);
            //    }
            //}
            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i ++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine("    " + totalvalue);

            //int totalvalue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine("     " + i);
            //    }

            //}
            //Console.WriteLine("    " + totalvalue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("     " + count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++) {
            //    bacterium *= 2;
            //    Console.WriteLine("     " + i + ".saat sonunda  : " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //while yapısı
            // while(şart) şart sağlanana kadar döngü devam eder.
            // {
            // işlemler
            //}
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("     Merhaba Döngüler.");
            //    i++;
            //}

            // 1 den 10 kadar 3 bölünen sayıları yazdır.

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("     " + i);
            //    }
            //    i++;
            //}

            // 1 den 10 a kadar olan sayıların toplamı
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("     " + sum);






            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamı nedir.

            Console.Write("     3 basamaklı bir sayı girin  : ");
            int number = int.Parse(Console.ReadLine());


            int sum = 0;
            int yuzler = number / 100;
            int onlar = (number - (yuzler * 100)) / 10;
            int birler = (number - (yuzler * 100 + onlar * 10));
            
            Console.Write("     sayi : " + yuzler + " + " + onlar + " + " + birler);
            sum = yuzler + onlar + birler;
            Console.WriteLine("     Basamaklar Toplamı  : " + sum);


            #endregion

        }
    }
}
