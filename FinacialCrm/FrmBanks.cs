using FinacialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinacialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblZiraatBank.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifBank.Text = vakifBankBalance.ToString() + " ₺";
            lblisBank.Text = isBankBalance.ToString() + " ₺";

            // Hesap Hareketleri:
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            DateTime parsedDate = DateTime.Parse(bankProcess1.ProcessDate.ToString());
            //lblBankProcess1.Text = bankProcess1.Description.PadRight(30) + bankProcess1.ProcessType.PadRight(10) + bankProcess1.Amount.ToString().PadLeft(10) + "₺"+ "      " + parsedDate.ToString("dd.MM.yyyy");
            lblBankProcess1.Text = $"{bankProcess1.Description,-30} {bankProcess1.ProcessType,-10} {bankProcess1.Amount,10:F2} ₺         {parsedDate:dd.MM.yyyy}";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            DateTime parsedDate2 = DateTime.Parse(bankProcess2.ProcessDate.ToString());
            //lblBankProcess2.Text = bankProcess2.Description.PadRight(30) + bankProcess2.ProcessType.PadRight(10) + bankProcess2.Amount.ToString().PadLeft(10) + "₺" + "      " + parsedDate2.ToString("dd.MM.yyyy");   
            lblBankProcess2.Text = $"{bankProcess2.Description,-30} {bankProcess2.ProcessType,-10} {bankProcess2.Amount,10:F2} ₺         {parsedDate2:dd.MM.yyyy}";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            DateTime parsedDate3 = DateTime.Parse(bankProcess3.ProcessDate.ToString());
            //lblBankProcess3.Text = bankProcess3.Description.PadRight(30) + bankProcess3.ProcessType.PadRight(10) + bankProcess3.Amount.ToString().PadLeft(10) + "₺" + "      " + parsedDate3.ToString("dd.MM.yyyy");
            lblBankProcess3.Text = $"{bankProcess3.Description,-30} {bankProcess3.ProcessType,-10} {bankProcess3.Amount, 10:F2} ₺         {parsedDate3: dd.MM.yyyy}";

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            DateTime parsedDate4 = DateTime.Parse(bankProcess4.ProcessDate.ToString());
            //lblBankProcess4.Text = bankProcess4.Description.PadRight(30) + bankProcess4.ProcessType.PadRight(10) + bankProcess4.Amount.ToString().PadLeft(10) + "₺" + "      " + parsedDate4.ToString("dd.MM.yyyy");
            lblBankProcess4.Text = $"{bankProcess4.Description,-30} {bankProcess4.ProcessType,-10} {bankProcess4.Amount,10:F2} ₺          {parsedDate4:dd.MM.yyyy}";

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();   
            DateTime parsedDate5 = DateTime.Parse(bankProcess5.ProcessDate.ToString());
            //lblBankProcess5.Text = bankProcess5.Description.PadRight(30) + bankProcess5.ProcessType.PadRight(10) + bankProcess5.Amount.ToString().PadLeft(10) + "₺" + "      " + parsedDate5.ToString("dd.MM.yyyy");
            lblBankProcess5.Text = $"{bankProcess5.Description,-30} {bankProcess5.ProcessType,-10} {bankProcess5.Amount,10:F2} ₺          {parsedDate5:dd.MM.yyyy}";
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBankExit_Click(object sender, EventArgs e)
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
