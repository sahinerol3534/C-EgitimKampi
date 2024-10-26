using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Ado.net

            Console.WriteLine("     ***** C# Veri Tabanlı Ürün Kategori Bilgisi *****");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("     --------------------------------------------------");
            Console.WriteLine("     1- Kategoriler  ");
            Console.WriteLine("     2- Ürünler  ");
            Console.WriteLine("     3- Siparişler  ");
            Console.WriteLine("     4- Çıkış Yap  ");
            Console.Write("     Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz : ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("     --------------------------------------------------");
            
            SqlConnection connection = new SqlConnection("Data Source = SAHINEROL; initial Catalog = EgitimKampi.db; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCatagory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                int i = 0;
                Console.Write("     ");
                foreach (var item in row.ItemArray)
                {
                    
                    Console.Write(item.ToString());
                    if (i % 2 == 0) { 
                    Console.Write("- ");
                    }
                    i++;
                }
                
                Console.WriteLine();
            }


            Console.Read();

        }
    }
}
