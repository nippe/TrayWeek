using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TrayWeek.GUI
{
    public class DateHelper
    {

        public static int GetCurrentWeekNumber(DateTime date, DayOfWeek dayOfWeek, CalendarWeekRule weekRule)
        {
            System.Globalization.GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
            return calendar.GetWeekOfYear(date, weekRule, dayOfWeek);  
        }
        

        //TODO: Try to use DayOfWeek.TryParse instead, but need to get tests in place for that.
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



        // input
        //First 4-day week
        //1 january
        //First full week
        public static CalendarWeekRule GetCalendarWeekRule(string firstWeekOfYear)
        {
            switch (firstWeekOfYear)
            {

                case "First full week":
                    return CalendarWeekRule.FirstFullWeek;
                case "1 january":
                    return CalendarWeekRule.FirstDay;   
                default:
                    return CalendarWeekRule.FirstFourDayWeek;
            }
        }
    }
}
