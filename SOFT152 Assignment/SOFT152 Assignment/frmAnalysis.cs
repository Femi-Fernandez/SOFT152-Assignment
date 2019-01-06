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
    public partial class frmAnalysis : Form
    {
        public frmAnalysis()
        {
            InitializeComponent();
        }
        //fill initial comboboxes with locations
        private void frmAnalysis_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                combLocation1.Items.Add(Data.locations[i].getLocationName());
            }

            for (int i = 0; i < 11; i++)
            {
                combLocation2.Items.Add(Data.locations[i].getLocationName());
            }

            combLocation2.SelectedIndex = 0;
            combLocation1.SelectedIndex = 0;
        }

        //Location 1 Year combobox fill
        private void combLocation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int location1Pos = combLocation1.SelectedIndex;

            int numyears = Data.locations[location1Pos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear1.Items.Add(Data.locations[location1Pos].getyearinfo()[i].getYear());
            }
            combYear1.SelectedIndex = 0;
        }

        //location 1 month combobox fill
        private void combYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int location1Pos = combLocation1.SelectedIndex;

            int year1Pos = combYear1.SelectedIndex;

            for (int i = 0; i < 12; i++)
            {
                combMonth1.Items.Add(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getMonthID());
            }
        }

        //Added accidentaly and cannot remove
        private void combMonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Added accidentaly and cannot remove
        }

        //location 2 year combobox fill
        private void combLocation2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int location2Pos = combLocation2.SelectedIndex;

            int numyears = Data.locations[location2Pos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear2.Items.Add(Data.locations[location2Pos].getyearinfo()[i].getYear());
            }
            combYear2.SelectedIndex = 0;
        }

        //location 2 month combobox fill
        private void combYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int location2Pos = combLocation2.SelectedIndex;

            int year2Pos = combYear2.SelectedIndex;

            for (int i = 0; i < 12; i++)
            {
                combMonth2.Items.Add(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getMonthID());
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int location1Pos;
            int year1Pos;
            int month1Pos;
            int location2Pos;
            int year2Pos;
            int month2Pos;

            location1Pos = combLocation1.SelectedIndex;
            year1Pos = combYear1.SelectedIndex;
            month1Pos = combMonth1.SelectedIndex;
            location2Pos = combLocation2.SelectedIndex;
            year2Pos = combYear2.SelectedIndex;
            month2Pos = combMonth2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen loc1Pen = new Pen(Color.Red);
            Pen loc2Pen = new Pen(Color.Blue);

            block.DrawLine(chartLines, 0, 249, 500, 249);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            block.DrawRectangle(loc1Pen, 5, 248 - Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[month1Pos].getMaxTemp()), 10, Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[month1Pos].getMaxTemp()) );
        }


    }
}
