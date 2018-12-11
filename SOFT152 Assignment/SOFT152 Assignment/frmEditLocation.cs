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
    public partial class frmEditLocation : Form
    {

        public static frmEditLocation frmkeepEditLocaiton = null;

        public frmEditLocation()
        {
            InitializeComponent();
            frmkeepEditLocaiton = this;
        }

        private void frmEditLocation_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                comblocation.Items.Add(Data.locations[i].getLocationName());
            }
        }

        private void comblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationpos = comblocation.SelectedIndex;

            lstLocations.Items.Clear();

            lstLocations.Items.Add("Location name: " + Data.locations[locationpos].getLocationName());
            lstLocations.Items.Add("Street name: " + Data.locations[locationpos].getStreetName());
            lstLocations.Items.Add("Country: " + Data.locations[locationpos].getCountry());
            lstLocations.Items.Add("Postcode: " + Data.locations[locationpos].getPostcode());
            lstLocations.Items.Add("Latitude: " + Data.locations[locationpos].getLatitude());
            lstLocations.Items.Add("Longitude: " + Data.locations[locationpos].getLongitude());
        }

        private void btnEditLocationInfo_Click(object sender, EventArgs e)
        {
            EditLocationValues();
        }

        private void EditLocationValues()
        {
            string newLocName;
            string newLocStreet;
            string newLocCountry;
            string newLocPostcode;
            string newLocLatitude;
            string newLocLongitude;

            newLocName = txtNewLocName.Text;
            newLocStreet = txtNewLocStreet.Text;
            newLocCountry = txtNewLocCountry.Text;
            newLocPostcode = txtNewLocPostcode.Text;
            newLocLatitude = txtNewLocLat.Text;
            newLocLongitude = txtNewLocLat.Text;

            int locationpos = comblocation.SelectedIndex;

            Data.locations[locationpos].setLocationName(newLocName);
            Data.locations[locationpos].setStreetName(newLocStreet);
            Data.locations[locationpos].setCountry(newLocCountry);
            Data.locations[locationpos].setPostcode(newLocPostcode);
            Data.locations[locationpos].setLatitude(newLocLatitude);
            Data.locations[locationpos].setLongitude(newLocLongitude);
            MessageBox.Show("new values have been set");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayInfo.frmkeepDisplayInfo.Show();
            frmkeepEditLocaiton.Close();
        }
    }
}
