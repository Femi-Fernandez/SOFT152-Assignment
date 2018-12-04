using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Assignment
{
    class Year
    {
        private string year;
        private string yearDesc;
        private Month[] monthInfo;

        public Year(string theYear, string theYearDesc, Month[] themonthinfo)
        {
            year = theYear;
            yearDesc = theYearDesc;
            monthInfo = themonthinfo;
        }

        public string getYear()
        {
            return year;
        }
        public string getYearDesc()
        {
            return yearDesc;
        }
        public Month[] getmonthinfo()
        {
            return monthInfo;
        }

        
        public void setYear(string inYear)
        {
            year = inYear;
        }
        public void setYearDesc(string inYearDesc)
        {
            yearDesc = inYearDesc;
        }
        public void setmonthinfo(Month[] inmonthinfo)
        {
            monthInfo = inmonthinfo;
        }



    }
}
