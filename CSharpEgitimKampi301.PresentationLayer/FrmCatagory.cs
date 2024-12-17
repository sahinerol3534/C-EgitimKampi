using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntitiyFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCatagory : Form
    {
        private readonly ICatagoryService _catagoryService;
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

        public FrmCatagory()
        {
            _catagoryService = new CatagoryManager(new EfCatagoryDal());
            InitializeComponent();
        }

        
            
        private void btnList_Click(object sender, EventArgs e)
        {
            var catagoryValues = _catagoryService.TGetAll();
            dataGridView1.DataSource = catagoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Catagory catagory = new Catagory();
            catagory.CatogoryName = txtCatagoryName.Text;
            catagory.CatagoryStatus = true;
            _catagoryService.TInsert(catagory);
            MessageBox.Show(" Ekleme Başarılı");
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCatagoryId.Text);
            var deletedValues = _catagoryService.TGetById(id);
            _catagoryService.TDelete(deletedValues);
            MessageBox.Show(" Silme Başarılı");
            ClearTextBoxes();

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCatagoryId.Text);
            var values = _catagoryService.TGetById(id);
           // dataGridView1 .DataSource = values;
            dataGridView1.DataSource = new List<Catagory> { values };
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCatagoryId.Text);
            var updatedValue = _catagoryService.TGetById(updatedId);
            updatedValue.CatogoryName = txtCatagoryName.Text;
            updatedValue.CatagoryStatus = true;
            _catagoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme Başarılı");
            ClearTextBoxes();
        }

        private void FrmCatagory_Load(object sender, EventArgs e)
        {

        }
    }
}
