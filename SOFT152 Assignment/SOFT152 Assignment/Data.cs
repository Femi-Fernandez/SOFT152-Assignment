using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOFT152_Assignment
{
    class Data
    {
        public static Location[] locations;


        private int numLocation;

        public int getNumLocation()
        {
            return numLocation;
        }

        public void setNumLocation(int inNumLocation)
        {
            numLocation = inNumLocation;
        }


        public static void UpdateInputFile()
        {
            StreamWriter locationfile = new StreamWriter("inputEXTENDED.txt");

            locationfile.WriteLine("11");

            for (int i = 0; i < 11; i++)
            {
                locationfile.WriteLine(locations[i].getLocationName());
                locationfile.WriteLine(locations[i].getStreetName());
                locationfile.WriteLine(locations[i].getCountry());
                locationfile.WriteLine(locations[i].getPostcode());
                locationfile.WriteLine(locations[i].getLatitude());
                locationfile.WriteLine(locations[i].getLongitude());
                locationfile.WriteLine(locations[i].getnumyears());

                for (int j = 0; j < locations[i].getnumyears(); j++)
                {
                    locationfile.WriteLine(locations[i].getyearinfo()[j].getYearDesc());
                    locationfile.WriteLine(locations[i].getyearinfo()[j].getYear());

                    for (int k = 0; k < 12; k++)
                    {
                        if (k==0)
                        {
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMonthID());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMaxTemp());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMinTemp());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getAirFrostNum());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMmOfRain());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getHoursOfSun());
                        }
                        else
                        {
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getYear());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMonthID());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMaxTemp());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMinTemp());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getAirFrostNum());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getMmOfRain());
                            locationfile.WriteLine(locations[i].getyearinfo()[j].getmonthinfo()[k].getHoursOfSun());
                        }
                    }
                }
            }

            locationfile.Close();

        }
    }


}
