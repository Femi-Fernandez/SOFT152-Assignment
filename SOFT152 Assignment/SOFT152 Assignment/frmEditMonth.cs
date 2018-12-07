﻿using System;
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
    public partial class frmEditMonth : Form
    {

        public static frmEditMonth frmkeepEditMonth = null;
        public frmEditMonth()
        {
            InitializeComponent();
            frmkeepEditMonth = this;
        }
        private void frmEditMonth_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                combLocation.Items.Add(Data.locations[i].getLocationName());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            int numyears = Data.locations[locationpos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear.Items.Add(Data.locations[locationpos].getyearinfo()[i].getYearDesc());
            }
        }

        private void combYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;

            int yearpos = combYear.SelectedIndex;

            for (int i = 0; i < 12; i++)
            {
                combMonth.Items.Add(Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[i].getMonthID());
            }

        }

        private void combMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = combLocation.SelectedIndex;
            int yearpos = combYear.SelectedIndex;
            int monthpos = combMonth.SelectedIndex;

            lstCurrentmonth.Items.Clear();

            lstCurrentmonth.Items.Add("Month: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getMonthID());
            lstCurrentmonth.Items.Add("Max Temperature: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getMaxTemp());
            lstCurrentmonth.Items.Add("Min temp: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getMinTemp());
            lstCurrentmonth.Items.Add("Number of days with air frost: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getAirFrostNum());
            lstCurrentmonth.Items.Add("mm of rain: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getMmOfRain());
            lstCurrentmonth.Items.Add("Hours of sun: " + Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getHoursOfSun());
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Data.locations[0].getyearinfo()[0].getmonthinfo()[0].getMaxTemp());
            //DisplayInfo temdisplayinfo = new DisplayInfo();
            DisplayInfo.frmkeepDisplayInfo.Show();
            //temdisplayinfo.Show();
            frmkeepEditMonth.Close();
            MessageBox.Show(Data.locations[0].getyearinfo()[0].getmonthinfo()[0].getMaxTemp());
        }

        private void btnEditAll_Click(object sender, EventArgs e)
        {
            EditMonthValues();
        }

        private void EditMonthValues()
        {
            string newmaxtemp = txtnewMaxTemp.Text;
            string newmintemp = txtNewMinTemp.Text;
            string newnumfrostdays = txtNumFrostDays.Text;
            string newmmofrain = txtNewMmOfRain.Text;
            string newhoursofsun = txtNewHoursOfSun.Text;

            int locationpos = combLocation.SelectedIndex;
            int yearpos = combYear.SelectedIndex;
            int monthpos = combMonth.SelectedIndex;


            //Month[] newmonth = new Month[0];
            //newmonth[0] = new Month(Convert.ToString(monthpos), newmaxtemp, newmintemp, newnumfrostdays, newmmofrain, newhoursofsun);
            //Data.locations[locationpos].getyearinfo()[yearpos].setmonthinfo(newmonth);

            Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setMaxTemp(newmaxtemp);
            MessageBox.Show(locationpos.ToString()+" "+yearpos+" "+monthpos+" "+Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].getMaxTemp());
            //Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setMaxTemp(newmaxtemp);
            //Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setMinTemp(newmintemp);
            //Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setAirFrostNum(newnumfrostdays);
            //Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setMmOfRain(newmmofrain);
            //Data.locations[locationpos].getyearinfo()[yearpos].getmonthinfo()[monthpos].setHoursOfSun(newhoursofsun);

        }
    }
}
