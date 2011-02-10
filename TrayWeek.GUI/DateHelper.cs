using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TrayWeek.GUI
{
    public class DateHelper
    {
        public static int GetCurrentWeekNumber(DateTime date)
        {
            System.Globalization.GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
            return calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


        public static int GetCurrentWeekNumber()
        {
            return GetCurrentWeekNumber(DateTime.Now);
        }
    }
}
