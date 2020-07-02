using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalesStatistics
{
    public class Statistics
    {

        public string GetMostProfitableDayOfWeek(Data data)
        {
            if(data == null)
            {
                return null;
            }

            var daysGroup = from day in data.daysData
                            group day by day.Day.DayOfWeek;

            decimal max = -1;

            string dayOfWeek = null;

            foreach(IGrouping<DayOfWeek,DayData> days in daysGroup)
            {
                decimal sum = 0;

                foreach(var day in days)
                {
                    sum += day.Profit;
                }

                if (sum > max)
                {
                    max = sum;

                    dayOfWeek = days.Key.ToString();
                }
            }

            return dayOfWeek;
        }
    }
}
