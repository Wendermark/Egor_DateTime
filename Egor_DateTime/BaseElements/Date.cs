using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_DateTime.BaseElements
{
    struct Date
    {

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day { get; private set; }

        public int Month { get; private set; }

        public int Year { get; private set; }

        public static string operator - (Date firstDate , Date secondDate) => $"Разность дат составляет { ((firstDate.Day + firstDate.Month*31 + firstDate.Year*365) - (secondDate.Day + secondDate.Month*31 + secondDate.Year*365) ).ToString() } дней";

        public void ShowDate() => Console.WriteLine($"День = {Day.ToString()}, Месяц = {Month.ToString()}, Год = {Year.ToString()}");
        
        public static Date operator + (Date date, int days)
        {
            int year = date.Year;

            int month = date.Month;

            int day = date.Day + days;

            if (day > 31)
            {
                day -= 31;

                month += 1;

                    if (month > 12)
                    {
                        month -= 12;

                        year += 1;
                    }
            }

            return new Date(day, month, year);
        }


    }
}
