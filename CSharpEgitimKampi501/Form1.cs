using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("server = SAHINEROL; initial Catalog = EgitimKampi501Db; integrated security = true ");

        private async void btnlist_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // SQL sorgusunda @productPrice parametresinin doğru şekilde kullanılması
            string query = "INSERT INTO TblProduct(ProductName, ProductStock, ProductPrice, ProductCatagory) values(@productName, @productStock, @productPrice, @productCatagory)";

            // Parametreleri dinamik olarak ekliyoruz
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCatagory", txtProductCatagory.Text);

            // Sorguyu asenkron olarak çalıştırıyoruz
            await connection.ExecuteAsync(query, parameters);

            // Kullanıcıya işlem sonucu hakkında bilgi veriyoruz
            MessageBox.Show("Yeni Kitap Eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
