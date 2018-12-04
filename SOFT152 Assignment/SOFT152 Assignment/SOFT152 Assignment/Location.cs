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
        private Year[] yearInfo;

        public Location(string theLocationName, string theStreetName, string theCountry,
                        string thePostcode, string theLatitude, string theLongitude, Year[] theYearInfo)
        {
            locationName = theLocationName;
            streetName = theStreetName;
            country = theCountry;
            postcode = thePostcode;
            latitude = theLatitude;
            longitude = theLongitude;
            yearInfo = theYearInfo;
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
        public Year[] getYearInfo()
        {
            return yearInfo;
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
        public void setYearInfo(Year[] inYearInfo)
        {
            yearInfo = inYearInfo;
        }


        public static void SetupLocations()
        {

            StreamReader locFile = new StreamReader("inputEXTENDED.txt");

            for (int i = 0; i < 2; i++)
            {
                string locationName = locFile.ReadLine();
                string streetName = locFile.ReadLine();
                string country = locFile.ReadLine();
                string postcode = locFile.ReadLine();
                string latitude = locFile.ReadLine();
                string longitude = locFile.ReadLine();
                int numOfYears = Convert.ToInt32(locFile.ReadLine());
                Array.Resize(ref Data.locations, Data.locations.Length + 1);
                Data.locations[i] = new Location(locationName, streetName, country, postcode, latitude, longitude, new Year[numOfYears]);

                for (int j = 0; j < numOfYears; j++)
                {
                    string year = locFile.ReadLine();
                    string yearDesc = locFile.ReadLine();                  
                    Data.locations[i].yearInfo[j] = new Year(year, yearDesc, new Month[12]);

                    for (int k = 0; k < 12; k++)
                    {
                        string monthID = locFile.ReadLine();
                        string maxTemp = locFile.ReadLine();
                        string minTemp = locFile.ReadLine();
                        string airFrostNum = locFile.ReadLine();
                        string mmOfRain = locFile.ReadLine();
                        string hoursOfSun = locFile.ReadLine();

                        Data.locations[i].yearInfo[j].getMonthInfo()[k] = new Month(monthID, maxTemp, minTemp, airFrostNum, mmOfRain, hoursOfSun);
                    }
                }
            }
        }
    }
}
