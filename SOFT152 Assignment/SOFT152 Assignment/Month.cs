using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Assignment
{
    class Month
    {
        private string monthID;
        private string maxTemp;
        private string minTemp;
        private string airFrostNum;
        private string mmOfRain;
        private string hoursOfSun;

        public Month(string theMonthID, string theMaxTemp, string theMinTemp,
                     string theAirFrostNum, string theMmOfRain, string theHoursOfSun)
        {
            monthID = theMonthID;
            maxTemp = theMaxTemp;
            minTemp = theMinTemp;
            airFrostNum = theAirFrostNum;
            mmOfRain = theMmOfRain;
            hoursOfSun = theHoursOfSun;
        }

        public string getMonthID()
        {
            return monthID;
        }
        public string getMaxTemp()
        {
            return maxTemp;
        }
        public string getMinTemp()
        {
            return minTemp;
        }
        public string getAirFrostNum()
        {
            return airFrostNum;
        }
        public string getMmOfRain()
        {
            return mmOfRain;
        }
        public string getHoursOfSun()
        {
            return hoursOfSun;
        }


        public void setMonthID(string inMonthID)
        {
            monthID = inMonthID;
        }
        public void setMaxTemp(string inMaxTemp)
        {
            maxTemp = inMaxTemp;
        }
        public void setMinTemp(string inMinTemp)
        {
            minTemp = inMinTemp;
        }
        public void setAirFrostNum(string inAirFrostNum)
        {
            airFrostNum = inAirFrostNum;
        }
        public void setMmOfRain(string inMmOfRain)
        {
            mmOfRain = inMmOfRain;
        }
        public void setHoursOfSun(string inHoursOfSun)
        {
            hoursOfSun = inHoursOfSun;
        }



    }
}
