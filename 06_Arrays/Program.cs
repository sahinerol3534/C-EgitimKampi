using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      Diziler:");
            Console.WriteLine();
            //Console.Write("      ");
            #region Temel Dizi Örnekleri:

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine("        "+colors[2]);
            //

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.Write("      ");
            //Console.WriteLine(cities[2]);

            //Console.Write("      ");
            //Console.WriteLine(cities[4]);


            #endregion

            #region Dizideki Tüm Elemanları Yazdırma:
            //string[] colors = {"Sarı", "Kırmızı", "Beyaz", "Mavi",
            //    "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{

            //    Console.Write("      ");
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 126, 635, 489, 520,
            //    2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {

            //        Console.Write("      ");
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.Write("      ");
            //    Console.WriteLine(symbol[i]);
            //}

            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.Write("      ");
            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali", "ahmet", "ayşe", "buse",
            //    "cem", "deniz" };
            //Console.WriteLine(persons.Length);
            //Console.WriteLine();
            //Array.Sort(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write("      ");
            //    Console.WriteLine(myArray[i]);
            //}

            Console.WriteLine("      Çift Sayılar:");
            Console.WriteLine("      -------------");
            for (int i = 0; i < myArray.Length; i++) {
                if (myArray[i] % 2 == 0)
                {
                    Console.Write("      ");
                    Console.WriteLine(myArray[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("      Tek Sayılar:");
            Console.WriteLine("      ------------");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 1)
                {
                    Console.Write("      ");
                    Console.WriteLine(myArray[i]);
                }
            }





            #endregion

            #region Dizi Metodları
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int index = Array.IndexOf(myArray, 95);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("      ");
            //Console.WriteLine(myArray.Max());
            //Console.WriteLine();
            //Console.Write("      ");
            //Console.WriteLine(myArray.Min());
            // Console.Write("      ");
            // Console.WriteLine(myArray.Sum());


            #endregion
            #region Kullanıcıdan alınan değerle dizi oluşturma

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"      Lütfen {i + 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();

            //}

            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write("      ");
            //    Console.WriteLine(cities[i]);
            //}


            #endregion




            Console.Read();
        }
    }
}
