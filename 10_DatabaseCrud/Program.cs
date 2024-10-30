using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud ---> Create - Read - Update - Delete
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        ***** Menu Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("        --------------------------------------");
            Console.WriteLine();

            #region Kategori Ekleme İşlemi
            //Console.Write("         Eklemek istediğiniz Kategori Adı: ");
            //string catagoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source =SAHINEROL; initial catalog = EgitimKampi.db; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCatagory(CatagoryName) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1", catagoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("         Kategory Başarı ile Eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus = true;

            //Console.Write("         Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("         Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            ////SqlConnection connection = new SqlConnection("Data Source =SAHINEROL; initial catalog = EgitimKampi.db; integrated security = true");
            ////connection.Open();
            ////SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values(@productName, @productPrice, @productStatus)", connection);
            ////command.Parameters.AddWithValue("@productName", productName);
            ////command.Parameters.AddWithValue("@productPrice", productPrice);
            ////command.Parameters.AddWithValue("@productStatus", productStatus ? 1 : 0);
            ////command.ExecuteNonQuery();
            ////connection.Close();
            ////Console.WriteLine("         Ürün Eklemesi Başarılı.");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source =SAHINEROL; initial catalog = EgitimKampi.db; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{   
            //    Console.Write("         ");
            //    foreach (var item in row.ItemArray) 
            //    {
            //       // Console.Write(" ");
            //        Console.Write(item.ToString());
            //        Console.Write(" / ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("         Silinecek Ürün İd: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source =SAHINEROL; initial catalog = EgitimKampi.db; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("         Silme İşlemi Yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("         Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("         Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("         Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =SAHINEROL; initial catalog = EgitimKampi.db; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE  TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("         Güncelleme Başarılı");

            #endregion

            Console.Read();
        }
    }
}
