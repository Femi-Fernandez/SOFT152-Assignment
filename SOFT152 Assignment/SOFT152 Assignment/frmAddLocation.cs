using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO; (    UNCOMMENT IF USING CODE BELOW   )

namespace SOFT152_Assignment
{
    public partial class frmAddLocation : Form
    {

        public static frmAddLocation frmkeepAddLocation = null;
        public frmAddLocation()
        {
            InitializeComponent();
            frmkeepAddLocation = this;
        }

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            string newLocName;
            string newLocStreet;
            string newLocCountry;
            string newLocPostcode;
            string newLocLatitude;
            string newLocLongitude;
            int newLocNumYears;

            newLocName = txtNewLocName.Text;
            newLocStreet = txtNewLocStreet.Text;
            newLocCountry = txtNewLocCountry.Text;
            newLocPostcode = txtNewLocPostcode.Text;
            newLocLatitude = txtNewLocLatitude.Text;
            newLocLongitude = txtNewLocLongitude.Text;
            newLocNumYears = Convert.ToInt32(txtNewLocNumYears.Text);

            //Location[] tempLocation = Data.locations;
            //Array.Resize(ref tempLocation, tempLocation.Length + 1);
            //Data.locations = tempLocation;
            Array.Resize(ref Data.locations, Data.locations.Length + 1);

            int newLocationPos = Data.locations.Length - 1;

            Data data = new Data();
            data.setNumLocation(newLocationPos);
            Data.locations[newLocationPos] = new Location(newLocName, newLocStreet, newLocCountry, newLocPostcode, newLocLatitude, newLocLongitude, newLocNumYears,  new Year[newLocNumYears]);
            
            //Data.locations[newLocationPos].setLocationName(newLocName);
            //Data.locations[newLocationPos].setStreetName(newLocStreet);
            //Data.locations[newLocationPos].setCountry(newLocCountry);
            //Data.locations[newLocationPos].setPostcode(newLocPostcode);
            //Data.locations[newLocationPos].setLatitude(newLocLatitude);
            //Data.locations[newLocationPos].setLongitude(newLocLongitude);
            //Data.locations[newLocationPos].setnumyears(newLocNumYears);

            for (int i = 0; i < newLocNumYears; i++)
            {
                Data.locations[newLocationPos].getyearinfo()[i] = new Year("0","0", new Month[12]);

                for (int j = 0; j < 12; j++)
                {
                    Data.locations[newLocationPos].getyearinfo()[i].getmonthinfo()[j] = new Month(Convert.ToString(j), "0", "0", "0", "0", "0");
                }
            }

            MessageBox.Show("New location added with empty years and months. to edit the ears and months, please use the edit year and edit month form");

            //*****************************************************************
            //*****************************************************************
            //*****************************************************************
            //ONLY USE THIS IF YOU CANT FIND WHERE TO STORE NUMBER OF LOCATIONS
            //*****************************************************************
            //*****************************************************************
            //*****************************************************************


            //StreamReader locationfile_Numlocations = new StreamReader("inputEXTENDED.txt");
            //
            //string locationnumFile = locationfile_Numlocations.ReadLine();
            //
            //locationfile_Numlocations.Close();
            //
            //Convert.ToInt32(locationnumFile);
            //locationnumFile = locationnumFile + 1;
            //Convert.ToString(locationnumFile);
            //
            //StreamWriter locationfile = new StreamWriter("inputEXTENDED.txt");
            //locationfile.WriteLine(locationnumFile);


            //*****************************************************************
            //*****************************************************************
            //*****************************************************************
            //ONLY USE THIS IF YOU CANT FIND WHERE TO STORE NUMBER OF LOCATIONS
            //*****************************************************************
            //*****************************************************************
            //*****************************************************************




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DisplayInfo.frmkeepDisplayInfo.Show();
            frmkeepAddLocation.Close();
        }
    }
}
