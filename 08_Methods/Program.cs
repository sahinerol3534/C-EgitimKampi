using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] _args)
        {
            #region Geriye Değer Döndürmeyen Metotlar

            // Sonuna () alır.
            // Customer ---> Listele, Ekle, Sil, Güncelle
            // Geriye değer döndürmeyen metotlar void ile başlar.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yaşar");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //Console.WriteLine("-----------------");
            //CustomerList();
            //Console.WriteLine("-----------------");
            //CustomerList();
            //Console.WriteLine("-----------------");
            //CustomerList();

            //void Sum()
            //{ 
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();





            #endregion

            #region Geriye Değer Döndürmeyen string Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surname);
            //}
            //CustomerCard("Mehmet", "Kaya");
            //CustomerCard("Ayşe", "Gül");


            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(25, 32, 28);



            #endregion

            #region Geriye Değer Döndüren  Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;

            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string CountryCard(string countryName, string capital,  string flagColor)

            //{
            //    string cardInfo = "      **Ülke: " + countryName + "       **Başkent: " + capital + "       **Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("         Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("         Ülkenin Başkent Adını Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("         Ülkenin Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();


            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine();
            //Console.WriteLine(CountryCard("TR", "Ankara", "kırmızı/beyaz"));


            #endregion

            #region Geriye Değer Döndüren int Parametreli Metotlar

            //int Sum(int number1,  int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(54, 89));
            //Console.WriteLine(Sum(25, 67));
            //Console.WriteLine(Sum(125, 8));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1,  int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return "    " + student +" İsimli Öğrenci Sınavı "+ result + " Not Ortalaması ile **Geçti** ";
                }
                else
                {
                    return "    " + student + " İsimli Öğrenci Sınavı " + result + " Not Ortalaması ile **Geçemedi** "; ;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 40, 14, 58));

            #endregion
            Console.Read();
        }
    } 
}