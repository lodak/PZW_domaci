using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class MyDate
    {
        private int day;
        private int month;
        private int year;

        public MyDate(int theDay, int theMonth, int theYear)
        {

            Day = theDay;
            Month = theMonth;
            Year = theYear;
            Console.WriteLine("bla{0}", this);

        }


        public int Day
        {
            get
            {
                return day;
            }
            private set
            {

                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;

                else if (Month == 2 && value == 29 && (Year % 400 == 0 ||
                    (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int RemainingDaysInMonth()
        {
            return dayPerMonth[month - 1] - day;
        }


        public int Month
        {
            get
            {
                return month;
            }

            private set
            {



                if (value > 0 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string[] months = new string[12] {"January", "February", "March", "April",
                                                 "May", "June", "July", "August",
                                                 "September", "October", "November", "December"};

        public int[] dayPerMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public string GetMonthName()
        {
            return "The name of the month is " + months[month - 1] + ".";
        }


        public int Year
        {
            get
            {
                return year;
            }

            private set
            {

                if (value >= 1900 && value <= 2100)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException();
            }


        }
        
    }
}
