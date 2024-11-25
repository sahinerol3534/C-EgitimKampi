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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.LOCATION.Count().ToString();
            lblSumCapacity.Text = db.LOCATION.Sum(x => x.CAPACITY).ToString();
            lblGuideCount.Text = db.GUIDE.Count().ToString();

            decimal Capacity = decimal.Parse(db.LOCATION.Average(x => x.CAPACITY).ToString());
            lblAvgCapacity.Text = Capacity.ToString("F0") + " Kişi";
            decimal Price = decimal.Parse(db.LOCATION.Average(x => x.PRICE).ToString());
            lblAvgLocationPrice.Text = Price.ToString("F2") + " ₺";

            int lastCountryId = int.Parse(db.LOCATION.Max(x => x.LOCATIONID).ToString());
            lblLastCountryName.Text = db.LOCATION.Where(x => x.LOCATIONID == lastCountryId).Select(y => y.COUNTRY).FirstOrDefault();

            lblKapadokyaCapacity.Text = db.LOCATION.Where(x => x.CITY == "Kapadokya").Select(y => y.CAPACITY).FirstOrDefault().ToString() + " Kişi";

            lblTurkiyeCapacityAvg.Text = db.LOCATION.Where(x => x.COUNTRY == "Türkiye").Average(y => y.CAPACITY).ToString();
            
            var romeGuideId = db.LOCATION.Where(x => x.CITY == "Roma Turistik").Select(y => y.GUIDEID).FirstOrDefault();
            lblRomeGuideName.Text = db.GUIDE.Where( x => x.GUIDEID == romeGuideId).Select(y => y.GUIDENAME +" " + y.GUIDESURNAME).FirstOrDefault().ToString();
            var maxCapacity = db.LOCATION.Max(x =>x.CAPACITY);
            lblMaxCapacityLocasion.Text = db.LOCATION.Where(x => x.CAPACITY == maxCapacity).Select(y =>y.CITY).FirstOrDefault().ToString();
        
            var maxPrice = db.LOCATION.Max(x => x.PRICE);
            lblMaxPriceLocasion.Text = db.LOCATION.Where(x => x.PRICE == maxPrice).Select(y => y.CITY).FirstOrDefault().ToString();

            var guideId = db.GUIDE.Where(x => x.GUIDENAME == "Ayşegül" && x.GUIDESURNAME == "Çınar").Select(y => y.GUIDEID).FirstOrDefault();
            lblAysegulCinarLocasionCount.Text= db.LOCATION.Where(x => x.GUIDEID == guideId).Count().ToString();


        } 
        
    }
}
