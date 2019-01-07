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
        public static frmAnalysis frmKeepAnalysis = null;
        public frmAnalysis()
        {
            InitializeComponent();
            frmKeepAnalysis = this;
        }
        //fill initial comboboxes with locations, also fills the combobox for the chart data type
        private void frmAnalysis_Load(object sender, EventArgs e)
        {
            int numlocations = Data.locations.Length;
            for (int i = 0; i < numlocations; i++)
            {
                combLocation1.Items.Add(Data.locations[i].getLocationName());
            }

            for (int i = 0; i < numlocations; i++)
            {
                combLocation2.Items.Add(Data.locations[i].getLocationName());
            }
            for (int i = 0; i < numlocations; i++)
            {
                combLocation.Items.Add(Data.locations[i].getLocationName());
            }

            combLocation1.SelectedIndex = 0;
            combLocation2.SelectedIndex = 0;

            combLocation.SelectedIndex = 0;

            combDataChoice.Items.Clear();
            combDataChoice.Items.Add("Maximum Temperature");
            combDataChoice.Items.Add("Minimum Temperature");
            combDataChoice.Items.Add("Number of days with air frost");
            combDataChoice.Items.Add("Mm of Rain");
            combDataChoice.Items.Add("Hours of sunlight");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DisplayInfo.frmkeepDisplayInfo.Show();
            frmKeepAnalysis.Close();
        }
        //Location 1 Year combobox fill
        private void combLocation1_SelectedIndexChanged(object sender, EventArgs e)
        {

            combYear1.Items.Clear();
            int location1Pos = combLocation1.SelectedIndex;

            int numyears = Data.locations[location1Pos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear1.Items.Add(Data.locations[location1Pos].getyearinfo()[i].getYear());
            }
            combYear1.SelectedIndex = 0;
        }


        //location 2 year combobox fill
        private void combLocation2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combYear2.Items.Clear();
            int location2Pos = combLocation2.SelectedIndex;

            int numyears = Data.locations[location2Pos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear2.Items.Add(Data.locations[location2Pos].getyearinfo()[i].getYear());
            }
            combYear2.SelectedIndex = 0;
        }



        //Location year combobox fill
        private void combLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            combYear.Items.Clear();
            int locationPos = combLocation.SelectedIndex;

            int numyears = Data.locations[locationPos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear.Items.Add(Data.locations[locationPos].getyearinfo()[i].getYear());
            }
            combYear.SelectedIndex = 0;
        }




        private void btnPlotChart_Click(object sender, EventArgs e)
        {
            GetChartDataType();
        }

        private void GetChartDataType()
        {
            int dataChoice;

            dataChoice = combDataChoice.SelectedIndex;

            if (dataChoice == 0)
            {
                MaxTempData();
            }
            else if (dataChoice == 1)
            {
                MinTempData();
            }
            else if (dataChoice == 2)
            {
                NumAirFrostData();
            }
            else if (dataChoice == 3)
            {
                MmOfRainData();
            }
            else
            {
                HoursOfSunData();
            }
            


        }

        private void MaxTempData()
        {
            int location1Pos;
            int year1Pos;
            int location2Pos;
            int year2Pos;
            int location3Pos;
            int year3Pos;

            location1Pos = combLocation.SelectedIndex;
            year1Pos = combYear.SelectedIndex;
            location2Pos = combLocation1.SelectedIndex;
            year2Pos = combYear1.SelectedIndex;
            location3Pos = combLocation2.SelectedIndex;
            year3Pos = combYear2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen chartPen1 = new Pen(Color.Red);
            Pen chartPen2 = new Pen(Color.Blue);
            Pen chartPen3 = new Pen(Color.Green);

            block.DrawLine(chartLines, 0, 125, 500, 125);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            float startPointX = 0;

            for (int i = 0; i < 11; i++)
            {
                if ((location1Pos != -1)&&(year1Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getMaxTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i + 1].getMaxTemp());

                    block.DrawLine(chartPen1, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location2Pos != -1) && (year2Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getMaxTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i + 1].getMaxTemp());

                    block.DrawLine(chartPen2, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location3Pos != -1) && (year3Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i].getMaxTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i + 1].getMaxTemp());

                    block.DrawLine(chartPen3, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                startPointX = startPointX + 40;
            }
            lbl0of5.Text = "-25";
            lbl1of5.Text = "-15";
            lbl2of5.Text = "-5";
            lbl3of5.Text = "5";
            lbl4of5.Text = "15";
            lbl5of5.Text = "25";
        }

        private void MinTempData()
        {
            int location1Pos;
            int year1Pos;
            int location2Pos;
            int year2Pos;
            int location3Pos;
            int year3Pos;

            location1Pos = combLocation.SelectedIndex;
            year1Pos = combYear.SelectedIndex;
            location2Pos = combLocation1.SelectedIndex;
            year2Pos = combYear1.SelectedIndex;
            location3Pos = combLocation2.SelectedIndex;
            year3Pos = combYear2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen chartPen1 = new Pen(Color.Red);
            Pen chartPen2 = new Pen(Color.Blue);
            Pen chartPen3 = new Pen(Color.Green);

            block.DrawLine(chartLines, 0, 125, 500, 125);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            float startPointX = 0;

            for (int i = 0; i < 11; i++)
            {
                if ((location1Pos != -1) && (year1Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getMinTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i + 1].getMinTemp());

                    block.DrawLine(chartPen1, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location2Pos != -1) && (year2Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getMinTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i + 1].getMinTemp());

                    block.DrawLine(chartPen2, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location3Pos != -1) && (year3Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i].getMinTemp());
                    float endPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i + 1].getMinTemp());

                    block.DrawLine(chartPen3, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                startPointX = startPointX + 40;
            }
            lbl0of5.Text = "-25";
            lbl1of5.Text = "-15";
            lbl2of5.Text = "-5";
            lbl3of5.Text = "5";
            lbl4of5.Text = "15";
            lbl5of5.Text = "25";
        }

        private void NumAirFrostData()
        {
            int location1Pos;
            int year1Pos;
            int location2Pos;
            int year2Pos;
            int location3Pos;
            int year3Pos;

            location1Pos = combLocation.SelectedIndex;
            year1Pos = combYear.SelectedIndex;
            location2Pos = combLocation1.SelectedIndex;
            year2Pos = combYear1.SelectedIndex;
            location3Pos = combLocation2.SelectedIndex;
            year3Pos = combYear2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen chartPen1 = new Pen(Color.Red);
            Pen chartPen2 = new Pen(Color.Blue);
            Pen chartPen3 = new Pen(Color.Green);

            block.DrawLine(chartLines, 0, 125, 500, 125);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            float startPointX = 0;

            for (int i = 0; i < 11; i++)
            {
                if ((location1Pos != -1) && (year1Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getAirFrostNum());
                    float endPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i + 1].getAirFrostNum());

                    block.DrawLine(chartPen1, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location2Pos != -1) && (year2Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getAirFrostNum());
                    float endPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i + 1].getAirFrostNum());

                    block.DrawLine(chartPen2, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                if ((location3Pos != -1) && (year3Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i].getAirFrostNum());
                    float endPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i + 1].getAirFrostNum());

                    block.DrawLine(chartPen3, startPointX, -startPointY*5 + 125, startPointX + 40, -endPointY*5 + 125);
                }
                startPointX = startPointX + 40;
            }
            lbl0of5.Text = "-25";
            lbl1of5.Text = "-15";
            lbl2of5.Text = "-5";
            lbl3of5.Text = "5";
            lbl4of5.Text = "15";
            lbl5of5.Text = "25";
        }

        private void MmOfRainData()
        {
            int location1Pos;
            int year1Pos;
            int location2Pos;
            int year2Pos;
            int location3Pos;
            int year3Pos;

            location1Pos = combLocation.SelectedIndex;
            year1Pos = combYear.SelectedIndex;
            location2Pos = combLocation1.SelectedIndex;
            year2Pos = combYear1.SelectedIndex;
            location3Pos = combLocation2.SelectedIndex;
            year3Pos = combYear2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen chartPen1 = new Pen(Color.Red);
            Pen chartPen2 = new Pen(Color.Blue);
            Pen chartPen3 = new Pen(Color.Green);

            block.DrawLine(chartLines, 0, 249, 500, 249);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            float startPointX = 0;

            for (int i = 0; i < 11; i++)
            {
                if ((location1Pos != -1) && (year1Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getMmOfRain());
                    float endPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i + 1].getMmOfRain());

                    block.DrawLine(chartPen1, startPointX, -startPointY + 250, startPointX + 40, -endPointY +250 );
                }
                if ((location2Pos != -1) && (year2Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getMmOfRain());
                    float endPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i + 1].getMmOfRain());

                    block.DrawLine(chartPen2, startPointX, -startPointY + 250, startPointX + 40, -endPointY + 250);
                }
                if ((location3Pos != -1) && (year3Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i].getMmOfRain());
                    float endPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i + 1].getMmOfRain());

                    block.DrawLine(chartPen3, startPointX, -startPointY + 250, startPointX + 40, -endPointY + 250);
                }
                startPointX = startPointX + 40;
            }
            lbl0of5.Text = "0";
            lbl1of5.Text = "50";
            lbl2of5.Text = "100";
            lbl3of5.Text = "150";
            lbl4of5.Text = "200";
            lbl5of5.Text = "250";
        }

        private void HoursOfSunData()
        {
            int location1Pos;
            int year1Pos;
            int location2Pos;
            int year2Pos;
            int location3Pos;
            int year3Pos;

            location1Pos = combLocation.SelectedIndex;
            year1Pos = combYear.SelectedIndex;
            location2Pos = combLocation1.SelectedIndex;
            year2Pos = combYear1.SelectedIndex;
            location3Pos = combLocation2.SelectedIndex;
            year3Pos = combYear2.SelectedIndex;

            Graphics block;
            block = picChart.CreateGraphics();
            block.Clear(Color.White);

            Pen chartLines = new Pen(Color.Black);
            Pen chartPen1 = new Pen(Color.Red);
            Pen chartPen2 = new Pen(Color.Blue);
            Pen chartPen3 = new Pen(Color.Green);

            block.DrawLine(chartLines, 0, 249, 500, 249);
            block.DrawLine(chartLines, 0, 0, 0, 250);

            float startPointX = 0;

            for (int i = 0; i < 11; i++)
            {
                if ((location1Pos != -1) && (year1Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i].getHoursOfSun());
                    float endPointY = Convert.ToSingle(Data.locations[location1Pos].getyearinfo()[year1Pos].getmonthinfo()[i + 1].getHoursOfSun());

                    block.DrawLine(chartPen1, startPointX, -startPointY + 250, startPointX + 40, -endPointY + 250);
                }
                if ((location2Pos != -1) && (year2Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i].getHoursOfSun());
                    float endPointY = Convert.ToSingle(Data.locations[location2Pos].getyearinfo()[year2Pos].getmonthinfo()[i + 1].getHoursOfSun());

                    block.DrawLine(chartPen2, startPointX, -startPointY + 250, startPointX + 40, -endPointY + 250);
                }
                if ((location3Pos != -1) && (year3Pos != -1))
                {
                    float startPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i].getHoursOfSun());
                    float endPointY = Convert.ToSingle(Data.locations[location3Pos].getyearinfo()[year3Pos].getmonthinfo()[i + 1].getHoursOfSun());

                    block.DrawLine(chartPen3, startPointX, -startPointY + 250, startPointX + 40, -endPointY + 250);
                }
                startPointX = startPointX + 40;
            }
            lbl0of5.Text = "0";
            lbl1of5.Text = "50";
            lbl2of5.Text = "100";
            lbl3of5.Text = "150";
            lbl4of5.Text = "200";
            lbl5of5.Text = "250";
        }



        private void combYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reworked analysis page and cannot delete
        }
        private void combYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reworked analysis page and cannot delete
        }
        private void combMonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Added accidentaly and cannot remove
        }
        private void combYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reworked analysis page and cannot delete
        }


    }
}
