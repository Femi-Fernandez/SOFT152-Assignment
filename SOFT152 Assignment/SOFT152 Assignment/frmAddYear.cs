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
    public partial class frmAddYear : Form
    {

        public static frmAddYear frmkeepAddYear = null;
        public frmAddYear()
        {
            InitializeComponent();
            frmkeepAddYear = this;
        }

        private void frmAddYear_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                combLocation.Items.Add(Data.locations[i].getLocationName());
            }
        }

        private void combLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            lstYears.Items.Clear();

            for (int i = 0; i < Data.locations[locationpos].getnumyears(); i++)
            {
                lstYears.Items.Add("Year: " + Data.locations[locationpos].getyearinfo()[i].getYear());
                lstYears.Items.Add("Year Description: " + Data.locations[locationpos].getyearinfo()[i].getYearDesc());
                lstYears.Items.Add("");
            }
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            string newyearID;
            string newyearDesc;
            

            newyearID = txtNewYear.Text;
            newyearDesc = txtNewYearDesc.Text;

            Year[] tempYears = Data.locations[locationpos].getyearinfo();
            Array.Resize(ref tempYears, tempYears.Length + 1);
            Data.locations[locationpos].setyearinfo(tempYears);

            int numyearslength = Data.locations[locationpos].getnumyears();

            Data.locations[locationpos].getyearinfo()[numyearslength] = new Year(newyearID, newyearDesc, new Month[12]);


            frmAddMonth tempAddmonth = new frmAddMonth();
            tempAddmonth.Show();
            frmkeepAddYear.Close();
            
        }
    }
}
