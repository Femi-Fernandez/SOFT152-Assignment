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

            for (int i = 0; i < numyears; i++)
            {
                combYear.Items.Add(Data.locations[locationpos].getyearinfo()[i].getYear());
            }
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
           
            int locationpos = combLocation.SelectedIndex;
            int yearpos = combYear.SelectedIndex;
            MessageBox.Show(Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[0].getMaxTemp());
            for (int i = 0; i < 12; i++)
            {
                lstMonthInfo.Items.Add("Month: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMonthID());
                lstMonthInfo.Items.Add("Max Temperature: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMaxTemp());
                lstMonthInfo.Items.Add("Min temp: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMinTemp());
                lstMonthInfo.Items.Add("Number of days with air frost: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getAirFrostNum());
                lstMonthInfo.Items.Add("mm of rain: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMmOfRain());
                lstMonthInfo.Items.Add("Hours of sun: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getHoursOfSun());
                lstMonthInfo.Items.Add(" ");
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
    }
}
