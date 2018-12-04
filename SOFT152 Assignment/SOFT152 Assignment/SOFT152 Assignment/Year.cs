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

        public Year(string theYear, string theYearDesc, Month[] theYearsMonthInfo)
        {
            year = theYear;
            yearDesc = theYearDesc;
            monthInfo = theYearsMonthInfo;
        }

        public string getYear()
        {
            return year;
        }
        public string getYearDesc()
        {
            return yearDesc;
        }
        public Month[] getMonthInfo()
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
        public void setMonthInfo(Month[] inMonthInfo)
        {
            monthInfo = inMonthInfo;
        }


    }
}
