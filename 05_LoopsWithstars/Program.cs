using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithstars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Baklava dilimi oluşturma

            int n = 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("             ");
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write('*');
                }

                Console.WriteLine(" ");

            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("              ");
                for (int j = 0; j <= i - 2; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 2 * n - i; k >= i + 2; k--)
                {
                    Console.Write('*');
                }

                Console.WriteLine(" ");

            }
            #endregion

            #region içi boş baklava dilimi




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  *");
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("             ");
                for (int j = n-i-1; j >= 0 ; j--)
                {
                    Console.Write(" ");
                }
                  
                Console.Write("*");
               
                for (int k = -1; k < (2 * i - 2 ); k++)
                {
                    Console.Write(" ");
                }
                
                    Console.Write("*");
              
                 
                
                Console.WriteLine(" ");

            }
            //---------------------------------
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("              ");
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int k = n+1  ; k >=  2*i-1; k--)
                {
                    Console.Write(' ');
                }
                Console.Write('*');

                
                Console.WriteLine();
                //......................

            }
            Console.WriteLine("                  *");
            #endregion

            Console.Read();



        }
    }
}
