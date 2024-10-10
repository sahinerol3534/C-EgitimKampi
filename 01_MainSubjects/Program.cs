using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya");
            //
            //Console.WriteLine("Selam");
            #region YazdırmaKomutları

            //Console.WriteLine("***** Yemek Katagorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Katagorileri *****");
            #endregion
            #region string Değişkenler
            //string
            // Degisken_turu degisken_adi;
            //string name;
            //name = "sahin";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //
            //customerName = "Ali";
            //customerSurname = "ÇINAR";
            //customerPhone = "+90 555 555 5555";
            //customerEmail = "denden@denden.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim : "+customerPhone);
            //Console.WriteLine("Email Adresi : "+customerEmail);
            //Console.WriteLine("Adres"+district+"/"+city);
            //Console.WriteLine("--------------------------------------------------------");
            //
            //customerName = "Ayşegül";
            //customerSurname = "KAYA";
            //customerPhone = "+90 333 333 33 33";
            //customerEmail = "dendenden@denden.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres" + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");

            #endregion
            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menu Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger : "+ hamburgerPrice +" TL");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("----- Kola : " + cokePrice + " TL");
            Console.WriteLine("----- Limonata : " + lemonadePrice + " TL");
            Console.WriteLine("----- Kızartma : " + friesPrice + " TL");
            Console.WriteLine("----- Su : " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totallemonadePrice = 0;
            Console.WriteLine();


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;

            
            Console.WriteLine("     Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine("     Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine("     Kola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine("     Su Tutarı   : " + totalWaterPrice + " TL");
            Console.WriteLine("     -----------------");

            int totalPrice = 0;
            totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + 
                totalCokePrice + totallemonadePrice + totalWaterPrice;
            Console.WriteLine("     Toplam Tutar : " + totalPrice +" TL");









            


            #endregion
            Console.Read();
        }
    }
}

// Yazdırma Komutları
