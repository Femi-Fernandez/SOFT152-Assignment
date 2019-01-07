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
            
            //if any of the boxes are empty, throw up an error. 
            if ((newLocName == "") || (newLocStreet == "") || (newLocCountry == "") || (newLocPostcode == "") || (newLocLatitude == "") || (newLocLongitude == ""))
            {
                MessageBox.Show("Please make sure all boxes are filled");
            }
            else
            {
                //this will try convert the new number of years into an integer, and if it cant it will throw up an error, if it
                //can though it will continue to do the rest of the code. 
                try
                {
                    newLocNumYears = Convert.ToInt32(txtNewLocNumYears.Text);

                    Array.Resize(ref Data.locations, Data.locations.Length + 1);

                    int newLocationPos = Data.locations.Length - 1;

                    Data.locations[newLocationPos] = new Location(newLocName, newLocStreet, newLocCountry, newLocPostcode, newLocLatitude, newLocLongitude, newLocNumYears, new Year[newLocNumYears]);

                    for (int i = 0; i < newLocNumYears; i++)
                    {
                        Data.locations[newLocationPos].getyearinfo()[i] = new Year("0", "0", new Month[12]);

                        for (int j = 0; j < 12; j++)
                        {
                            Data.locations[newLocationPos].getyearinfo()[i].getmonthinfo()[j] = new Month(Convert.ToString(j + 1), "0", "0", "0", "0", "0");
                        }
                    }

                    MessageBox.Show("New location added with empty years and months. to edit the ears and months, please use the edit year and edit month form");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please make sure that the number of years only contains numbers.");
                    
                }
                
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DisplayInfo.frmkeepDisplayInfo.Show();
            frmkeepAddLocation.Close();
        }
    }
}
