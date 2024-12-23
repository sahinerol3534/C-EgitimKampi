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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.GUIDE.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            GUIDE guide = new GUIDE();
            guide.GUIDENAME = txtName.Text;
            guide.GUIDESURNAME = txtSurname.Text;
            db.GUIDE.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.GUIDE.Find(id);
            db.GUIDE.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.GUIDE.Find(id);
            updateValue.GUIDENAME = txtName.Text;
            updateValue.GUIDESURNAME = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.GUIDE.Where(x => x.GUIDEID == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
    