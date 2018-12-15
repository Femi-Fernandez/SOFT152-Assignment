using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152_Assignment
{
    public partial class DisplayInfo : Form
    {

        public static DisplayInfo frmkeepDisplayInfo = null;

        public DisplayInfo()
        {
            InitializeComponent();
            frmkeepDisplayInfo = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.locations = new Location[0];
            SOFT152_Assignment.Location.setupLocationArray();

            for (int i = 0; i < 11; i++)
            {
                combLocation.Items.Add(Data.locations[i].getLocationName());
            }
            
        }

        private void combLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            int numyears = Data.locations[locationpos].getnumyears();

            combYear.Items.Clear();
            for (int i = 0; i < numyears; i++)
            {
                combYear.Items.Add(Data.locations[locationpos].getyearinfo()[i].getYear());
            }
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            int locationpos = combLocation.SelectedIndex;
            int yearpos = combYear.SelectedIndex;
      
            for (int i = 0; i < 12; i++)
            {
                lstInfo.Items.Add("Month: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMonthID());
                lstInfo.Items.Add("Max Temperature: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMaxTemp());
                lstInfo.Items.Add("Min temp: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMinTemp());
                lstInfo.Items.Add("Number of days with air frost: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getAirFrostNum());
                lstInfo.Items.Add("mm of rain: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMmOfRain());
                lstInfo.Items.Add("Hours of sun: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getHoursOfSun());
                lstInfo.Items.Add(" ");
            }
        }

        private void btnEditMonthInfo_Click(object sender, EventArgs e)
        {
            frmEditMonth tempeditmonth = new frmEditMonth();
            tempeditmonth.Show();
            frmkeepDisplayInfo.Hide();

        }

        private void btnEditYearInfo_Click(object sender, EventArgs e)
        {
            frmEditYear tempedityear = new frmEditYear();
            tempedityear.Show();
            frmkeepDisplayInfo.Hide();
        }
        private void btnEditLocationInfo_Click(object sender, EventArgs e)
        {
            frmEditLocation tempeditlocaiton = new frmEditLocation();
            tempeditlocaiton.Show();
            frmkeepDisplayInfo.Hide();
        }
        private void btnAddYearInfo_Click(object sender, EventArgs e)
        {
            frmAddYear tempAddYear = new frmAddYear();
            tempAddYear.Show();
            frmkeepDisplayInfo.Hide();
        }
        private void btnShowLocationData_Click(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            int numLocations = Data.locations.Length;


            //string theLocationName, string theStreetName, string theCountry,
            //string thePostcode, string theLatitude, string theLongitude, int theNumYears
            for (int i = 0; i < numLocations; i++)
            {
                lstInfo.Items.Add("Location name: " + Data.locations[i].getLocationName());
                lstInfo.Items.Add("Street name: " + Data.locations[i].getStreetName());
                lstInfo.Items.Add("Country: " + Data.locations[i].getCountry());
                lstInfo.Items.Add("Postcode:" + Data.locations[i].getPostcode());
                lstInfo.Items.Add("latitude: " + Data.locations[i].getLatitude());
                lstInfo.Items.Add("Longitude: " + Data.locations[i].getLongitude());
                lstInfo.Items.Add("Number of years of data recorded: " + Data.locations[i].getnumyears());
                lstInfo.Items.Add(" ");
            }
        }

        private void btnUpdateFile_Click(object sender, EventArgs e)
        {
            Data.UpdateInputFile();
            MessageBox.Show("file updated");
        }

        private void combYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
