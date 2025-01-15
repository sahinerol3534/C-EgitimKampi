using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinacialCrm.Models;

namespace FinacialCrm
{
    public partial class FrmBilling : Form
    {
      
        public FrmBilling()
        {
            InitializeComponent();
        }
        private void TextboxClear()
        {
            txtBillId.Text = "";
            txtBillTitle.Text = "";
            txtBillAmount.Text = "";
            txtBillPeriod.Text = "";
        }
             
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges(); 
            MessageBox.Show("Fatura Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Fatura Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList() ;
            dataGridView1.DataSource = values;

            TextboxClear();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = Decimal.Parse(txtBillAmount.Text);
            string priod = txtBillPeriod.Text;
            int id = int.Parse((string)txtBillId.Text);

            Bills bills = new Bills();
            bills.BillTitle = title; 
            bills.BillAmount = amount;
            bills.BillPeriod = priod;
            db.Bills.Add(bills);
            db.SaveChanges();

            MessageBox.Show("Fatura Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;

            TextboxClear();


        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                                         "Çıkış Onayı",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Çıkış Yapıldı", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }   
}
