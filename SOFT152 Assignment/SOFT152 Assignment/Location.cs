using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOFT152_Assignment
{
    class Location
    {

        private string locationName;
        private string streetName;
        private string country;
        private string postcode;
        private string latitude;
        private string longitude;
        private int numYears;
        private Year[] yearInfo;

        public Location(string theLocationName, string theStreetName, string theCountry,
                        string thePostcode, string theLatitude, string theLongitude, int theNumYears, Year[] theyearinfo)
        {
            locationName = theLocationName;
            streetName = theStreetName;
            country = theCountry;
            postcode = thePostcode;
            latitude = theLatitude;
            longitude = theLongitude;
            numYears = theNumYears;
            yearInfo = theyearinfo;
        }

        public string getLocationName()
        {
            return locationName;
        }
        public string getStreetName()
        {
            return streetName;
        }
        public string getCountry()
        {
            return country;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public string getLatitude()
        {
            return latitude;
        }
        public string getLongitude()
        {
            return longitude;
        }
        public Year[] getyearinfo()
        {
            return yearInfo;
        }
        public int getnumyears()
        {
            return numYears;
        }


        public void setLocationName(string inLocationName)
        {
            locationName = inLocationName;
        }
        public void setStreetName(string inStreetName)
        {
            streetName = inStreetName;
        }
        public void setCountry(string inCountry)
        {
            country = inCountry;
        }
        public void setPostcode(string inPostcode)
        {
            postcode = inPostcode;
        }
        public void setLatitude(string inLatitude)
        {
            latitude = inLatitude;
        }
        public void setLongitude(string inLongitude)
        {
            longitude = inLongitude;
        }
        public void setnumyears(int innumyears)
        {
            numYears = innumyears;
        }
        public void setyearinfo(Year[] inyearinfo)
        {
            yearInfo = inyearinfo;
        }

        public static void setupLocationArray()
        {
            //this opens the file so the code can read data from it. 
            StreamReader locationfile = new StreamReader("inputEXTENDED.txt");
            
            int numoflocations = Convert.ToInt32(locationfile.ReadLine());

            //Data data = new Data();

            //data.setNumLocation(numoflocations);


            //this will loop however many locations there are.
            for (int i = 0; i < numoflocations; i++)
            {
                string locationname = locationfile.ReadLine();
                string streetname = locationfile.ReadLine();
                string country = locationfile.ReadLine();
                string postcode = locationfile.ReadLine();
                string latitude = locationfile.ReadLine();
                string longitude = locationfile.ReadLine();
                string numberOfyears = locationfile.ReadLine();
                int numyears = Convert.ToInt32(numberOfyears);

                Array.Resize(ref Data.locations, Data.locations.Length + 1);

                Data.locations[i] = new Location(locationname, streetname, country, postcode, latitude, longitude, numyears, new Year[numyears]);

                //this will loop based on what value numyears is. 
                for (int j = 0; j < numyears; j++)
                {
                    string yeardesc = locationfile.ReadLine();
                    string yearID = locationfile.ReadLine();
                    
                    Data.locations[i].yearInfo[j] = new Year(yearID, yeardesc, new Month[12]);
                    //this loops 12 times because, there are 12 months in a year
                    for (int k = 0; k < 12; k++)
                    {

                        //this if else statement is required because each month has the year ID above it
                        //what this does is skip the first yearID readline so no errors occur. 
                        if (k == 0)
                        {
                            string monthID = locationfile.ReadLine();
                            string maxtemp = locationfile.ReadLine();
                            string mintemp = locationfile.ReadLine();
                            string numairfrost = locationfile.ReadLine();
                            string mmofrain = locationfile.ReadLine();
                            string hoursofsun = locationfile.ReadLine();
                            Data.locations[i].yearInfo[j].getmonthinfo()[k] = new Month(monthID, maxtemp, mintemp, numairfrost, mmofrain, hoursofsun);
                        }
                        else
                        {
                            string theyearID = locationfile.ReadLine();
                            string monthID = locationfile.ReadLine();
                            string maxtemp = locationfile.ReadLine();
                            string mintemp = locationfile.ReadLine();
                            string numairfrost = locationfile.ReadLine();
                            string mmofrain = locationfile.ReadLine();
                            string hoursofsun = locationfile.ReadLine();
                            Data.locations[i].yearInfo[j].getmonthinfo()[k] = new Month(monthID, maxtemp, mintemp, numairfrost, mmofrain, hoursofsun);
                        }
                        
                    }
                }
            }

            locationfile.Close();
        }

    }
}
