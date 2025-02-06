using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = Checkday(year, month, day);
        }
		private int CheckMonth(int month)
		{
			if (month >= 1 && month <= 12)
			{
				return month;
			}

			throw new MonthException("Invalid Month");
		}
		private int Checkday(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

                
            throw new DayException("Invalid Day");
        }

        private bool IsLeapYear(int year)
        {
           return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
}
