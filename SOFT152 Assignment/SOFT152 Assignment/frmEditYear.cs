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
    public partial class frmEditYear : Form
    {

        frmEditYear frmkeepedityear = null;
        public frmEditYear()
        {
            InitializeComponent();
            frmkeepedityear = this;
        }

        private void frmEditYear_Load(object sender, EventArgs e)
        {
            int numlocations = Data.locations.Length;
            for (int i = 0; i < numlocations; i++)
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

        private void combYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            int yearpos = combYear.SelectedIndex;
            lstCurrentYearDesc.Items.Clear();

            lstCurrentYearDesc.Items.Add(Data.locations[locationpos].getyearinfo()[yearpos].getYearDesc());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newyeardesc;
            newyeardesc = txtNewYearDesc.Text;

            int locationpos = combLocation.SelectedIndex;
            int yearpos = combYear.SelectedIndex;          

            Data.locations[locationpos].getyearinfo()[yearpos].setYearDesc(newyeardesc);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayInfo.frmkeepDisplayInfo.Show();
            frmkeepedityear.Close();
        }
    }
}
