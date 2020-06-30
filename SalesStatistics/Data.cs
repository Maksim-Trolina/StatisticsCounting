using System;
using System.Collections.Generic;

namespace SalesStatistics
{
    public class Data
    {
        public List<DayData> daysData { get; set; }
    }

    public class DayData
    {
        public DayData(DateTime dateTime, decimal profit)
        {
            Day = dateTime;

            Profit = profit;
        }

        public DateTime Day { get; set; }

        public decimal Profit { get; set; }
    }
}
