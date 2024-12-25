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
        private void ClearTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }
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
            ClearTextBoxes();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TblProduct WHERE ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Bir Kitap Silindi.");
            ClearTextBoxes();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TblProduct SET ProductName = @productName, ProductStock = @productStock, ProductPrice = @productPrice, ProductCatagory = @productCatagory WHERE ProductId = @productId ";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCatagory", txtProductCatagory.Text);
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncelleme Yapıldı.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM TblProduct";
            var productTotalCount = await connection.QuerySingleAsync<int>(query);  
            lblprodoctCount.Text = productTotalCount.ToString();

            string query2 = "SELECT ProductName FROM TblProduct WHERE ProductPrice = (SELECT MAX(ProductPrice) FROM TblProduct)";
            var maxProductPriceName = await connection.QuerySingleAsync<string>(query2);
            lblmaxProductPriceName.Text  = maxProductPriceName.ToString();

            string query3 = "SELECT COUNT(DISTINCT(ProductCatagory)) FROM TblProduct";
            var distinctCatagoryCount = await connection.QuerySingleAsync<int>(query3);
            lblproductCatagoryCount.Text = distinctCatagoryCount.ToString();
        }


        
    }
}
