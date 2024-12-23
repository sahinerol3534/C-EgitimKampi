using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("     ***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //CultureInfo tr = new CultureInfo("tr-TR");
            //Console.OutputEncoding = System.Text.Encoding.UTF8;


            //Console.WriteLine("     ---- Elma Birim Fiyatı      : " + applePrice + " " + "₺");
            //Console.WriteLine("     ---- Portakal Birim Fiyatı  : " + orangePrice + " " + "₺");
            //Console.WriteLine("     ---- Çilek Birim Fiyatı     : " + strawberryPrice + " " + "₺");
            //Console.WriteLine("     ---- Patates Birim Fiyatı   : " + potatoPrice + " " + '\u20BA');
            //Console.WriteLine("     ---- Domates Birim Fiyatı   : " + tomatoPrice + " " + '\u20BA');
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine("      Alınan Ürün    : Elma ");
            //Console.WriteLine("      Birim Fiyat    : " + applePrice + "₺");
            //Console.WriteLine("      Gramaj         : " + appleGram + "kg");
            //Console.WriteLine("      Toplam Tutar   : " + (appleGram * applePrice + "₺"));

            //Console.WriteLine(" ----");
            //Console.WriteLine("      Alınan Ürün    : Portakal ");
            //Console.WriteLine("      Birim Fiyat    : " + orangePrice + "₺");
            //Console.WriteLine("      Gramaj         : " + orangeGram + "kg");
            //Console.WriteLine("      Toplam Tutar   : " + (orangeGram * orangePrice + "₺"));

            //Console.WriteLine(" ----");
            //Console.WriteLine("      Alınan Ürün    : Çilek ");
            //Console.WriteLine("      Birim Fiyat    : " + strawberryPrice + "₺");
            //Console.WriteLine("      Gramaj         : " + strawberryGram + "kg");
            //Console.WriteLine("      Toplam Tutar   : " + (strawberryGram * strawberryPrice + "₺"));

            //Console.WriteLine(" ----");
            //Console.WriteLine("      Alınan Ürün    : Patates ");
            //Console.WriteLine("      Birim Fiyat    : " + potatoPrice + "₺");
            //Console.WriteLine("      Gramaj         : " + potatoGram + "kg");
            //Console.WriteLine("      Toplam Tutar   : " + (potatoGram * potatoPrice + "₺"));

            //Console.WriteLine(" ----");
            //Console.WriteLine("      Alınan Ürün    : Domates ");
            //Console.WriteLine("      Birim Fiyat    : " + tomatoPrice + "₺");
            //Console.WriteLine("      Gramaj         : " + tomatoGram + "kg");
            //Console.WriteLine("      Toplam Tutar   : " + (tomatoGram * tomatoPrice + "₺"));

            //Console.WriteLine(" ---------------------------------");
            //Console.WriteLine("     Genel Toplam    : " + (appleGram * applePrice + orangeGram * orangePrice + strawberryGram * strawberryPrice + potatoGram * potatoPrice + tomatoGram * tomatoPrice + "₺"));



            #endregion

            #region char Değişkenler
            //char tek tırnakla tanımlanır
            //char symbol;
            //symbol = 'a';
            #endregion

            #region Klavyeden Veri Girişi String Değişkenler
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("     ***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("     Yolcu TC no.    : ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("     Yolcunun Adı    : ");
            //passengerName = Console.ReadLine();
            //Console.Write("     Yolcunun Soyadı : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("     Yolcunun Yaşı   : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("     İlçe Bilgisi    : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("     Şehir Bilgisi   : ");
            //passengerCity = Console.ReadLine();




            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(" Yolcunun " );
            //Console.WriteLine(" TC No.      : " + passengerIdentityNumber);
            //Console.WriteLine(" Adı Soyadı  : " + passengerName + " " + passengerSurname);
            //Console.WriteLine(" Yaşı        : " + passengerAge);
            //Console.WriteLine(" Adres       : " + passengerDistrict + " / " + passengerCity);

            #endregion

            #region Klavyeden veri Girişi İnteger ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("     Lütfen aldığınız ayakkabı sayısını giriniz. : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("     Lütfen aldığınız bilgisayar sayısını giriniz. : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("     Lütfen aldığınız sandalye sayısını giriniz. : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("     Lütfen aldığınız televizyon sayısını giriniz. : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + 
            //    tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("     Toplam Ödemeniz gereken Tutar   : " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı Giriş ve Dönüşümleri

            //double exam1, exam2, exam3, result;

            //Console.Write("     Lütfen 1. sınav notunu giriniz.     : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("     Lütfen 2. sınav notunu giriniz.     : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("     Lütfen 3. sınav notunu giriniz.     : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("   sınav ortalamanız     : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("     Lütfen cinsiyet seçiniz.    : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("     Seçtiğiniz Cinsiyet     : " + gender);
            
            #endregion

            Console.Read();







        }
    }
}
