using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TrayWeek.GUI
{
    public class DateHelper
    {

        public static int GetCurrentWeekNumber(DateTime date, DayOfWeek dayOfWeek)
        {
            System.Globalization.GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
            return calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, dayOfWeek);
        }


        public static int GetCurrentWeekNumber(DateTime date)
        {
            return GetCurrentWeekNumber(date, DayOfWeek.Monday);
        }


        public static int GetCurrentWeekNumber()
        {
            return GetCurrentWeekNumber(DateTime.Now);
        }

        public static DayOfWeek GetWeekStartDayEnum(string weekDay)
        {
            switch(weekDay)
            {
                case "Tuseday":
                    return DayOfWeek.Tuesday;
                case "Wednesday":
                    return DayOfWeek.Wednesday;
                case "Thursday":
                    return DayOfWeek.Thursday;
                case "Friday":
                    return DayOfWeek.Friday;
                case "Saturday":
                    return DayOfWeek.Saturday;
                case "Sunday":
                    return DayOfWeek.Sunday;
                default:
                    return DayOfWeek.Monday;   
            }
        }
    }
}
