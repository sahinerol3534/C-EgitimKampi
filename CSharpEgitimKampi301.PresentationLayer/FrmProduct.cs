using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntitiyFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICatagoryService _catagoryService;

        public FrmProduct(ICatagoryService catagoryService)
        {
            _catagoryService = catagoryService;
        }

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

        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _catagoryService = new CatagoryManager(new EfCatagoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll()
                .Select (p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.ProductStock,
                    p.ProductPrice,
                    p.ProductDescription,
                    p.Catagory.CatagoryId,
                    CatagoryName = p.Catagory.CatogoryName
                }).ToList ();

            dataGridView1.DataSource = values;

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _catagoryService.TGetAll();
            cmbCatagory.DataSource = null;
            cmbCatagory.DataSource = values;
            cmbCatagory.DisplayMember = "CatogoryName";
            cmbCatagory.ValueMember = "CatagoryId";

          
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CatagoryId = int.Parse(cmbCatagory.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtDescription.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi Yapıldı.");
            ClearTextBoxes();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme İşlemi Başarılı.");
            ClearTextBoxes ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            values.CatagoryId = int.Parse(cmbCatagory.SelectedValue.ToString());
            values.ProductPrice = decimal.Parse(txtProductPrice.Text);
            values.ProductName = txtProductName.Text;
            values.ProductDescription = txtDescription.Text;
            values.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TUpdate(values);
            MessageBox.Show("Güncelleme işlemi Yapıldı.");
            ClearTextBoxes();


                     
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            // dataGridView1 .DataSource = values;
            dataGridView1.DataSource = new List<Product> { value };
            ClearTextBoxes();
        }
    }
}


