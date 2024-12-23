using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmNewLocation : Form
    {
        public FrmNewLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

       

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.LOCATION.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.LOCATION.Find(id);
            db.LOCATION.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.LOCATION.Find(id);
            updatedValue.DAYNIGHT = textDayNight.Text;
            updatedValue.PRICE = decimal.Parse(textPrice.Text);
            updatedValue.CAPACITY = byte.Parse(nudCapacity.Text);
            updatedValue.CITY = txtCity.Text;
            updatedValue.COUNTRY = txtCountry.Text;
            updatedValue.GUIDEID = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");

        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getByID = db.LOCATION.Where(x => x.LOCATIONID == id).ToList();
            dataGridView1.DataSource = getByID;

        }
         

        private void btnadd_Click(object sender, EventArgs e)
        {
            LOCATION location = new LOCATION();
            location.CAPACITY = byte.Parse(nudCapacity.Value.ToString());
            location.CITY = txtCity.Text;
            location.COUNTRY = txtCountry.Text;
            location.PRICE = decimal.Parse(textPrice.Text);
            location.DAYNIGHT = txtCity.Text;
            location.GUIDEID = int.Parse(cmbGuide.SelectedValue.ToString());
            db.LOCATION.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
        }


        private void FrmNewLocation_Load(object sender, EventArgs e)
        {
            var values = db.GUIDE.Select(x => new
            {
                FullName = x.GUIDENAME + " " + x.GUIDESURNAME,
                x.GUIDEID
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GUIDEID";
            cmbGuide.DataSource = values;
        }
    }
}
