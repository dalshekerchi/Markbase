using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLogin
{
    class Valid//this used got getset and encapsulation?
    {
        private int day;//private is more secure than public cannot be seen by just anyone
        private int month;
        private int mark;

        public Valid(int aDay, int aMonth)//gets the info from the method
        {
            Day = aDay;
            Month = aMonth;
        }
        public Valid(int kn, int app, int th, int com)//this is to make sure the range is for all 4 categories
        {
            Mark = kn;
            Mark = app;
            Mark = th;
            Mark = com;
        }
        
        public int Month //This will get and set the value of month but will only get the months once it is verified that the month has a range between 1-12
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 13)
                {
                    month = value;
                }
                else
                {
                    month = 0;
                }
            }
        }
        public int Day //This will get and set the value of day but will only get the day once it is verified that the day has a range between 1-31
        {
            get { return day; }
            set
            {
                if (value > 0 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    day = 0;
                }
            }
        }
       
        public int Mark //This will get and set the value of marks but will only get the marks once it is verified that the mark has a range between 0 and 100
        {
            get { return mark; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mark = value;
                }
                else
                {
                    mark = 0;
                }
            }
        }
    }
}
