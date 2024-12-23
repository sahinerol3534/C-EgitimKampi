using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // foreach (1, 2, 3, 4)
            // 1 ---> Değişken Türü
            // 2 ---> Değişken adı
            // 3 ---> in
            // 4 ---> liste / Koleksiyon / dizi

            //string[] cities =
            //{
            //    "milona", "roma", "budapeşte", "ankara", "istanbul", "varşova"
            //};

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //};

            //int[] numbers =
            //{
            //    45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //};

            //int[] numbers =
            //{
            //    45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394
            //};
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    };
            //}

            //int[] numbers =
            //{
            //    45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394
            //};

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}












            #endregion

            #region Örnek Sınav Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // Sınıftaki Öğrenci Sayısını Kullanıcıdan Alınması:
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfınızda Kaç Öğrenci var. : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            // Öğrenci İsim ve Not Ortalamalarının Kayıt Edildiği Diziler:
            string[] studentName    = new string[studentCount];
            double[] studentExamAvg  = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz. : ");
                studentName[i] = Console.ReadLine();
                double totalExamResult = 0;

                // Her Öğrenci İçin 3 Sınav Notu Girişi:
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} İsimli Öğrencinin {j + 1}. Sınav Notunu Giriniz. :  ");
                    double value = double.Parse(Console.ReadLine());
                    // 3 Sınav Notunun Tolanması
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;
                Console.WriteLine();
                Console.WriteLine("------------------------------");
            }

            // Öğrenci Ortalamaları:
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentName[i]} İsimli Öğrencinin Ortalaması : {studentExamAvg[i]}");

                // Öğrenci Ortalama ve Geçme ve Kalma Durumları
                if (studentExamAvg[i] >= 50)
                {
                    
                    Console.WriteLine($"{studentName[i]} İsimli Öğrenci ****** Dersi Geçti.*******");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} İsimli Öğrenci ****** Dersi Geçemedi.*******");
                    
                }
                Console.WriteLine("------------------------------");
            }
            #endregion
            Console.Read();

        }
    }
}
