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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }
        private void ClearTextBox()
        {
            txtEmployeeName.Text = "";
            txtEmployeeSurname.Text = "";
            txtEmployeeSalery.Text = "";
            txtEmployeeId.Text = "";
            
        }

        string connectionString = "host = localhost; port = 5432; database = CustomerDb; username = postgres; Password = 2184";
        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM \"Employees\"";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM \"Departments\"";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "departmentid";
            cmbEmployeeDepartment.DataSource = dt;
            connection.Close();

                 
                    
        }


      
        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtEmployeeName.Text; 
            string EmployeeSurname = txtEmployeeSurname.Text; 
            
            decimal EmployeeSalery = decimal.Parse(txtEmployeeSalery.Text);
            int DepartmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO \"Employees\" (\"EmployeeName\",\"EmployeeSurname\", \"EmployeeSalery\", \"DepartmentId\") values (@EmployeeName, @EmployeeSurname,  @EmployeeSalery, @DepartmentId )";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            command.Parameters.AddWithValue("@EmployeeSurname", EmployeeSurname);
            
            command.Parameters.AddWithValue("@EmployeeSalery", EmployeeSalery);
            command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            ClearTextBox();
            connection.Close();
            EmployeeList();


        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    int id = int.Parse(txtEmployeeId.Text);
        //    var connection  = new NpgsqlConnection(connectionString);
        //    connection.Open();
        //    string query = "DELETE FROM customers WHERE customerid = @customerId";
        //    var command = new NpgsqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@customerId", id);
        //    command.ExecuteNonQuery ();
        //    MessageBox.Show("Kayıt silindi");
        //    ClearTextBox();
        //    connection.Close();
        //    EmployeeList();



        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int id = int.Parse(txtEmployeeId.Text);
        //    string customerName = txtEmployeeName.Text;
        //    string customerSurname = txtEmployeeSurname.Text;
        //   // string customerCity = txtEmployeeCity.Text;
        //    var connection = new NpgsqlConnection(connectionString);
        //    connection.Open();
        //    string query = "UPDATE customers SET " +
        //        "customername = @customerName, customersurname = @customerSurname, customercity = @customerCity WHERE customerid = @customerId";
        //    var command = new NpgsqlCommand (query, connection);
        //    command.Parameters.AddWithValue("customername", customerName);
        //    command.Parameters.AddWithValue("customersurname", customerSurname);
        //    command.Parameters.AddWithValue("customercity", customerCity);
        //    command.Parameters.AddWithValue("customerId", id);
        //    command.ExecuteNonQuery();
        //    MessageBox.Show("Kayıt Güncellendi");
        //    ClearTextBox(); connection.Close();
           
        //    EmployeeList();

        //}

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();

        }
    }
}
