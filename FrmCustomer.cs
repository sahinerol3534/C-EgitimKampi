using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void ClearTextBox()
        {
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerId.Text = "";
        }

        string connectionString = "host = localhost; port = 5432; database = CustomerDb; username = postgres; Password = 2184";
        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string quary = "SELECT * FROM customers ORDER BY customerid";
            var command = new NpgsqlCommand(quary, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();


        }
        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName =    txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity =    txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO customers (customername, customersurname, customercity) values (@customerName, @customerSurname, @customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            ClearTextBox();
            connection.Close();
            GetAllCustomers();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM customers WHERE customerid = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi");
            ClearTextBox();
            connection.Close();
            GetAllCustomers();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE customers SET " +
                "customername = @customerName, customersurname = @customerSurname, customercity = @customerCity WHERE customerid = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("customername", customerName);
            command.Parameters.AddWithValue("customersurname", customerSurname);
            command.Parameters.AddWithValue("customercity", customerCity);
            command.Parameters.AddWithValue("customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            ClearTextBox(); connection.Close();

            GetAllCustomers();

        }


    }
}
